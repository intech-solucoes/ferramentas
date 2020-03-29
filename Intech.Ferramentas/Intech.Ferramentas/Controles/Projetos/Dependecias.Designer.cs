namespace Intech.Ferramentas.Controles.Projetos
{
    partial class Dependecias
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxDiretorio = new System.Windows.Forms.TextBox();
            this.ButtonProcurarDiretorio = new System.Windows.Forms.Button();
            this.ButtonIncluir = new System.Windows.Forms.Button();
            this.GridDiretorios = new System.Windows.Forms.DataGridView();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDiretorios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório";
            // 
            // TextBoxDiretorio
            // 
            this.TextBoxDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDiretorio.Location = new System.Drawing.Point(78, 10);
            this.TextBoxDiretorio.Name = "TextBoxDiretorio";
            this.TextBoxDiretorio.Size = new System.Drawing.Size(494, 22);
            this.TextBoxDiretorio.TabIndex = 1;
            // 
            // ButtonProcurarDiretorio
            // 
            this.ButtonProcurarDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonProcurarDiretorio.BackColor = System.Drawing.Color.Gold;
            this.ButtonProcurarDiretorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonProcurarDiretorio.FlatAppearance.BorderSize = 0;
            this.ButtonProcurarDiretorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProcurarDiretorio.Location = new System.Drawing.Point(578, 10);
            this.ButtonProcurarDiretorio.Name = "ButtonProcurarDiretorio";
            this.ButtonProcurarDiretorio.Size = new System.Drawing.Size(31, 22);
            this.ButtonProcurarDiretorio.TabIndex = 16;
            this.ButtonProcurarDiretorio.UseVisualStyleBackColor = false;
            this.ButtonProcurarDiretorio.Click += new System.EventHandler(this.ButtonProcurarDiretorio_Click);
            // 
            // ButtonIncluir
            // 
            this.ButtonIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonIncluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonIncluir.FlatAppearance.BorderSize = 0;
            this.ButtonIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonIncluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonIncluir.Location = new System.Drawing.Point(615, 10);
            this.ButtonIncluir.Name = "ButtonIncluir";
            this.ButtonIncluir.Size = new System.Drawing.Size(105, 22);
            this.ButtonIncluir.TabIndex = 17;
            this.ButtonIncluir.Text = "Incluir";
            this.ButtonIncluir.UseVisualStyleBackColor = false;
            this.ButtonIncluir.Click += new System.EventHandler(this.ButtonIncluir_Click);
            // 
            // GridDiretorios
            // 
            this.GridDiretorios.AllowUserToAddRows = false;
            this.GridDiretorios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridDiretorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDiretorios.Location = new System.Drawing.Point(12, 38);
            this.GridDiretorios.Name = "GridDiretorios";
            this.GridDiretorios.Size = new System.Drawing.Size(708, 351);
            this.GridDiretorios.TabIndex = 18;
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalvar.FlatAppearance.BorderSize = 0;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSalvar.Location = new System.Drawing.Point(578, 407);
            this.ButtonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(142, 30);
            this.ButtonSalvar.TabIndex = 19;
            this.ButtonSalvar.Text = "Salvar e Fechar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // Dependecias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(this.GridDiretorios);
            this.Controls.Add(this.ButtonIncluir);
            this.Controls.Add(this.ButtonProcurarDiretorio);
            this.Controls.Add(this.TextBoxDiretorio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dependecias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dependecias";
            this.Load += new System.EventHandler(this.Dependecias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDiretorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxDiretorio;
        private System.Windows.Forms.Button ButtonProcurarDiretorio;
        private System.Windows.Forms.Button ButtonIncluir;
        private System.Windows.Forms.DataGridView GridDiretorios;
        private System.Windows.Forms.Button ButtonSalvar;
    }
}