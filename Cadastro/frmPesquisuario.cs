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
    public partial class frmPesquisuario : Form
    {
        private int codigo;

        public frmPesquisuario()
        {
            InitializeComponent();
        }
         
       public int getCodigo()
        {
            return codigo;
        }
        private void frmPesquisuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.cadastroDataSet.tb_usuario);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesqui_Click(object sender, EventArgs e)
        {
            if(txtNome.Text =="")
            {
                // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
                this.tb_usuarioTableAdapter.Fill(this.cadastroDataSet.tb_usuario);
            }
            else
            {
                this.tb_usuarioTableAdapter.FillByNome(this.cadastroDataSet.tb_usuario, "%"+txtNome.Text+"%");
            }
        }

        private void tb_usuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_usuarioDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
