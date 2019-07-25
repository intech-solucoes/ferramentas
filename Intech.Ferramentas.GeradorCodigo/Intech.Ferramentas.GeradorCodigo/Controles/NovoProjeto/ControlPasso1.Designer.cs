namespace Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto
{
    partial class ControlPasso1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonProjetoExistente = new System.Windows.Forms.Button();
            this.ButtonNovoProjeto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 - Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2 - Parâmetros";
            // 
            // ButtonProjetoExistente
            // 
            this.ButtonProjetoExistente.Location = new System.Drawing.Point(391, 162);
            this.ButtonProjetoExistente.Name = "ButtonProjetoExistente";
            this.ButtonProjetoExistente.Size = new System.Drawing.Size(149, 23);
            this.ButtonProjetoExistente.TabIndex = 4;
            this.ButtonProjetoExistente.Text = "Projeto Existente";
            this.ButtonProjetoExistente.UseVisualStyleBackColor = true;
            this.ButtonProjetoExistente.Click += new System.EventHandler(this.ButtonProjetoExistente_Click);
            // 
            // ButtonNovoProjeto
            // 
            this.ButtonNovoProjeto.Location = new System.Drawing.Point(252, 162);
            this.ButtonNovoProjeto.Name = "ButtonNovoProjeto";
            this.ButtonNovoProjeto.Size = new System.Drawing.Size(133, 23);
            this.ButtonNovoProjeto.TabIndex = 3;
            this.ButtonNovoProjeto.Text = "Novo Projeto";
            this.ButtonNovoProjeto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 381);
            this.panel1.TabIndex = 5;
            // 
            // ControlPasso1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonProjetoExistente);
            this.Controls.Add(this.ButtonNovoProjeto);
            this.Name = "ControlPasso1";
            this.Size = new System.Drawing.Size(652, 381);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonProjetoExistente;
        private System.Windows.Forms.Button ButtonNovoProjeto;
        private System.Windows.Forms.Panel panel1;
    }
}
