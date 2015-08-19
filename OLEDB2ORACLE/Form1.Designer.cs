namespace OLEDB2ORACLE
{
    partial class OLEDB2ORACLE
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectFILE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.Label();
            this.txt_field = new System.Windows.Forms.TextBox();
            this.Import = new System.Windows.Forms.Button();
            this.FROM_table = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TO_table = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.file_key = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectFILE
            // 
            this.selectFILE.Location = new System.Drawing.Point(23, 299);
            this.selectFILE.Name = "selectFILE";
            this.selectFILE.Size = new System.Drawing.Size(75, 23);
            this.selectFILE.TabIndex = 0;
            this.selectFILE.Text = "选择文件";
            this.selectFILE.UseVisualStyleBackColor = true;
            this.selectFILE.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件路径：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.Location = new System.Drawing.Point(115, 50);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(0, 12);
            this.FilePath.TabIndex = 2;
            // 
            // txt_field
            // 
            this.txt_field.Location = new System.Drawing.Point(23, 160);
            this.txt_field.Multiline = true;
            this.txt_field.Name = "txt_field";
            this.txt_field.Size = new System.Drawing.Size(537, 133);
            this.txt_field.TabIndex = 3;
            this.txt_field.Text = "客户姓名|NAME,身份证|IDCARD,开户号码|ORDER_NO,通信地址|ADDRESS,订单时间|ORDER_DATE,联系电话|PHONE,电渠单号|O" +
                "RDER_CODE,型号|PRODUCT,订单归属|BRANCH_NAME,安翼开户日期|OPEN_DATE";
            this.txt_field.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(472, 299);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(75, 23);
            this.Import.TabIndex = 4;
            this.Import.Text = "导入";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // FROM_table
            // 
            this.FROM_table.Location = new System.Drawing.Point(92, 88);
            this.FROM_table.Name = "FROM_table";
            this.FROM_table.Size = new System.Drawing.Size(145, 21);
            this.FROM_table.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "源数据表：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "目标数据表：";
            // 
            // TO_table
            // 
            this.TO_table.Location = new System.Drawing.Point(411, 87);
            this.TO_table.Name = "TO_table";
            this.TO_table.Size = new System.Drawing.Size(149, 21);
            this.TO_table.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "字段对应关系：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "表唯一字段：";
            // 
            // file_key
            // 
            this.file_key.Location = new System.Drawing.Point(412, 132);
            this.file_key.Name = "file_key";
            this.file_key.Size = new System.Drawing.Size(148, 21);
            this.file_key.TabIndex = 11;
            // 
            // OLEDB2ORACLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 349);
            this.Controls.Add(this.file_key);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TO_table);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FROM_table);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.txt_field);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectFILE);
            this.Name = "OLEDB2ORACLE";
            this.Text = "OLEDB2ORACLE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectFILE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.TextBox txt_field;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.TextBox FROM_table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TO_table;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox file_key;
    }
}

