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
    public partial class frmCliente : Form
    {
        private void HabilitaEdicao()
        {
            cd_clienteTextBox.Enabled = true;
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
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
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnPro.Enabled = true;
            btnNovo.Enabled = true;
            btnAlte.Enabled = true;
            btnExclu.Enabled = true;
            btnSalvar.Enabled = false;
            btnCanc.Enabled = false;
            btnPesqui.Enabled = true;
            btnImpri.Enabled = true;
            btnSair.Enabled = true;
        }
        public frmCliente()
        {
            InitializeComponent();
        }

        private void tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.cadastroDataSet.tb_cliente);
            DesabilitaEdicao();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MovePrevious();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MoveNext();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void btnAlte_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void btnExclu_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.RemoveCurrent();
            tb_clienteTableAdapter.Update(cadastroDataSet.tb_cliente);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Validate();
            tb_clienteBindingSource.EndEdit();
            tb_clienteTableAdapter.Update(cadastroDataSet.tb_cliente);
            DesabilitaEdicao();
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.CancelEdit();
            DesabilitaEdicao();
        }
    }
}
