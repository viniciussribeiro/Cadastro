﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class fnmPrincipal : Form
    {
        public fnmPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fu = new frmCliente();
            fu.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornece fu = new frmFornece();
            fu.ShowDialog();
        }
    }
}
