namespace m60._2.Forms
{
    partial class FormNewProj
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
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dtp_newprojdate = new System.Windows.Forms.DateTimePicker();
            this.tb_newprojcomments = new System.Windows.Forms.TextBox();
            this.tb_newprojowner = new System.Windows.Forms.TextBox();
            this.tb_newprojname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(215, 276);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(378, 276);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dtp_newprojdate
            // 
            this.dtp_newprojdate.Location = new System.Drawing.Point(215, 123);
            this.dtp_newprojdate.Name = "dtp_newprojdate";
            this.dtp_newprojdate.Size = new System.Drawing.Size(238, 20);
            this.dtp_newprojdate.TabIndex = 9;
            this.dtp_newprojdate.Value = new System.DateTime(2014, 4, 24, 0, 0, 0, 0);
            // 
            // tb_newprojcomments
            // 
            this.tb_newprojcomments.Location = new System.Drawing.Point(215, 167);
            this.tb_newprojcomments.Multiline = true;
            this.tb_newprojcomments.Name = "tb_newprojcomments";
            this.tb_newprojcomments.Size = new System.Drawing.Size(238, 67);
            this.tb_newprojcomments.TabIndex = 8;
            // 
            // tb_newprojowner
            // 
            this.tb_newprojowner.Location = new System.Drawing.Point(215, 79);
            this.tb_newprojowner.Name = "tb_newprojowner";
            this.tb_newprojowner.Size = new System.Drawing.Size(238, 20);
            this.tb_newprojowner.TabIndex = 7;
            // 
            // tb_newprojname
            // 
            this.tb_newprojname.Location = new System.Drawing.Point(215, 35);
            this.tb_newprojname.Name = "tb_newprojname";
            this.tb_newprojname.Size = new System.Drawing.Size(238, 20);
            this.tb_newprojname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Project Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Project Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Creation Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Comments";
            // 
            // FormNewProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 326);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_newprojdate);
            this.Controls.Add(this.tb_newprojcomments);
            this.Controls.Add(this.tb_newprojowner);
            this.Controls.Add(this.tb_newprojname);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Name = "FormNewProj";
            this.Text = "Create New Project";
            this.Load += new System.EventHandler(this.FormNewProj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker dtp_newprojdate;
        private System.Windows.Forms.TextBox tb_newprojcomments;
        private System.Windows.Forms.TextBox tb_newprojowner;
        private System.Windows.Forms.TextBox tb_newprojname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}