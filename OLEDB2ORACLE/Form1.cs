using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Data.OleDb;
using Maticsoft.DBUtility;

namespace OLEDB2ORACLE
{
    public partial class OLEDB2ORACLE : Form
    {
        public OLEDB2ORACLE()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "(*.xls)|*.xls";

            //判断用户是否正确的选择了文件
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择文件的后缀名
                // string extension = Path.GetExtension(fileDialog.FileName);
                //FilePath.AutoSize = false;
                //FilePath.Dock = DockStyle.Fill;
                //FilePath.Width = 510;
                //FilePath.Height = 40;
                FilePath.Text = fileDialog.FileName;
                //FileInfo fileInfo = new FileInfo(fileDialog.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 将Excel文件导出至DataTable(第一行作为表头)
        /// </summary>
        /// <param name="ExcelFilePath">Excel文件路径</param>
        /// <param name="TableName">数据表名</param>
        public static DataTable InputFromExcel(string ExcelFilePath, string TableName)
        {
            if (!File.Exists(ExcelFilePath))
            {
                throw new Exception("Excel文件不存在！");
            }
            DataTable table = new DataTable();
            OleDbConnection dbcon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ExcelFilePath + ";Extended Properties=Excel 8.0");
            OleDbCommand cmd = new OleDbCommand("select * from [" + TableName + "$]", dbcon);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            try
            {
                if (dbcon.State == ConnectionState.Closed)
                {
                    dbcon.Open();
                }
                adapter.Fill(table);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                if (dbcon.State == ConnectionState.Open)
                {
                    dbcon.Close();
                }
            }
            return table;
        }

        private void DataHandle(string file, DataTable[] dts)
        {
            int Field = 0;
            if (dts[0].Rows.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataRow dr in dts[0].Rows)
                {
                    if (file_key.Text.Trim().Length > 0)
                    {
                        string sql = "select * from " + TO_table.Text.Trim() + " where " + file_key.Text.Trim() + "='" + dr[file_key.Text.Trim()].ToString() + "'";
                        DataTable dt = DataConn.MyExecuteDataSet(null, sql).Tables[0];
                        if (dt.Rows.Count > 0)
                        {
                            string[] FIELD = txt_field.Text.Trim().Split(',');
                            string toFIELD = "";
                            for (int i = 0; i < FIELD.Length; i++)
                            {
                                toFIELD += "," + FIELD[i].Split('|')[1] + "='" + dr[FIELD[i].Split('|')[0]].ToString() + "'";
                            }
                            sb.Append("update " + TO_table.Text.Trim() + " set " + toFIELD.Substring(1) + " where " + file_key.Text.Trim() + "='" + dr[file_key.Text.Trim()].ToString() + "';");
                        }
                        else
                        {
                            string[] FIELD = txt_field.Text.Trim().Split(',');
                            string fromFIELD = "", toFIELD = "";
                            for (int i = 0; i < FIELD.Length; i++)
                            {
                                toFIELD += "," + FIELD[i].Split('|')[1];
                                fromFIELD += ",'" + dr[FIELD[i].Split('|')[0]].ToString() + "'";
                            }
                            sb.Append(" insert into " + TO_table.Text.Trim() + "(" + toFIELD.Substring(1) + ") values(" + fromFIELD.Substring(1) + ");");
                        }
                    }
                    else
                    {
                        string[] FIELD = txt_field.Text.Trim().Split(',');
                        string fromFIELD = "", toFIELD = "";
                        for (int i = 0; i < FIELD.Length; i++)
                        {
                            toFIELD += "," + FIELD[i].Split('|')[1];


                            if (FIELD[i].Split('|')[0] == "订单时间")
                            { fromFIELD += ",to_date('" + dr[FIELD[i].Split('|')[0]].ToString() + "','yyyy-mm-dd hh24:mi:ss')"; }
                            else

                            { fromFIELD += ",'" + dr[FIELD[i].Split('|')[0]].ToString() + "'"; }
                        }
                        sb.Append(" insert into " + TO_table.Text.Trim() + "(" + toFIELD.Substring(1) + ") values(" + fromFIELD.Substring(1) + ");");
                    }
                    Field++;
                }
                sb = new StringBuilder("begin " + sb.ToString() + " end;");
                DataConn.MyExecuteNonQuery(null, sb.ToString());
            }
            MessageBox.Show("导入记录：" + Field + "条", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            string file = FilePath.Text;
            if (string.IsNullOrEmpty(file))
            {
                MessageBox.Show("未选择文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //try
                //{
                string tablename = FROM_table.Text.Trim();
                tablename = string.IsNullOrEmpty(tablename) ? "Sheet1" : tablename;
                DataTable[] dts = { InputFromExcel(file, tablename) };
                DataHandle(file, dts);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "导入出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
