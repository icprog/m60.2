namespace m60._2.Forms
{
    partial class FormBasicOneChipSettings
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_plot = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cmb_selrec = new System.Windows.Forms.ComboBox();
            this.cmb_selchip = new System.Windows.Forms.ComboBox();
            this.cmb_selAg = new System.Windows.Forms.ComboBox();
            this.cmb_selAgnorm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Chip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Antigene";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Antigene to use as Norm";
            // 
            // btn_plot
            // 
            this.btn_plot.Location = new System.Drawing.Point(274, 264);
            this.btn_plot.Name = "btn_plot";
            this.btn_plot.Size = new System.Drawing.Size(75, 23);
            this.btn_plot.TabIndex = 4;
            this.btn_plot.Text = "Plot";
            this.btn_plot.UseVisualStyleBackColor = true;
            this.btn_plot.Click += new System.EventHandler(this.btn_plot_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(387, 264);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cmb_selrec
            // 
            this.cmb_selrec.FormattingEnabled = true;
            this.cmb_selrec.Location = new System.Drawing.Point(274, 43);
            this.cmb_selrec.Name = "cmb_selrec";
            this.cmb_selrec.Size = new System.Drawing.Size(121, 21);
            this.cmb_selrec.TabIndex = 6;
            this.cmb_selrec.SelectionChangeCommitted += new System.EventHandler(this.cmb_selrec_SelectionChangeCommitted);
            // 
            // cmb_selchip
            // 
            this.cmb_selchip.FormattingEnabled = true;
            this.cmb_selchip.Location = new System.Drawing.Point(274, 93);
            this.cmb_selchip.Name = "cmb_selchip";
            this.cmb_selchip.Size = new System.Drawing.Size(121, 21);
            this.cmb_selchip.TabIndex = 7;
            // 
            // cmb_selAg
            // 
            this.cmb_selAg.FormattingEnabled = true;
            this.cmb_selAg.Location = new System.Drawing.Point(274, 143);
            this.cmb_selAg.Name = "cmb_selAg";
            this.cmb_selAg.Size = new System.Drawing.Size(121, 21);
            this.cmb_selAg.TabIndex = 8;
            // 
            // cmb_selAgnorm
            // 
            this.cmb_selAgnorm.FormattingEnabled = true;
            this.cmb_selAgnorm.Location = new System.Drawing.Point(274, 193);
            this.cmb_selAgnorm.Name = "cmb_selAgnorm";
            this.cmb_selAgnorm.Size = new System.Drawing.Size(121, 21);
            this.cmb_selAgnorm.TabIndex = 9;
            // 
            // FormBasicOneChipSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 323);
            this.Controls.Add(this.cmb_selAgnorm);
            this.Controls.Add(this.cmb_selAg);
            this.Controls.Add(this.cmb_selchip);
            this.Controls.Add(this.cmb_selrec);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_plot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBasicOneChipSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Analysis";
            this.Load += new System.EventHandler(this.FormBasicOneChipSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_plot;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cmb_selrec;
        private System.Windows.Forms.ComboBox cmb_selchip;
        private System.Windows.Forms.ComboBox cmb_selAg;
        private System.Windows.Forms.ComboBox cmb_selAgnorm;
    }
}