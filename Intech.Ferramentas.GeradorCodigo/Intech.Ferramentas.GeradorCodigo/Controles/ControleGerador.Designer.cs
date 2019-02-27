namespace Intech.Ferramentas.GeradorCodigo.Controles
{
    partial class ControleGerador
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
            this.ComboBoxConexao = new System.Windows.Forms.ComboBox();
            this.conexaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxSistemas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ButtonGerar = new System.Windows.Forms.Button();
            this.CheckBoxGerarProxy = new System.Windows.Forms.CheckBox();
            this.CheckBoxGerarEntidade = new System.Windows.Forms.CheckBox();
            this.CheckBoxGerarDAO = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListEntidades = new System.Windows.Forms.ListBox();
            this.conexaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.ListEntidades);
            this.splitContainer1.Size = new System.Drawing.Size(467, 296);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ComboBoxConexao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBoxSistemas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 111);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // ComboBoxConexao
            // 
            this.ComboBoxConexao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxConexao.DataSource = this.conexaoBindingSource;
            this.ComboBoxConexao.DisplayMember = "Database";
            this.ComboBoxConexao.FormattingEnabled = true;
            this.ComboBoxConexao.Location = new System.Drawing.Point(6, 80);
            this.ComboBoxConexao.Name = "ComboBoxConexao";
            this.ComboBoxConexao.Size = new System.Drawing.Size(275, 21);
            this.ComboBoxConexao.TabIndex = 3;
            // 
            // conexaoBindingSource
            // 
            this.conexaoBindingSource.DataSource = typeof(Intech.Ferramentas.GeradorCodigo.Code.Conexao);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conexão";
            // 
            // ComboBoxSistemas
            // 
            this.ComboBoxSistemas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSistemas.FormattingEnabled = true;
            this.ComboBoxSistemas.Location = new System.Drawing.Point(6, 37);
            this.ComboBoxSistemas.Name = "ComboBoxSistemas";
            this.ComboBoxSistemas.Size = new System.Drawing.Size(275, 21);
            this.ComboBoxSistemas.TabIndex = 1;
            this.ComboBoxSistemas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSistemas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
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
            this.groupBox4.Location = new System.Drawing.Point(3, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 49);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gerar";
            // 
            // ButtonGerar
            // 
            this.ButtonGerar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonGerar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonGerar.Location = new System.Drawing.Point(206, 18);
            this.ButtonGerar.Name = "ButtonGerar";
            this.ButtonGerar.Size = new System.Drawing.Size(75, 23);
            this.ButtonGerar.TabIndex = 5;
            this.ButtonGerar.Text = "Gerar";
            this.ButtonGerar.UseVisualStyleBackColor = false;
            this.ButtonGerar.Click += new System.EventHandler(this.ButtonGerar_Click);
            // 
            // CheckBoxGerarProxy
            // 
            this.CheckBoxGerarProxy.AutoSize = true;
            this.CheckBoxGerarProxy.Location = new System.Drawing.Point(135, 22);
            this.CheckBoxGerarProxy.Name = "CheckBoxGerarProxy";
            this.CheckBoxGerarProxy.Size = new System.Drawing.Size(52, 17);
            this.CheckBoxGerarProxy.TabIndex = 4;
            this.CheckBoxGerarProxy.Text = "Proxy";
            this.CheckBoxGerarProxy.UseVisualStyleBackColor = true;
            // 
            // CheckBoxGerarEntidade
            // 
            this.CheckBoxGerarEntidade.AutoSize = true;
            this.CheckBoxGerarEntidade.Checked = true;
            this.CheckBoxGerarEntidade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxGerarEntidade.Location = new System.Drawing.Point(6, 22);
            this.CheckBoxGerarEntidade.Name = "CheckBoxGerarEntidade";
            this.CheckBoxGerarEntidade.Size = new System.Drawing.Size(68, 17);
            this.CheckBoxGerarEntidade.TabIndex = 1;
            this.CheckBoxGerarEntidade.Text = "Entidade";
            this.CheckBoxGerarEntidade.UseVisualStyleBackColor = true;
            // 
            // CheckBoxGerarDAO
            // 
            this.CheckBoxGerarDAO.AutoSize = true;
            this.CheckBoxGerarDAO.Checked = true;
            this.CheckBoxGerarDAO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxGerarDAO.Location = new System.Drawing.Point(80, 22);
            this.CheckBoxGerarDAO.Name = "CheckBoxGerarDAO";
            this.CheckBoxGerarDAO.Size = new System.Drawing.Size(49, 17);
            this.CheckBoxGerarDAO.TabIndex = 2;
            this.CheckBoxGerarDAO.Text = "DAO";
            this.CheckBoxGerarDAO.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nova";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ListEntidades
            // 
            this.ListEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListEntidades.DataSource = this.conexaoBindingSource;
            this.ListEntidades.DisplayMember = "Database";
            this.ListEntidades.FormattingEnabled = true;
            this.ListEntidades.Location = new System.Drawing.Point(3, 29);
            this.ListEntidades.Name = "ListEntidades";
            this.ListEntidades.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListEntidades.Size = new System.Drawing.Size(162, 264);
            this.ListEntidades.TabIndex = 6;
            this.ListEntidades.SelectedIndexChanged += new System.EventHandler(this.ListEntidades_SelectedIndexChanged);
            // 
            // conexaoBindingSource1
            // 
            this.conexaoBindingSource1.DataSource = typeof(Intech.Ferramentas.GeradorCodigo.Code.Conexao);
            // 
            // ControleGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ControleGerador";
            this.Size = new System.Drawing.Size(467, 296);
            this.Load += new System.EventHandler(this.ControleGerador_Load);
            this.Enter += new System.EventHandler(this.ControleGerador_Enter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox ListEntidades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource conexaoBindingSource;
        private System.Windows.Forms.BindingSource conexaoBindingSource1;
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
    }
}
