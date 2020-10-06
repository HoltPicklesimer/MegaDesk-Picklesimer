namespace MegaDesk_Picklesimer
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nWidth = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbShip = new System.Windows.Forms.ComboBox();
            this.nDepth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nDrawers = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDrawers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(416, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // nWidth
            // 
            this.nWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nWidth.Location = new System.Drawing.Point(165, 24);
            this.nWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.nWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nWidth.Name = "nWidth";
            this.nWidth.Size = new System.Drawing.Size(120, 26);
            this.nWidth.TabIndex = 2;
            this.nWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(244, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Get Quote";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(227, 23);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 28);
            this.cmbMaterial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surface Material:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shipping Option:";
            // 
            // cmbShip
            // 
            this.cmbShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbShip.FormattingEnabled = true;
            this.cmbShip.Location = new System.Drawing.Point(188, 21);
            this.cmbShip.Name = "cmbShip";
            this.cmbShip.Size = new System.Drawing.Size(160, 28);
            this.cmbShip.TabIndex = 6;
            // 
            // nDepth
            // 
            this.nDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nDepth.Location = new System.Drawing.Point(165, 56);
            this.nDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nDepth.Name = "nDepth";
            this.nDepth.Size = new System.Drawing.Size(120, 26);
            this.nDepth.TabIndex = 9;
            this.nDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(75, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Depth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Customer Name:";
            // 
            // nDrawers
            // 
            this.nDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nDrawers.Location = new System.Drawing.Point(228, 56);
            this.nDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nDrawers.Name = "nDrawers";
            this.nDrawers.Size = new System.Drawing.Size(120, 26);
            this.nDrawers.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(13, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of Drawers:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(197, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 27);
            this.txtName.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.Location = new System.Drawing.Point(197, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(164, 25);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Jannuary 1, 2020";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quote Date: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nDepth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 106);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMaterial);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nDrawers);
            this.groupBox2.Location = new System.Drawing.Point(416, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 106);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Specifications";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbShip);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(416, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 71);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shipping";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDrawers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown nWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.NumericUpDown nDepth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbShip;
        private System.Windows.Forms.NumericUpDown nDrawers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}