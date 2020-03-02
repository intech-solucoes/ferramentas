namespace Intech.Ferramentas.Controles.Services
{
    partial class Services
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
            this.ComboBoxProjeto = new System.Windows.Forms.ComboBox();
            this.CheckedListBoxDependentes = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxTodos = new System.Windows.Forms.CheckBox();
            this.ButtonGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxProjeto
            // 
            this.ComboBoxProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxProjeto.BackColor = System.Drawing.SystemColors.Control;
            this.ComboBoxProjeto.DisplayMember = "NOM_PROJETO";
            this.ComboBoxProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxProjeto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProjeto.FormattingEnabled = true;
            this.ComboBoxProjeto.Location = new System.Drawing.Point(3, 3);
            this.ComboBoxProjeto.Name = "ComboBoxProjeto";
            this.ComboBoxProjeto.Size = new System.Drawing.Size(975, 41);
            this.ComboBoxProjeto.TabIndex = 0;
            this.ComboBoxProjeto.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProjeto_SelectedIndexChanged);
            // 
            // CheckedListBoxDependentes
            // 
            this.CheckedListBoxDependentes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CheckedListBoxDependentes.CheckOnClick = true;
            this.CheckedListBoxDependentes.FormattingEnabled = true;
            this.CheckedListBoxDependentes.Location = new System.Drawing.Point(3, 102);
            this.CheckedListBoxDependentes.Name = "CheckedListBoxDependentes";
            this.CheckedListBoxDependentes.Size = new System.Drawing.Size(258, 508);
            this.CheckedListBoxDependentes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dependentes";
            // 
            // CheckBoxTodos
            // 
            this.CheckBoxTodos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxTodos.AutoSize = true;
            this.CheckBoxTodos.Location = new System.Drawing.Point(197, 81);
            this.CheckBoxTodos.Name = "CheckBoxTodos";
            this.CheckBoxTodos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBoxTodos.Size = new System.Drawing.Size(64, 21);
            this.CheckBoxTodos.TabIndex = 4;
            this.CheckBoxTodos.Text = "Todos";
            this.CheckBoxTodos.UseVisualStyleBackColor = true;
            this.CheckBoxTodos.CheckedChanged += new System.EventHandler(this.CheckBoxTodos_CheckedChanged);
            // 
            // ButtonGerar
            // 
            this.ButtonGerar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGerar.FlatAppearance.BorderSize = 0;
            this.ButtonGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGerar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonGerar.Location = new System.Drawing.Point(267, 102);
            this.ButtonGerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonGerar.Name = "ButtonGerar";
            this.ButtonGerar.Size = new System.Drawing.Size(251, 58);
            this.ButtonGerar.TabIndex = 15;
            this.ButtonGerar.Text = "Gerar Services";
            this.ButtonGerar.UseVisualStyleBackColor = false;
            this.ButtonGerar.Click += new System.EventHandler(this.ButtonGerar_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonGerar);
            this.Controls.Add(this.CheckBoxTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckedListBoxDependentes);
            this.Controls.Add(this.ComboBoxProjeto);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Services";
            this.Size = new System.Drawing.Size(981, 613);
            this.Load += new System.EventHandler(this.Services_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxProjeto;
        private System.Windows.Forms.CheckedListBox CheckedListBoxDependentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxTodos;
        private System.Windows.Forms.Button ButtonGerar;
    }
}
