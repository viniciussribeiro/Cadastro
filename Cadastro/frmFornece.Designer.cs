namespace Cadastro
{
    partial class frmFornece
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label cd_ieLabel;
            this.cadastroDataSet = new Cadastro.CadastroDataSet();
            this.tb_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_fornecedorTableAdapter = new Cadastro.CadastroDataSetTableAdapters.tb_fornecedorTableAdapter();
            this.tableAdapterManager = new Cadastro.CadastroDataSetTableAdapters.TableAdapterManager();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlte = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExclu = new System.Windows.Forms.Button();
            this.btnPesqui = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnImpri = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.sg_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cd_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_ieMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelValida = new System.Windows.Forms.Label();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            cd_ieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_fornecedorLabel.Location = new System.Drawing.Point(220, 82);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(63, 20);
            cd_fornecedorLabel.TabIndex = 1;
            cd_fornecedorLabel.Text = "Código:";
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_fornecedorLabel.Location = new System.Drawing.Point(220, 110);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(55, 20);
            nm_fornecedorLabel.TabIndex = 3;
            nm_fornecedorLabel.Text = "Nome:";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_enderecoLabel.Location = new System.Drawing.Point(220, 138);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(82, 20);
            ds_enderecoLabel.TabIndex = 5;
            ds_enderecoLabel.Text = "Endereço:";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(220, 166);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(55, 20);
            nm_bairroLabel.TabIndex = 7;
            nm_bairroLabel.Text = "Bairro:";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(220, 194);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(63, 20);
            nm_cidadeLabel.TabIndex = 9;
            nm_cidadeLabel.Text = "Cidade:";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.Location = new System.Drawing.Point(219, 222);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(64, 20);
            sg_estadoLabel.TabIndex = 11;
            sg_estadoLabel.Text = "Estado:";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(219, 250);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(45, 20);
            cd_cepLabel.TabIndex = 13;
            cd_cepLabel.Text = "CEP:";
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cnpjLabel.Location = new System.Drawing.Point(219, 278);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(53, 20);
            cd_cnpjLabel.TabIndex = 15;
            cd_cnpjLabel.Text = "CNPJ:";
            // 
            // cd_ieLabel
            // 
            cd_ieLabel.AutoSize = true;
            cd_ieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_ieLabel.Location = new System.Drawing.Point(119, 306);
            cd_ieLabel.Name = "cd_ieLabel";
            cd_ieLabel.Size = new System.Drawing.Size(152, 20);
            cd_ieLabel.TabIndex = 17;
            cd_ieLabel.Text = "Inscrição do estado:";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_fornecedorBindingSource
            // 
            this.tb_fornecedorBindingSource.DataMember = "tb_fornecedor";
            this.tb_fornecedorBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tb_fornecedorTableAdapter
            // 
            this.tb_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = this.tb_fornecedorTableAdapter;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cadastro.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(495, 273);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(109, 30);
            this.btnNovo.TabIndex = 29;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlte
            // 
            this.btnAlte.AutoSize = true;
            this.btnAlte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlte.Location = new System.Drawing.Point(651, 268);
            this.btnAlte.Name = "btnAlte";
            this.btnAlte.Size = new System.Drawing.Size(109, 30);
            this.btnAlte.TabIndex = 28;
            this.btnAlte.Text = "Alterar";
            this.btnAlte.UseVisualStyleBackColor = true;
            this.btnAlte.Click += new System.EventHandler(this.btnAlte_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(651, 315);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 30);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExclu
            // 
            this.btnExclu.AutoSize = true;
            this.btnExclu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExclu.Location = new System.Drawing.Point(495, 315);
            this.btnExclu.Name = "btnExclu";
            this.btnExclu.Size = new System.Drawing.Size(109, 30);
            this.btnExclu.TabIndex = 26;
            this.btnExclu.Text = "Excluir";
            this.btnExclu.UseVisualStyleBackColor = true;
            this.btnExclu.Click += new System.EventHandler(this.btnExclu_Click);
            // 
            // btnPesqui
            // 
            this.btnPesqui.AutoSize = true;
            this.btnPesqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqui.Location = new System.Drawing.Point(651, 368);
            this.btnPesqui.Name = "btnPesqui";
            this.btnPesqui.Size = new System.Drawing.Size(109, 30);
            this.btnPesqui.TabIndex = 25;
            this.btnPesqui.Text = "Pesquisar";
            this.btnPesqui.UseVisualStyleBackColor = true;
            // 
            // btnCanc
            // 
            this.btnCanc.AutoSize = true;
            this.btnCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanc.Location = new System.Drawing.Point(495, 368);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(109, 30);
            this.btnCanc.TabIndex = 24;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // btnImpri
            // 
            this.btnImpri.AutoSize = true;
            this.btnImpri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpri.Location = new System.Drawing.Point(495, 415);
            this.btnImpri.Name = "btnImpri";
            this.btnImpri.Size = new System.Drawing.Size(109, 30);
            this.btnImpri.TabIndex = 23;
            this.btnImpri.Text = "Imprimir";
            this.btnImpri.UseVisualStyleBackColor = true;
            this.btnImpri.Click += new System.EventHandler(this.btnImpri_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(651, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 30);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPro
            // 
            this.btnPro.AutoSize = true;
            this.btnPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPro.Location = new System.Drawing.Point(651, 223);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(109, 32);
            this.btnPro.TabIndex = 21;
            this.btnPro.Text = "Próximo";
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(495, 225);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(109, 30);
            this.btnAnterior.TabIndex = 20;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_fornecedor", true));
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(289, 82);
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(28, 20);
            this.cd_fornecedorTextBox.TabIndex = 30;
            // 
            // nm_fornecedorTextBox
            // 
            this.nm_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_fornecedor", true));
            this.nm_fornecedorTextBox.Location = new System.Drawing.Point(281, 112);
            this.nm_fornecedorTextBox.Name = "nm_fornecedorTextBox";
            this.nm_fornecedorTextBox.Size = new System.Drawing.Size(323, 20);
            this.nm_fornecedorTextBox.TabIndex = 32;
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(308, 138);
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(296, 20);
            this.ds_enderecoTextBox.TabIndex = 34;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(300, 168);
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(304, 20);
            this.nm_bairroTextBox.TabIndex = 36;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(300, 196);
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(121, 20);
            this.nm_cidadeTextBox.TabIndex = 38;
            // 
            // sg_estadoComboBox
            // 
            this.sg_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "sg_estado", true));
            this.sg_estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sg_estadoComboBox.FormattingEnabled = true;
            this.sg_estadoComboBox.Items.AddRange(new object[] {
            "SP",
            "MG",
            "PE",
            "PI",
            "BH",
            "GO"});
            this.sg_estadoComboBox.Location = new System.Drawing.Point(300, 224);
            this.sg_estadoComboBox.Name = "sg_estadoComboBox";
            this.sg_estadoComboBox.Size = new System.Drawing.Size(121, 21);
            this.sg_estadoComboBox.TabIndex = 40;
            // 
            // cd_cepMaskedTextBox
            // 
            this.cd_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cep", true));
            this.cd_cepMaskedTextBox.Location = new System.Drawing.Point(300, 252);
            this.cd_cepMaskedTextBox.Mask = "00000-000";
            this.cd_cepMaskedTextBox.Name = "cd_cepMaskedTextBox";
            this.cd_cepMaskedTextBox.Size = new System.Drawing.Size(62, 20);
            this.cd_cepMaskedTextBox.TabIndex = 42;
            this.cd_cepMaskedTextBox.Leave += new System.EventHandler(this.cd_cepMaskedTextBox_Leave);
            // 
            // cd_cnpjMaskedTextBox
            // 
            this.cd_cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cnpj", true));
            this.cd_cnpjMaskedTextBox.Location = new System.Drawing.Point(300, 283);
            this.cd_cnpjMaskedTextBox.Mask = "00,000,000/0000-00";
            this.cd_cnpjMaskedTextBox.Name = "cd_cnpjMaskedTextBox";
            this.cd_cnpjMaskedTextBox.Size = new System.Drawing.Size(109, 20);
            this.cd_cnpjMaskedTextBox.TabIndex = 44;
            // 
            // cd_ieMaskedTextBox
            // 
            this.cd_ieMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_ie", true));
            this.cd_ieMaskedTextBox.Location = new System.Drawing.Point(300, 309);
            this.cd_ieMaskedTextBox.Mask = "000,000,000,000";
            this.cd_ieMaskedTextBox.Name = "cd_ieMaskedTextBox";
            this.cd_ieMaskedTextBox.Size = new System.Drawing.Size(86, 20);
            this.cd_ieMaskedTextBox.TabIndex = 46;
            this.cd_ieMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cd_ieMaskedTextBox.Leave += new System.EventHandler(this.cd_ieMaskedTextBox_Leave);
            // 
            // labelValida
            // 
            this.labelValida.AutoSize = true;
            this.labelValida.Location = new System.Drawing.Point(367, 255);
            this.labelValida.Name = "labelValida";
            this.labelValida.Size = new System.Drawing.Size(63, 13);
            this.labelValida.TabIndex = 47;
            this.labelValida.Text = "Validando...";
            // 
            // frmFornece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.labelValida);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.Controls.Add(this.nm_fornecedorTextBox);
            this.Controls.Add(this.ds_enderecoTextBox);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(this.sg_estadoComboBox);
            this.Controls.Add(this.cd_cepMaskedTextBox);
            this.Controls.Add(this.cd_cnpjMaskedTextBox);
            this.Controls.Add(this.cd_ieMaskedTextBox);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlte);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExclu);
            this.Controls.Add(this.btnPesqui);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnImpri);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(nm_fornecedorLabel);
            this.Controls.Add(ds_enderecoLabel);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(cd_cnpjLabel);
            this.Controls.Add(cd_ieLabel);
            this.Name = "frmFornece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de fornecedor";
            this.Load += new System.EventHandler(this.frmFornece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tb_fornecedorBindingSource;
        private CadastroDataSetTableAdapters.tb_fornecedorTableAdapter tb_fornecedorTableAdapter;
        private CadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlte;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExclu;
        private System.Windows.Forms.Button btnPesqui;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnImpri;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
        private System.Windows.Forms.TextBox nm_fornecedorTextBox;
        private System.Windows.Forms.TextBox ds_enderecoTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.ComboBox sg_estadoComboBox;
        private System.Windows.Forms.MaskedTextBox cd_cepMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_cnpjMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_ieMaskedTextBox;
        private System.Windows.Forms.Label labelValida;
    }
}