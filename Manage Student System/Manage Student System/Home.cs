using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manage_Student_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bureautique_Click(object sender, EventArgs e)
        {
            this.Hide();
            bureautique b = new bureautique();
            b.Show();
        }
    }
}
