using Cadastro.Properties;
using System;
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
    public partial class frmUsuario : Form
    {
        private void HabilitaEdicao()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            btnAnterior.Enabled = false;
            btnPro.Enabled = false;
            btnNovo.Enabled = false;
            btnAlte.Enabled = false;
            btnExclu.Enabled = false;
            btnSalvar.Enabled = true;
            btnCanc.Enabled = true;
            btnPesqui.Enabled = false;
            btnImpri.Enabled = false;
            btnSair.Enabled = false;
        }
        private void DesabilitaEdicao()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            btnAnterior.Enabled = true;
            btnPro.Enabled = true;
            btnNovo.Enabled = true;
            btnAlte.Enabled = true;
            btnExclu.Enabled = true;
            btnSalvar.Enabled = false;
            btnCanc.Enabled = false;
            btnPesqui.Enabled = true    ;
            btnImpri.Enabled = true;
            btnSair.Enabled = true;
        }
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet1.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.cadastroDataSet1.tb_usuario);
            DesabilitaEdicao();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            HabilitaEdicao();
        }

        private void btnAlte_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void btnExclu_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            tb_usuarioTableAdapter.Update(cadastroDataSet1.tb_usuario);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
           bindingSource1.EndEdit();
            tb_usuarioTableAdapter.Update(cadastroDataSet1.tb_usuario);
            DesabilitaEdicao();
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            bindingSource1.CancelEdit();
            DesabilitaEdicao();
        }

        private void btnImpri_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPesqui_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisuario fm = new frmPesquisuario();
            fm.ShowDialog();
            cod = fm.getCodigo();
            if(cod>0)
            {
                reg = bindingSource1.Find("cd_usuario", cod);
                bindingSource1.Position = reg;

            }
        }
    }
}
