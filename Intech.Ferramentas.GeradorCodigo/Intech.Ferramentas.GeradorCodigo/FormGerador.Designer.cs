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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.controleGerador1 = new Intech.Ferramentas.GeradorCodigo.Controles.ControleGerador();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.controleConexoes1 = new Intech.Ferramentas.GeradorCodigo.Controles.ControleConexoes();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.controleProjetos1 = new Intech.Ferramentas.GeradorCodigo.Controles.ControleProjetos();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.controleUtilitarios1 = new Intech.Ferramentas.GeradorCodigo.Controles.ControleUtilitarios();
            this.ButtonConfiguracao = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 567);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.controleGerador1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 541);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Gerador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // controleGerador1
            // 
            this.controleGerador1.Config = null;
            this.controleGerador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controleGerador1.Location = new System.Drawing.Point(3, 3);
            this.controleGerador1.Name = "controleGerador1";
            this.controleGerador1.Size = new System.Drawing.Size(761, 535);
            this.controleGerador1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.controleConexoes1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conexões";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // controleConexoes1
            // 
            this.controleConexoes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controleConexoes1.Location = new System.Drawing.Point(3, 3);
            this.controleConexoes1.Name = "controleConexoes1";
            this.controleConexoes1.Size = new System.Drawing.Size(761, 404);
            this.controleConexoes1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.controleProjetos1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 410);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Projetos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // controleProjetos1
            // 
            this.controleProjetos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controleProjetos1.Location = new System.Drawing.Point(3, 3);
            this.controleProjetos1.Name = "controleProjetos1";
            this.controleProjetos1.Size = new System.Drawing.Size(761, 404);
            this.controleProjetos1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.controleUtilitarios1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(767, 410);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Utilitários";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // controleUtilitarios1
            // 
            this.controleUtilitarios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controleUtilitarios1.Location = new System.Drawing.Point(3, 3);
            this.controleUtilitarios1.Name = "controleUtilitarios1";
            this.controleUtilitarios1.Size = new System.Drawing.Size(761, 404);
            this.controleUtilitarios1.TabIndex = 0;
            // 
            // ButtonConfiguracao
            // 
            this.ButtonConfiguracao.Image = ((System.Drawing.Image)(resources.GetObject("ButtonConfiguracao.Image")));
            this.ButtonConfiguracao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonConfiguracao.Name = "ButtonConfiguracao";
            this.ButtonConfiguracao.Size = new System.Drawing.Size(99, 22);
            this.ButtonConfiguracao.Text = "Configuração";
            this.ButtonConfiguracao.Click += new System.EventHandler(this.ButtonConfiguracao_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonConfiguracao});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 592);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormGerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Código";
            this.Load += new System.EventHandler(this.FormGerador_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controles.ControleConexoes controleConexoes1;
        private System.Windows.Forms.ToolStripButton ButtonConfiguracao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage tabPage1;
        private Controles.ControleGerador controleGerador1;
        private System.Windows.Forms.TabPage tabPage3;
        private Controles.ControleProjetos controleProjetos1;
        private System.Windows.Forms.TabPage tabPage4;
        private Controles.ControleUtilitarios controleUtilitarios1;
    }
}

