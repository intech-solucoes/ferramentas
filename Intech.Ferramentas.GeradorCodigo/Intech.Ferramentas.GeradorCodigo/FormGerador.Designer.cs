namespace Intech.Ferramentas.GeradorCodigo
{
    partial class FormGerador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerador));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ComboBoxSistemas = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListEntidades = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ButtonGerar = new System.Windows.Forms.Button();
            this.CheckBoxGerarProxy = new System.Windows.Forms.CheckBox();
            this.CheckBoxGerarEntidade = new System.Windows.Forms.CheckBox();
            this.CheckBoxGerarDAO = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.ComboBoxSistemas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(99, 22);
            this.toolStripButton2.Text = "Configuração";
            // 
            // ComboBoxSistemas
            // 
            this.ComboBoxSistemas.Name = "ComboBoxSistemas";
            this.ComboBoxSistemas.Size = new System.Drawing.Size(200, 25);
            this.ComboBoxSistemas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSistemas_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 335);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListEntidades);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(570, 303);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 0;
            // 
            // ListEntidades
            // 
            this.ListEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListEntidades.FormattingEnabled = true;
            this.ListEntidades.Location = new System.Drawing.Point(5, 3);
            this.ListEntidades.Name = "ListEntidades";
            this.ListEntidades.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListEntidades.Size = new System.Drawing.Size(209, 290);
            this.ListEntidades.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ButtonGerar);
            this.groupBox4.Controls.Add(this.CheckBoxGerarProxy);
            this.groupBox4.Controls.Add(this.CheckBoxGerarEntidade);
            this.groupBox4.Controls.Add(this.CheckBoxGerarDAO);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 290);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opções";
            // 
            // ButtonGerar
            // 
            this.ButtonGerar.Location = new System.Drawing.Point(7, 259);
            this.ButtonGerar.Name = "ButtonGerar";
            this.ButtonGerar.Size = new System.Drawing.Size(75, 23);
            this.ButtonGerar.TabIndex = 5;
            this.ButtonGerar.Text = "Gerar";
            this.ButtonGerar.UseVisualStyleBackColor = true;
            this.ButtonGerar.Click += new System.EventHandler(this.ButtonGerar_Click);
            // 
            // CheckBoxGerarProxy
            // 
            this.CheckBoxGerarProxy.AutoSize = true;
            this.CheckBoxGerarProxy.Location = new System.Drawing.Point(6, 69);
            this.CheckBoxGerarProxy.Name = "CheckBoxGerarProxy";
            this.CheckBoxGerarProxy.Size = new System.Drawing.Size(81, 17);
            this.CheckBoxGerarProxy.TabIndex = 4;
            this.CheckBoxGerarProxy.Text = "Gerar Proxy";
            this.CheckBoxGerarProxy.UseVisualStyleBackColor = true;
            // 
            // CheckBoxGerarEntidade
            // 
            this.CheckBoxGerarEntidade.AutoSize = true;
            this.CheckBoxGerarEntidade.Checked = true;
            this.CheckBoxGerarEntidade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxGerarEntidade.Location = new System.Drawing.Point(6, 22);
            this.CheckBoxGerarEntidade.Name = "CheckBoxGerarEntidade";
            this.CheckBoxGerarEntidade.Size = new System.Drawing.Size(97, 17);
            this.CheckBoxGerarEntidade.TabIndex = 1;
            this.CheckBoxGerarEntidade.Text = "Gerar Entidade";
            this.CheckBoxGerarEntidade.UseVisualStyleBackColor = true;
            // 
            // CheckBoxGerarDAO
            // 
            this.CheckBoxGerarDAO.AutoSize = true;
            this.CheckBoxGerarDAO.Checked = true;
            this.CheckBoxGerarDAO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxGerarDAO.Location = new System.Drawing.Point(6, 46);
            this.CheckBoxGerarDAO.Name = "CheckBoxGerarDAO";
            this.CheckBoxGerarDAO.Size = new System.Drawing.Size(78, 17);
            this.CheckBoxGerarDAO.TabIndex = 2;
            this.CheckBoxGerarDAO.Text = "Gerar DAO";
            this.CheckBoxGerarDAO.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "API";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormGerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Código";
            this.Load += new System.EventHandler(this.FormGerador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripComboBox ComboBoxSistemas;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox ListEntidades;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox CheckBoxGerarProxy;
        private System.Windows.Forms.CheckBox CheckBoxGerarEntidade;
        private System.Windows.Forms.CheckBox CheckBoxGerarDAO;
        private System.Windows.Forms.Button ButtonGerar;
    }
}

