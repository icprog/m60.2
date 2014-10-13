namespace m60._2.Forms
{
    partial class FormChipEditorSettings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_basic = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_chiptype = new System.Windows.Forms.ComboBox();
            this.tp_advanced = new System.Windows.Forms.TabPage();
            this.rbtn_de = new System.Windows.Forms.RadioButton();
            this.rbtn_uk = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_numspotsmean = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_columns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_numspots = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp_basic.SuspendLayout();
            this.tp_advanced.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_basic);
            this.tabControl1.Controls.Add(this.tp_advanced);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 211);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_basic
            // 
            this.tp_basic.Controls.Add(this.label5);
            this.tp_basic.Controls.Add(this.cmb_chiptype);
            this.tp_basic.Location = new System.Drawing.Point(4, 22);
            this.tp_basic.Name = "tp_basic";
            this.tp_basic.Padding = new System.Windows.Forms.Padding(3);
            this.tp_basic.Size = new System.Drawing.Size(446, 185);
            this.tp_basic.TabIndex = 0;
            this.tp_basic.Text = "Basic";
            this.tp_basic.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Choose Chip Type";
            // 
            // cmb_chiptype
            // 
            this.cmb_chiptype.FormattingEnabled = true;
            this.cmb_chiptype.Items.AddRange(new object[] {
            "IR (UK)",
            "RA (UK)",
            "RA (DE)",
            "SLE (DE)"});
            this.cmb_chiptype.Location = new System.Drawing.Point(161, 89);
            this.cmb_chiptype.Name = "cmb_chiptype";
            this.cmb_chiptype.Size = new System.Drawing.Size(245, 21);
            this.cmb_chiptype.TabIndex = 0;
            // 
            // tp_advanced
            // 
            this.tp_advanced.Controls.Add(this.rbtn_de);
            this.tp_advanced.Controls.Add(this.rbtn_uk);
            this.tp_advanced.Controls.Add(this.label4);
            this.tp_advanced.Controls.Add(this.tb_numspotsmean);
            this.tp_advanced.Controls.Add(this.label3);
            this.tp_advanced.Controls.Add(this.tb_columns);
            this.tp_advanced.Controls.Add(this.label2);
            this.tp_advanced.Controls.Add(this.tb_numspots);
            this.tp_advanced.Controls.Add(this.label1);
            this.tp_advanced.Location = new System.Drawing.Point(4, 22);
            this.tp_advanced.Name = "tp_advanced";
            this.tp_advanced.Padding = new System.Windows.Forms.Padding(3);
            this.tp_advanced.Size = new System.Drawing.Size(446, 185);
            this.tp_advanced.TabIndex = 1;
            this.tp_advanced.Text = "Advanced";
            this.tp_advanced.UseVisualStyleBackColor = true;
            // 
            // rbtn_de
            // 
            this.rbtn_de.AutoSize = true;
            this.rbtn_de.Location = new System.Drawing.Point(366, 118);
            this.rbtn_de.Name = "rbtn_de";
            this.rbtn_de.Size = new System.Drawing.Size(40, 17);
            this.rbtn_de.TabIndex = 12;
            this.rbtn_de.Text = "DE";
            this.rbtn_de.UseVisualStyleBackColor = true;
            // 
            // rbtn_uk
            // 
            this.rbtn_uk.AutoSize = true;
            this.rbtn_uk.Checked = true;
            this.rbtn_uk.Location = new System.Drawing.Point(306, 118);
            this.rbtn_uk.Name = "rbtn_uk";
            this.rbtn_uk.Size = new System.Drawing.Size(40, 17);
            this.rbtn_uk.TabIndex = 13;
            this.rbtn_uk.TabStop = true;
            this.rbtn_uk.Text = "UK";
            this.rbtn_uk.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calculate Mean by";
            // 
            // tb_numspotsmean
            // 
            this.tb_numspotsmean.Location = new System.Drawing.Point(306, 92);
            this.tb_numspotsmean.Name = "tb_numspotsmean";
            this.tb_numspotsmean.Size = new System.Drawing.Size(100, 20);
            this.tb_numspotsmean.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of Spots Calculating Mean";
            // 
            // tb_columns
            // 
            this.tb_columns.Location = new System.Drawing.Point(306, 66);
            this.tb_columns.Name = "tb_columns";
            this.tb_columns.Size = new System.Drawing.Size(100, 20);
            this.tb_columns.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Columns";
            // 
            // tb_numspots
            // 
            this.tb_numspots.Location = new System.Drawing.Point(306, 40);
            this.tb_numspots.Name = "tb_numspots";
            this.tb_numspots.Size = new System.Drawing.Size(100, 20);
            this.tb_numspots.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of Spots";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 40);
            this.panel1.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(335, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(237, 5);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 14;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FormChipEditorSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 253);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormChipEditorSettings";
            this.Text = "Chip Editor Settings";
            this.Load += new System.EventHandler(this.FormChipEditorSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_basic.ResumeLayout(false);
            this.tp_basic.PerformLayout();
            this.tp_advanced.ResumeLayout(false);
            this.tp_advanced.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_basic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_chiptype;
        private System.Windows.Forms.TabPage tp_advanced;
        private System.Windows.Forms.RadioButton rbtn_de;
        private System.Windows.Forms.RadioButton rbtn_uk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_numspotsmean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_columns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_numspots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;

    }
}