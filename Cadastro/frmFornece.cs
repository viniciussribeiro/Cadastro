using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmFornece : Form
    {
        private void HabilitaEdicao()
        {
            cd_fornecedorTextBox.Enabled = true;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_cnpjMaskedTextBox.Enabled = true;
            cd_ieMaskedTextBox.Enabled = true;
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
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_cnpjMaskedTextBox.Enabled = false;
            cd_ieMaskedTextBox.Enabled = false;
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
        public frmFornece()
        {
            InitializeComponent();
        }

        private void tb_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmFornece_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.cadastroDataSet.tb_fornecedor);
            DesabilitaEdicao();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MovePrevious();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void btnAlte_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void btnExclu_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.RemoveCurrent();
            tb_fornecedorTableAdapter.Update(cadastroDataSet.tb_fornecedor);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_fornecedorBindingSource.EndEdit();
            tb_fornecedorTableAdapter.Update(cadastroDataSet.tb_fornecedor);
            DesabilitaEdicao();
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.CancelEdit();
            DesabilitaEdicao();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImpri_Click(object sender, EventArgs e)
        {

        }

        private void cd_ieMaskedTextBox_Leave(object sender, EventArgs e)
        {
            double dig1=0, dig2=0;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1))*2;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1))*3;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1))*4;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1))*5;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1))*6;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1))*7;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1))*8;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1))*9;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1))*2;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1))*3;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1))*4;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1))*5;
            dig1 = dig1 % 11; 
            dig1 = 11 - dig1;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(16, 1)) * 2;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 3;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 4;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 5;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 6;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 7;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 8;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 9;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 2;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 3;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 4;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 5;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 6;
            dig2 = dig2 % 11;
            dig2 = 11 - dig2;
            if (cd_cnpjMaskedTextBox.Text.Substring(16,1)!=dig1.ToString()|| cd_cnpjMaskedTextBox.Text.Substring(17,1)!=dig2.ToString()){
                MessageBox.Show("CNPJ inválido!!!");
                cd_cnpjMaskedTextBox.Focus();
            }
     }

       public class Cep
        {
            public static bool Validar(string cep)
            {
                //12345-123 12345678
                var regExp = new Regex(@"^\d{5}-\d{3}");
               // var regExp = new Regex(@"^\d{8}");
                return regExp.IsMatch(cep);
            }
        }

        private void cd_cepMaskedTextBox_Leave(object sender, EventArgs e)
        {
            var cepValido = Cep.Validar(cd_cepMaskedTextBox.Text);
            if (cepValido)
            {
                labelValida.Text = "CEP válido!";
            }
            else
                labelValida.Text = "CEP inválido!";
        }
    }
}
