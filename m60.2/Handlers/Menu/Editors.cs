using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using m60._2.Classes;
using m60._2.Forms;

namespace m60._2
{
    public partial class Form1 : Form
    {
        private void menu_lauchagfileeditor_Click(object sender, EventArgs e)
        {
            FormChipEditor frm_chipeditor = new FormChipEditor(Project.ProjectPath);
            frm_chipeditor.Show();
        }

        private void menu_launchsamplelisteditor_Click(object sender, EventArgs e)
        {
            FormSampleEditor frm_sampleeditor = new FormSampleEditor();
            frm_sampleeditor.Show();
        }
    }
}