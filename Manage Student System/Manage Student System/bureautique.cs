using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manage_Student_System
{
    public partial class bureautique : Form
    {
        public bureautique()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ft_Click(object sender, EventArgs e)
        {
            this.Hide();
            bureautique_3months b = new bureautique_3months();
            b.Show();
        }
    }
}
