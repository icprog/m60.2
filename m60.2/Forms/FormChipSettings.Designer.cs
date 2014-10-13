namespace m60._2.Forms
{
    partial class FormChipSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_browsexml = new System.Windows.Forms.Button();
            this.tb_xmlfilename = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.tb_samplefilename = new System.Windows.Forms.TextBox();
            this.rbtn_invno = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn_invyes = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_chipname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_chipid = new System.Windows.Forms.TextBox();
            this.cb_copyxml = new System.Windows.Forms.CheckBox();
            this.cb_copy = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chip XML File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sample List File";
            // 
            // btn_browsexml
            // 
            this.btn_browsexml.Location = new System.Drawing.Point(540, 159);
            this.btn_browsexml.Name = "btn_browsexml";
            this.btn_browsexml.Size = new System.Drawing.Size(75, 23);
            this.btn_browsexml.TabIndex = 15;
            this.btn_browsexml.Text = "Browse";
            this.btn_browsexml.UseVisualStyleBackColor = true;
            this.btn_browsexml.Click += new System.EventHandler(this.btn_browsexml_Click);
            // 
            // tb_xmlfilename
            // 
            this.tb_xmlfilename.Location = new System.Drawing.Point(189, 133);
            this.tb_xmlfilename.Name = "tb_xmlfilename";
            this.tb_xmlfilename.Size = new System.Drawing.Size(426, 20);
            this.tb_xmlfilename.TabIndex = 14;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(540, 227);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 19;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tb_samplefilename
            // 
            this.tb_samplefilename.Location = new System.Drawing.Point(189, 201);
            this.tb_samplefilename.Name = "tb_samplefilename";
            this.tb_samplefilename.Size = new System.Drawing.Size(426, 20);
            this.tb_samplefilename.TabIndex = 18;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtn_invno);
            this.panel2.Controls.Add(this.rbtn_invyes);
            this.panel2.Location = new System.Drawing.Point(189, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 39);
            this.panel2.TabIndex = 24;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Use Invalid Spots (LOCAL)";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(540, 337);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(451, 337);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 25;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chip Name";
            // 
            // tb_chipname
            // 
            this.tb_chipname.Location = new System.Drawing.Point(189, 38);
            this.tb_chipname.Name = "tb_chipname";
            this.tb_chipname.Size = new System.Drawing.Size(426, 20);
            this.tb_chipname.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Chip ID (optional)";
            // 
            // tb_chipid
            // 
            this.tb_chipid.Location = new System.Drawing.Point(189, 85);
            this.tb_chipid.Name = "tb_chipid";
            this.tb_chipid.Size = new System.Drawing.Size(426, 20);
            this.tb_chipid.TabIndex = 28;
            // 
            // cb_copyxml
            // 
            this.cb_copyxml.AutoSize = true;
            this.cb_copyxml.Checked = true;
            this.cb_copyxml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_copyxml.Location = new System.Drawing.Point(189, 164);
            this.cb_copyxml.Name = "cb_copyxml";
            this.cb_copyxml.Size = new System.Drawing.Size(149, 17);
            this.cb_copyxml.TabIndex = 29;
            this.cb_copyxml.Text = "Copy File to Project Folder";
            this.cb_copyxml.UseVisualStyleBackColor = true;
            // 
            // cb_copy
            // 
            this.cb_copy.AutoSize = true;
            this.cb_copy.Checked = true;
            this.cb_copy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_copy.Location = new System.Drawing.Point(189, 231);
            this.cb_copy.Name = "cb_copy";
            this.cb_copy.Size = new System.Drawing.Size(149, 17);
            this.cb_copy.TabIndex = 29;
            this.cb_copy.Text = "Copy File to Project Folder";
            this.cb_copy.UseVisualStyleBackColor = true;
            // 
            // FormChipSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 378);
            this.Controls.Add(this.cb_copy);
            this.Controls.Add(this.cb_copyxml);
            this.Controls.Add(this.tb_chipid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_samplefilename);
            this.Controls.Add(this.btn_browsexml);
            this.Controls.Add(this.tb_chipname);
            this.Controls.Add(this.tb_xmlfilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormChipSettings";
            this.Text = "Chip Settings";
            this.Load += new System.EventHandler(this.FormChipSettings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_browsexml;
        private System.Windows.Forms.TextBox tb_xmlfilename;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox tb_samplefilename;
        private System.Windows.Forms.RadioButton rbtn_invno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtn_invyes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_chipname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_chipid;
        private System.Windows.Forms.CheckBox cb_copyxml;
        private System.Windows.Forms.CheckBox cb_copy;
    }
}