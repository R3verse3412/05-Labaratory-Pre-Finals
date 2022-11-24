using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_Text_File
{
    public partial class FrmFileName : Form
    {
        public FrmFileName()
        {
            InitializeComponent();
        }

        public static string SetFilename;
        private void btnOkay_Click(object sender, EventArgs e)
        {
        SetFilename = txtFileName.Text;
        Close();
        }
    }
}
