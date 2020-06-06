using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto;

namespace SpotfliX
{
    public partial class FormMain : Form
    {
        public User ActiveUser;
        public FormMain()
        {
            
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
