namespace Intech.Ferramentas.Controles.Sistemas
{
    partial class Sistemas
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
            this.ButtonNovoSistema = new System.Windows.Forms.Button();
            this.ListSistemas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonExcluir = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxNamespaceEntidades = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxNamespaceNegocio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxNamespaceDados = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBoxDiretorioEntidades = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxDiretorioNegocio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxDiretorioDados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonNovoSistema
            // 
            this.ButtonNovoSistema.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonNovoSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonNovoSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNovoSistema.FlatAppearance.BorderSize = 0;
            this.ButtonNovoSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovoSistema.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNovoSistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonNovoSistema.Location = new System.Drawing.Point(3, 4);
            this.ButtonNovoSistema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonNovoSistema.Name = "ButtonNovoSistema";
            this.ButtonNovoSistema.Size = new System.Drawing.Size(229, 30);
            this.ButtonNovoSistema.TabIndex = 10;
            this.ButtonNovoSistema.Text = "Novo";
            this.ButtonNovoSistema.UseVisualStyleBackColor = false;
            this.ButtonNovoSistema.Click += new System.EventHandler(this.ButtonNovoSistema_Click);
            // 
            // ListSistemas
            // 
            this.ListSistemas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListSistemas.DisplayMember = "NOM_SISTEMA";
            this.ListSistemas.FormattingEnabled = true;
            this.ListSistemas.Location = new System.Drawing.Point(3, 42);
            this.ListSistemas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListSistemas.Name = "ListSistemas";
            this.ListSistemas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListSistemas.Size = new System.Drawing.Size(229, 563);
            this.ListSistemas.TabIndex = 9;
            this.ListSistemas.SelectedIndexChanged += new System.EventHandler(this.ListSistemas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ButtonExcluir);
            this.groupBox1.Controls.Add(this.ButtonSalvar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TextBoxNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(238, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(740, 570);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.BackColor = System.Drawing.Color.Coral;
            this.ButtonExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExcluir.FlatAppearance.BorderSize = 0;
            this.ButtonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonExcluir.Location = new System.Drawing.Point(125, 532);
            this.ButtonExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonExcluir.Name = "ButtonExcluir";
            this.ButtonExcluir.Size = new System.Drawing.Size(113, 30);
            this.ButtonExcluir.TabIndex = 12;
            this.ButtonExcluir.Text = "Excluir";
            this.ButtonExcluir.UseVisualStyleBackColor = false;
            this.ButtonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalvar.FlatAppearance.BorderSize = 0;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSalvar.Location = new System.Drawing.Point(6, 532);
            this.ButtonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(113, 30);
            this.ButtonSalvar.TabIndex = 11;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.TextBoxNamespaceEntidades);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TextBoxNamespaceNegocio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TextBoxNamespaceDados);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 192);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Namespaces";
            // 
            // TextBoxNamespaceEntidades
            // 
            this.TextBoxNamespaceEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNamespaceEntidades.Location = new System.Drawing.Point(6, 158);
            this.TextBoxNamespaceEntidades.Name = "TextBoxNamespaceEntidades";
            this.TextBoxNamespaceEntidades.Size = new System.Drawing.Size(716, 23);
            this.TextBoxNamespaceEntidades.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Entidades";
            // 
            // TextBoxNamespaceNegocio
            // 
            this.TextBoxNamespaceNegocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNamespaceNegocio.Location = new System.Drawing.Point(6, 103);
            this.TextBoxNamespaceNegocio.Name = "TextBoxNamespaceNegocio";
            this.TextBoxNamespaceNegocio.Size = new System.Drawing.Size(716, 23);
            this.TextBoxNamespaceNegocio.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Negócio";
            // 
            // TextBoxNamespaceDados
            // 
            this.TextBoxNamespaceDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNamespaceDados.Location = new System.Drawing.Point(6, 51);
            this.TextBoxNamespaceDados.Name = "TextBoxNamespaceDados";
            this.TextBoxNamespaceDados.Size = new System.Drawing.Size(716, 23);
            this.TextBoxNamespaceDados.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dados";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TextBoxDiretorioEntidades);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TextBoxDiretorioNegocio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TextBoxDiretorioDados);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diretório dos Projetos";
            // 
            // TextBoxDiretorioEntidades
            // 
            this.TextBoxDiretorioEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDiretorioEntidades.Location = new System.Drawing.Point(6, 158);
            this.TextBoxDiretorioEntidades.Name = "TextBoxDiretorioEntidades";
            this.TextBoxDiretorioEntidades.Size = new System.Drawing.Size(716, 23);
            this.TextBoxDiretorioEntidades.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Entidades";
            // 
            // TextBoxDiretorioNegocio
            // 
            this.TextBoxDiretorioNegocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDiretorioNegocio.Location = new System.Drawing.Point(6, 103);
            this.TextBoxDiretorioNegocio.Name = "TextBoxDiretorioNegocio";
            this.TextBoxDiretorioNegocio.Size = new System.Drawing.Size(716, 23);
            this.TextBoxDiretorioNegocio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Negócio";
            // 
            // TextBoxDiretorioDados
            // 
            this.TextBoxDiretorioDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDiretorioDados.Location = new System.Drawing.Point(6, 51);
            this.TextBoxDiretorioDados.Name = "TextBoxDiretorioDados";
            this.TextBoxDiretorioDados.Size = new System.Drawing.Size(716, 23);
            this.TextBoxDiretorioDados.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dados";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNome.Location = new System.Drawing.Point(7, 47);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(727, 23);
            this.TextBoxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Sistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonNovoSistema);
            this.Controls.Add(this.ListSistemas);
            this.Name = "Sistemas";
            this.Size = new System.Drawing.Size(981, 613);
            this.Load += new System.EventHandler(this.Sistemas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonNovoSistema;
        private System.Windows.Forms.ListBox ListSistemas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBoxDiretorioDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxDiretorioNegocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxDiretorioEntidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TextBoxNamespaceEntidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxNamespaceNegocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxNamespaceDados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonExcluir;
        private System.Windows.Forms.Button ButtonSalvar;
    }
}
