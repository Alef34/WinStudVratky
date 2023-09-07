namespace WinStudVratky
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtMsgId = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtIdPrvej = new System.Windows.Forms.TextBox();
      this.dtpDatSplat = new System.Windows.Forms.DateTimePicker();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.lblCestaNaUlozenie = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.lblCestaSUdajmi = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.rbIBAN1 = new System.Windows.Forms.RadioButton();
      this.rbIBAN2 = new System.Windows.Forms.RadioButton();
      this.rbIBAN3 = new System.Windows.Forms.RadioButton();
      this.toolStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(944, 39);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(90, 36);
      this.toolStripButton1.Text = "Koniec";
      this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // toolStripButton2
      // 
      this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new System.Drawing.Size(123, 36);
      this.toolStripButton2.Text = "Otvor subor";
      // 
      // toolStripButton3
      // 
      this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
      this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton3.Name = "toolStripButton3";
      this.toolStripButton3.Size = new System.Drawing.Size(111, 36);
      this.toolStripButton3.Text = "Urob XML";
      this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtMsgId);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.groupBox1.Location = new System.Drawing.Point(12, 182);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(911, 63);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "MsgId";
      // 
      // txtMsgId
      // 
      this.txtMsgId.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtMsgId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtMsgId.Location = new System.Drawing.Point(3, 26);
      this.txtMsgId.Name = "txtMsgId";
      this.txtMsgId.Size = new System.Drawing.Size(905, 30);
      this.txtMsgId.TabIndex = 0;
      this.txtMsgId.Text = "DB-AP-V1-43-140710-001";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtIdPrvej);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.groupBox2.Location = new System.Drawing.Point(15, 265);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(905, 63);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Id prvej platby";
      // 
      // txtIdPrvej
      // 
      this.txtIdPrvej.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtIdPrvej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtIdPrvej.Location = new System.Drawing.Point(3, 26);
      this.txtIdPrvej.Name = "txtIdPrvej";
      this.txtIdPrvej.Size = new System.Drawing.Size(899, 30);
      this.txtIdPrvej.TabIndex = 0;
      this.txtIdPrvej.Text = "1";
      // 
      // dtpDatSplat
      // 
      this.dtpDatSplat.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtpDatSplat.Location = new System.Drawing.Point(3, 26);
      this.dtpDatSplat.Name = "dtpDatSplat";
      this.dtpDatSplat.Size = new System.Drawing.Size(354, 30);
      this.dtpDatSplat.TabIndex = 3;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.dtpDatSplat);
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.groupBox3.Location = new System.Drawing.Point(15, 334);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(360, 84);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Datum splatnosti";
      // 
      // groupBox4
      // 
      this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox4.Controls.Add(this.lblCestaNaUlozenie);
      this.groupBox4.Controls.Add(this.button3);
      this.groupBox4.Controls.Add(this.button1);
      this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.groupBox4.Location = new System.Drawing.Point(18, 520);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(902, 77);
      this.groupBox4.TabIndex = 5;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Výstupný súbor (XML)";
      // 
      // lblCestaNaUlozenie
      // 
      this.lblCestaNaUlozenie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblCestaNaUlozenie.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblCestaNaUlozenie.Location = new System.Drawing.Point(89, 26);
      this.lblCestaNaUlozenie.Name = "lblCestaNaUlozenie";
      this.lblCestaNaUlozenie.Size = new System.Drawing.Size(735, 48);
      this.lblCestaNaUlozenie.TabIndex = 1;
      this.lblCestaNaUlozenie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // button3
      // 
      this.button3.Dock = System.Windows.Forms.DockStyle.Right;
      this.button3.Location = new System.Drawing.Point(824, 26);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 48);
      this.button3.TabIndex = 2;
      this.button3.Text = "..";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Left;
      this.button1.Location = new System.Drawing.Point(3, 26);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(86, 48);
      this.button1.TabIndex = 0;
      this.button1.Text = "...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox5
      // 
      this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox5.Controls.Add(this.lblCestaSUdajmi);
      this.groupBox5.Controls.Add(this.button2);
      this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.groupBox5.Location = new System.Drawing.Point(12, 77);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(914, 77);
      this.groupBox5.TabIndex = 6;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Vstupný súbor (Excel)";
      // 
      // lblCestaSUdajmi
      // 
      this.lblCestaSUdajmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblCestaSUdajmi.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblCestaSUdajmi.Location = new System.Drawing.Point(89, 26);
      this.lblCestaSUdajmi.Name = "lblCestaSUdajmi";
      this.lblCestaSUdajmi.Size = new System.Drawing.Size(822, 48);
      this.lblCestaSUdajmi.TabIndex = 1;
      this.lblCestaSUdajmi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // button2
      // 
      this.button2.Dock = System.Windows.Forms.DockStyle.Left;
      this.button2.Location = new System.Drawing.Point(3, 26);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(86, 48);
      this.button2.TabIndex = 0;
      this.button2.Text = "...";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.rbIBAN3);
      this.groupBox6.Controls.Add(this.rbIBAN2);
      this.groupBox6.Controls.Add(this.rbIBAN1);
      this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.groupBox6.Location = new System.Drawing.Point(392, 334);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(525, 189);
      this.groupBox6.TabIndex = 7;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "MsgId";
      // 
      // rbIBAN1
      // 
      this.rbIBAN1.AutoSize = true;
      this.rbIBAN1.Checked = true;
      this.rbIBAN1.Location = new System.Drawing.Point(40, 45);
      this.rbIBAN1.Name = "rbIBAN1";
      this.rbIBAN1.Size = new System.Drawing.Size(357, 29);
      this.rbIBAN1.TabIndex = 0;
      this.rbIBAN1.TabStop = true;
      this.rbIBAN1.Tag = "SK2081800000007000487199";
      this.rbIBAN1.Text = "SK20 8180 0000 0070 0048 7199";
      this.rbIBAN1.UseVisualStyleBackColor = true;
      // 
      // rbIBAN2
      // 
      this.rbIBAN2.AutoSize = true;
      this.rbIBAN2.Location = new System.Drawing.Point(40, 85);
      this.rbIBAN2.Name = "rbIBAN2";
      this.rbIBAN2.Size = new System.Drawing.Size(357, 29);
      this.rbIBAN2.TabIndex = 1;
      this.rbIBAN2.Tag = "SK4481800000007000276471";
      this.rbIBAN2.Text = "SK44 8180 0000 0070 0027 6471";
      this.rbIBAN2.UseVisualStyleBackColor = true;
      // 
      // rbIBAN3
      // 
      this.rbIBAN3.AutoSize = true;
      this.rbIBAN3.Location = new System.Drawing.Point(40, 127);
      this.rbIBAN3.Name = "rbIBAN3";
      this.rbIBAN3.Size = new System.Drawing.Size(357, 29);
      this.rbIBAN3.TabIndex = 2;
      this.rbIBAN3.Tag = "SK2981800000007000073041";
      this.rbIBAN3.Text = "SK29 8180 0000 0070 0007 3041";
      this.rbIBAN3.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(944, 611);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.toolStrip1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMsgId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdPrvej;
        private System.Windows.Forms.DateTimePicker dtpDatSplat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblCestaNaUlozenie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblCestaSUdajmi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbIBAN3;
        private System.Windows.Forms.RadioButton rbIBAN2;
        private System.Windows.Forms.RadioButton rbIBAN1;
    }
}

