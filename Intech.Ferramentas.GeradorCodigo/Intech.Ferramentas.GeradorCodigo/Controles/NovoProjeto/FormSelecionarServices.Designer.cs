namespace Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto
{
    partial class FormSelecionarServices
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
            this.CheckedListBoxServices = new System.Windows.Forms.CheckedListBox();
            this.ButtonAtualizar = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckedListBoxServices
            // 
            this.CheckedListBoxServices.CheckOnClick = true;
            this.CheckedListBoxServices.FormattingEnabled = true;
            this.CheckedListBoxServices.Location = new System.Drawing.Point(13, 43);
            this.CheckedListBoxServices.Name = "CheckedListBoxServices";
            this.CheckedListBoxServices.Size = new System.Drawing.Size(313, 349);
            this.CheckedListBoxServices.TabIndex = 0;
            this.CheckedListBoxServices.ThreeDCheckBoxes = true;
            // 
            // ButtonAtualizar
            // 
            this.ButtonAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAtualizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAtualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonAtualizar.Location = new System.Drawing.Point(13, 12);
            this.ButtonAtualizar.Name = "ButtonAtualizar";
            this.ButtonAtualizar.Size = new System.Drawing.Size(313, 23);
            this.ButtonAtualizar.TabIndex = 18;
            this.ButtonAtualizar.Text = "Atualizar";
            this.ButtonAtualizar.UseVisualStyleBackColor = false;
            this.ButtonAtualizar.Click += new System.EventHandler(this.ButtonAtualizar_Click);
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSalvar.Location = new System.Drawing.Point(12, 396);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(314, 23);
            this.ButtonSalvar.TabIndex = 19;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // FormSelecionarServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 431);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(this.ButtonAtualizar);
            this.Controls.Add(this.CheckedListBoxServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSelecionarServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSelecionarServices";
            this.Load += new System.EventHandler(this.FormSelecionarServices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListBoxServices;
        private System.Windows.Forms.Button ButtonAtualizar;
        private System.Windows.Forms.Button ButtonSalvar;
    }
}