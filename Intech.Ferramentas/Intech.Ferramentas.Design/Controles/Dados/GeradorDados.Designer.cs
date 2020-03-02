namespace Intech.Ferramentas.Controles.Dados
{
    partial class GeradorDados
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxProjeto = new System.Windows.Forms.ComboBox();
            this.projetoEntidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxConexao = new System.Windows.Forms.ComboBox();
            this.conexaoEntidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxSistemas = new System.Windows.Forms.ComboBox();
            this.sistemaEntidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ButtonGerar = new System.Windows.Forms.Button();
            this.CheckBoxGerarProxy = new System.Windows.Forms.CheckBox();
            this.CheckBoxGerarEntidade = new System.Windows.Forms.CheckBox();
            this.CheckBoxGerarDAO = new System.Windows.Forms.CheckBox();
            this.ButtonEditarEntidade = new System.Windows.Forms.Button();
            this.ButtonNovaEntidade = new System.Windows.Forms.Button();
            this.ListEntidades = new System.Windows.Forms.ListBox();
            this.versaoEntidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoEntidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoEntidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEntidadeBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versaoEntidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ButtonEditarEntidade);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonNovaEntidade);
            this.splitContainer1.Panel2.Controls.Add(this.ListEntidades);
            this.splitContainer1.Size = new System.Drawing.Size(937, 624);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ComboBoxProjeto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboBoxConexao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBoxSistemas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(561, 195);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // ComboBoxProjeto
            // 
            this.ComboBoxProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxProjeto.DataSource = this.projetoEntidadeBindingSource;
            this.ComboBoxProjeto.DisplayMember = "NOM_PROJETO";
            this.ComboBoxProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProjeto.FormattingEnabled = true;
            this.ComboBoxProjeto.Location = new System.Drawing.Point(7, 162);
            this.ComboBoxProjeto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxProjeto.Name = "ComboBoxProjeto";
            this.ComboBoxProjeto.Size = new System.Drawing.Size(545, 25);
            this.ComboBoxProjeto.TabIndex = 5;
            // 
            // projetoEntidadeBindingSource
            // 
            this.projetoEntidadeBindingSource.DataSource = typeof(Intech.Ferramentas.Dados.Entidades.ProjetoEntidade);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Projeto";
            // 
            // ComboBoxConexao
            // 
            this.ComboBoxConexao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxConexao.DataSource = this.conexaoEntidadeBindingSource;
            this.ComboBoxConexao.DisplayMember = "NOME";
            this.ComboBoxConexao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxConexao.FormattingEnabled = true;
            this.ComboBoxConexao.Location = new System.Drawing.Point(7, 105);
            this.ComboBoxConexao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxConexao.Name = "ComboBoxConexao";
            this.ComboBoxConexao.Size = new System.Drawing.Size(545, 25);
            this.ComboBoxConexao.TabIndex = 3;
            // 
            // conexaoEntidadeBindingSource
            // 
            this.conexaoEntidadeBindingSource.DataSource = typeof(Intech.Ferramentas.Dados.Entidades.ConexaoEntidade);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conexão";
            // 
            // ComboBoxSistemas
            // 
            this.ComboBoxSistemas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSistemas.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxSistemas.DataSource = this.sistemaEntidadeBindingSource;
            this.ComboBoxSistemas.DisplayMember = "NOM_SISTEMA";
            this.ComboBoxSistemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSistemas.FormattingEnabled = true;
            this.ComboBoxSistemas.Location = new System.Drawing.Point(7, 48);
            this.ComboBoxSistemas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxSistemas.Name = "ComboBoxSistemas";
            this.ComboBoxSistemas.Size = new System.Drawing.Size(545, 25);
            this.ComboBoxSistemas.TabIndex = 1;
            this.ComboBoxSistemas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSistemas_SelectedIndexChanged);
            // 
            // sistemaEntidadeBindingSource
            // 
            this.sistemaEntidadeBindingSource.DataSource = typeof(Intech.Ferramentas.Dados.Entidades.SistemaEntidade);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ButtonGerar);
            this.groupBox4.Controls.Add(this.CheckBoxGerarProxy);
            this.groupBox4.Controls.Add(this.CheckBoxGerarEntidade);
            this.groupBox4.Controls.Add(this.CheckBoxGerarDAO);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(14, 235);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(561, 64);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gerar";
            // 
            // ButtonGerar
            // 
            this.ButtonGerar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonGerar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGerar.FlatAppearance.BorderSize = 0;
            this.ButtonGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGerar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonGerar.Location = new System.Drawing.Point(468, 22);
            this.ButtonGerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonGerar.Name = "ButtonGerar";
            this.ButtonGerar.Size = new System.Drawing.Size(87, 30);
            this.ButtonGerar.TabIndex = 5;
            this.ButtonGerar.Text = "Gerar";
            this.ButtonGerar.UseVisualStyleBackColor = false;
            this.ButtonGerar.Click += new System.EventHandler(this.ButtonGerar_Click);
            // 
            // CheckBoxGerarProxy
            // 
            this.CheckBoxGerarProxy.AutoSize = true;
            this.CheckBoxGerarProxy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxGerarProxy.Location = new System.Drawing.Point(171, 26);
            this.CheckBoxGerarProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxGerarProxy.Name = "CheckBoxGerarProxy";
            this.CheckBoxGerarProxy.Size = new System.Drawing.Size(60, 21);
            this.CheckBoxGerarProxy.TabIndex = 4;
            this.CheckBoxGerarProxy.Text = "Proxy";
            this.CheckBoxGerarProxy.UseVisualStyleBackColor = true;
            // 
            // CheckBoxGerarEntidade
            // 
            this.CheckBoxGerarEntidade.AutoSize = true;
            this.CheckBoxGerarEntidade.Checked = true;
            this.CheckBoxGerarEntidade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxGerarEntidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxGerarEntidade.Location = new System.Drawing.Point(10, 26);
            this.CheckBoxGerarEntidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxGerarEntidade.Name = "CheckBoxGerarEntidade";
            this.CheckBoxGerarEntidade.Size = new System.Drawing.Size(85, 21);
            this.CheckBoxGerarEntidade.TabIndex = 1;
            this.CheckBoxGerarEntidade.Text = "Entidade";
            this.CheckBoxGerarEntidade.UseVisualStyleBackColor = true;
            // 
            // CheckBoxGerarDAO
            // 
            this.CheckBoxGerarDAO.AutoSize = true;
            this.CheckBoxGerarDAO.Checked = true;
            this.CheckBoxGerarDAO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxGerarDAO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxGerarDAO.Location = new System.Drawing.Point(104, 26);
            this.CheckBoxGerarDAO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxGerarDAO.Name = "CheckBoxGerarDAO";
            this.CheckBoxGerarDAO.Size = new System.Drawing.Size(57, 21);
            this.CheckBoxGerarDAO.TabIndex = 2;
            this.CheckBoxGerarDAO.Text = "DAO";
            this.CheckBoxGerarDAO.UseVisualStyleBackColor = true;
            // 
            // ButtonEditarEntidade
            // 
            this.ButtonEditarEntidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditarEntidade.BackColor = System.Drawing.SystemColors.GrayText;
            this.ButtonEditarEntidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonEditarEntidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEditarEntidade.FlatAppearance.BorderSize = 0;
            this.ButtonEditarEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditarEntidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditarEntidade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonEditarEntidade.Location = new System.Drawing.Point(180, 4);
            this.ButtonEditarEntidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonEditarEntidade.Name = "ButtonEditarEntidade";
            this.ButtonEditarEntidade.Size = new System.Drawing.Size(144, 30);
            this.ButtonEditarEntidade.TabIndex = 8;
            this.ButtonEditarEntidade.Text = "Editar";
            this.ButtonEditarEntidade.UseVisualStyleBackColor = false;
            // 
            // ButtonNovaEntidade
            // 
            this.ButtonNovaEntidade.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonNovaEntidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonNovaEntidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNovaEntidade.FlatAppearance.BorderSize = 0;
            this.ButtonNovaEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovaEntidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNovaEntidade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonNovaEntidade.Location = new System.Drawing.Point(3, 4);
            this.ButtonNovaEntidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonNovaEntidade.Name = "ButtonNovaEntidade";
            this.ButtonNovaEntidade.Size = new System.Drawing.Size(159, 30);
            this.ButtonNovaEntidade.TabIndex = 7;
            this.ButtonNovaEntidade.Text = "Nova";
            this.ButtonNovaEntidade.UseVisualStyleBackColor = false;
            // 
            // ListEntidades
            // 
            this.ListEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListEntidades.FormattingEnabled = true;
            this.ListEntidades.ItemHeight = 17;
            this.ListEntidades.Location = new System.Drawing.Point(3, 42);
            this.ListEntidades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListEntidades.Name = "ListEntidades";
            this.ListEntidades.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListEntidades.Size = new System.Drawing.Size(320, 582);
            this.ListEntidades.TabIndex = 6;
            this.ListEntidades.SelectedIndexChanged += new System.EventHandler(this.ListEntidades_SelectedIndexChanged);
            // 
            // versaoEntidadeBindingSource
            // 
            this.versaoEntidadeBindingSource.DataSource = typeof(Intech.Ferramentas.Dados.Entidades.VersaoEntidade);
            // 
            // GeradorDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GeradorDados";
            this.Size = new System.Drawing.Size(937, 624);
            this.Load += new System.EventHandler(this.GeradorDados_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoEntidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoEntidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEntidadeBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versaoEntidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxConexao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxSistemas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ButtonGerar;
        private System.Windows.Forms.CheckBox CheckBoxGerarProxy;
        private System.Windows.Forms.CheckBox CheckBoxGerarEntidade;
        private System.Windows.Forms.CheckBox CheckBoxGerarDAO;
        private System.Windows.Forms.Button ButtonEditarEntidade;
        private System.Windows.Forms.Button ButtonNovaEntidade;
        private System.Windows.Forms.ListBox ListEntidades;
        private System.Windows.Forms.ComboBox ComboBoxProjeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource sistemaEntidadeBindingSource;
        private System.Windows.Forms.BindingSource conexaoEntidadeBindingSource;
        private System.Windows.Forms.BindingSource projetoEntidadeBindingSource;
        private System.Windows.Forms.BindingSource versaoEntidadeBindingSource;
    }
}
