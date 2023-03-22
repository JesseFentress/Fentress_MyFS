namespace Fentress_MyFS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lstSectors = new System.Windows.Forms.ListBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.chckHidden = new System.Windows.Forms.CheckBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.chckReadOnly = new System.Windows.Forms.CheckBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblSectorSize = new System.Windows.Forms.Label();
            this.txtSectorSize = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.txtStatusLine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(18, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(17, 95);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(60, 15);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "File Name";
            // 
            // lstSectors
            // 
            this.lstSectors.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSectors.FormattingEnabled = true;
            this.lstSectors.ItemHeight = 16;
            this.lstSectors.Items.AddRange(new object[] {
            "1 >",
            "2 >",
            "3 >",
            "4 >",
            "5 >",
            "6 >",
            "7 >",
            "8 >",
            "9 >",
            "0 >",
            "1 >",
            "2 >",
            "3 >",
            "4 >",
            "5 >",
            "6 >",
            "7 >",
            "8 >",
            "9 >",
            "0 >"});
            this.lstSectors.Location = new System.Drawing.Point(587, 12);
            this.lstSectors.Name = "lstSectors";
            this.lstSectors.Size = new System.Drawing.Size(201, 420);
            this.lstSectors.TabIndex = 2;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(17, 117);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 23);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // chckHidden
            // 
            this.chckHidden.AutoSize = true;
            this.chckHidden.Location = new System.Drawing.Point(277, 106);
            this.chckHidden.Name = "chckHidden";
            this.chckHidden.Size = new System.Drawing.Size(65, 19);
            this.chckHidden.TabIndex = 4;
            this.chckHidden.Text = "Hidden";
            this.chckHidden.UseVisualStyleBackColor = true;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(146, 117);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(100, 23);
            this.txtFileSize.TabIndex = 5;
            this.txtFileSize.TextChanged += new System.EventHandler(this.txtFileSize_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(18, 262);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // chckReadOnly
            // 
            this.chckReadOnly.AutoSize = true;
            this.chckReadOnly.Location = new System.Drawing.Point(277, 131);
            this.chckReadOnly.Name = "chckReadOnly";
            this.chckReadOnly.Size = new System.Drawing.Size(80, 19);
            this.chckReadOnly.TabIndex = 8;
            this.chckReadOnly.Text = "Read Only";
            this.chckReadOnly.UseVisualStyleBackColor = true;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(146, 95);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(48, 15);
            this.lblFileSize.TabIndex = 9;
            this.lblFileSize.Text = "File Size";
            // 
            // lblSectorSize
            // 
            this.lblSectorSize.AutoSize = true;
            this.lblSectorSize.Location = new System.Drawing.Point(16, 34);
            this.lblSectorSize.Name = "lblSectorSize";
            this.lblSectorSize.Size = new System.Drawing.Size(63, 15);
            this.lblSectorSize.TabIndex = 10;
            this.lblSectorSize.Text = "Sector Size";
            this.lblSectorSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSectorSize
            // 
            this.txtSectorSize.Location = new System.Drawing.Point(85, 31);
            this.txtSectorSize.Name = "txtSectorSize";
            this.txtSectorSize.Size = new System.Drawing.Size(50, 23);
            this.txtSectorSize.TabIndex = 11;
            this.txtSectorSize.Text = "500";
            this.txtSectorSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(123, 266);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 15);
            this.labelCount.TabIndex = 12;
            this.labelCount.Text = "0";
            this.labelCount.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtStatusLine
            // 
            this.txtStatusLine.Location = new System.Drawing.Point(18, 413);
            this.txtStatusLine.Name = "txtStatusLine";
            this.txtStatusLine.Size = new System.Drawing.Size(538, 23);
            this.txtStatusLine.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStatusLine);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.txtSectorSize);
            this.Controls.Add(this.lblSectorSize);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.chckReadOnly);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFileSize);
            this.Controls.Add(this.chckHidden);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lstSectors);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Label lblFileName;
        private ListBox lstSectors;
        private TextBox txtFileName;
        private CheckBox chckHidden;
        private TextBox txtFileSize;
        private Button btnExit;
        private Button btnRemove;
        private CheckBox chckReadOnly;
        private Label lblFileSize;
        private Label lblSectorSize;
        private TextBox txtSectorSize;
        private Label labelCount;
        private TextBox txtStatusLine;
    }
}