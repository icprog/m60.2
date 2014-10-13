namespace m60._2.Forms
{
    partial class FormRecSettings
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_DE = new System.Windows.Forms.RadioButton();
            this.rbtn_UK = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_recdatetime = new System.Windows.Forms.TextBox();
            this.tb_recsuffix = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn_invno = new System.Windows.Forms.RadioButton();
            this.rbtn_invyes = new System.Windows.Forms.RadioButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.cb_copy = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(464, 272);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(554, 272);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_filename
            // 
            this.tb_filename.Location = new System.Drawing.Point(203, 124);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.Size = new System.Drawing.Size(426, 20);
            this.tb_filename.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Antigene List File";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(554, 150);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 4;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mean Calculation (global)";
            // 
            // rbtn_DE
            // 
            this.rbtn_DE.AutoSize = true;
            this.rbtn_DE.Location = new System.Drawing.Point(64, 8);
            this.rbtn_DE.Name = "rbtn_DE";
            this.rbtn_DE.Size = new System.Drawing.Size(40, 17);
            this.rbtn_DE.TabIndex = 1;
            this.rbtn_DE.Text = "DE";
            this.rbtn_DE.UseVisualStyleBackColor = true;
            // 
            // rbtn_UK
            // 
            this.rbtn_UK.AutoSize = true;
            this.rbtn_UK.Checked = true;
            this.rbtn_UK.Location = new System.Drawing.Point(3, 8);
            this.rbtn_UK.Name = "rbtn_UK";
            this.rbtn_UK.Size = new System.Drawing.Size(40, 17);
            this.rbtn_UK.TabIndex = 0;
            this.rbtn_UK.TabStop = true;
            this.rbtn_UK.Text = "UK";
            this.rbtn_UK.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Use Invalid Spots (GLOBAL)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Record Name";
            // 
            // tb_recdatetime
            // 
            this.tb_recdatetime.Location = new System.Drawing.Point(203, 76);
            this.tb_recdatetime.Name = "tb_recdatetime";
            this.tb_recdatetime.ReadOnly = true;
            this.tb_recdatetime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_recdatetime.Size = new System.Drawing.Size(60, 20);
            this.tb_recdatetime.TabIndex = 11;
            this.tb_recdatetime.Text = "20140619";
            this.tb_recdatetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_recsuffix
            // 
            this.tb_recsuffix.Location = new System.Drawing.Point(269, 76);
            this.tb_recsuffix.Name = "tb_recsuffix";
            this.tb_recsuffix.Size = new System.Drawing.Size(360, 20);
            this.tb_recsuffix.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_DE);
            this.panel1.Controls.Add(this.rbtn_UK);
            this.panel1.Location = new System.Drawing.Point(209, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 35);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtn_invno);
            this.panel2.Controls.Add(this.rbtn_invyes);
            this.panel2.Location = new System.Drawing.Point(209, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 39);
            this.panel2.TabIndex = 15;
            // 
            // rbtn_invno
            // 
            this.rbtn_invno.AutoSize = true;
            this.rbtn_invno.Location = new System.Drawing.Point(64, 12);
            this.rbtn_invno.Name = "rbtn_invno";
            this.rbtn_invno.Size = new System.Drawing.Size(39, 17);
            this.rbtn_invno.TabIndex = 1;
            this.rbtn_invno.Text = "No";
            this.rbtn_invno.UseVisualStyleBackColor = true;
            // 
            // rbtn_invyes
            // 
            this.rbtn_invyes.AutoSize = true;
            this.rbtn_invyes.Checked = true;
            this.rbtn_invyes.Location = new System.Drawing.Point(3, 12);
            this.rbtn_invyes.Name = "rbtn_invyes";
            this.rbtn_invyes.Size = new System.Drawing.Size(43, 17);
            this.rbtn_invyes.TabIndex = 0;
            this.rbtn_invyes.TabStop = true;
            this.rbtn_invyes.Text = "Yes";
            this.rbtn_invyes.UseVisualStyleBackColor = true;
            // 
            // cb_copy
            // 
            this.cb_copy.AutoSize = true;
            this.cb_copy.Checked = true;
            this.cb_copy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_copy.Location = new System.Drawing.Point(203, 155);
            this.cb_copy.Name = "cb_copy";
            this.cb_copy.Size = new System.Drawing.Size(149, 17);
            this.cb_copy.TabIndex = 16;
            this.cb_copy.Text = "Copy File to Project Folder";
            this.cb_copy.UseVisualStyleBackColor = true;
            // 
            // FormRecSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 328);
            this.Controls.Add(this.cb_copy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_recsuffix);
            this.Controls.Add(this.tb_recdatetime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_filename);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Name = "FormRecSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record Settings";
            this.Load += new System.EventHandler(this.FormRecSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_DE;
        private System.Windows.Forms.RadioButton rbtn_UK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_recdatetime;
        private System.Windows.Forms.TextBox tb_recsuffix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtn_invno;
        private System.Windows.Forms.RadioButton rbtn_invyes;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.CheckBox cb_copy;
    }
}