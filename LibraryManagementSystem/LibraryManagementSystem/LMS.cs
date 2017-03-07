﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LMS : Form
    {
        public LMS()
        {
            InitializeComponent();
        }

        private void LMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void formToolStripMenuItem_Click_Initial(Form formObj)
        {
            formObj.MdiParent = this;
            formObj.StartPosition = FormStartPosition.CenterScreen;
            formObj.Show();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formToolStripMenuItem_Click_Initial(new Role());
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formToolStripMenuItem_Click_Initial(new Profile_Master());
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formToolStripMenuItem_Click_Initial(new Member_Master());
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formToolStripMenuItem_Click_Initial(new Plan());
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formToolStripMenuItem_Click_Initial(new Rack());
        }
    }
}
