using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt_Georgi_Dimitrov_1901682009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnterInfo_Click(object sender, EventArgs e)
        {
            EnterInformation info = new EnterInformation();
            info.ShowDialog();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Georgi Dimitrov Dimitrov",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
