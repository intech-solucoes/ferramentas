namespace Intech.Ferramentas.Controles.Home
{
    partial class Home
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
            this.LabelUpdate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxUrlApi = new System.Windows.Forms.ComboBox();
            this.ButtonProcurarDiretorio = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxDiretorioGIT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Versão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "0.0.1";
            // 
            // LabelUpdate
            // 
            this.LabelUpdate.AutoSize = true;
            this.LabelUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUpdate.Location = new System.Drawing.Point(8, 57);
            this.LabelUpdate.Name = "LabelUpdate";
            this.LabelUpdate.Size = new System.Drawing.Size(187, 20);
            this.LabelUpdate.TabIndex = 2;
            this.LabelUpdate.Text = "Nova versão disponível!";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ComboBoxUrlApi);
            this.groupBox1.Controls.Add(this.ButtonProcurarDiretorio);
            this.groupBox1.Controls.Add(this.ButtonSalvar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxDiretorioGIT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // ComboBoxUrlApi
            // 
            this.ComboBoxUrlApi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxUrlApi.FormattingEnabled = true;
            this.ComboBoxUrlApi.Items.AddRange(new object[] {
            "http://localhost/Ferramentas/",
            "http://10.10.170.11/Ferramentas/",
            "http://168.205.255.226/Ferramentas/"});
            this.ComboBoxUrlApi.Location = new System.Drawing.Point(6, 98);
            this.ComboBoxUrlApi.Name = "ComboBoxUrlApi";
            this.ComboBoxUrlApi.Size = new System.Drawing.Size(749, 25);
            this.ComboBoxUrlApi.TabIndex = 22;
            // 
            // ButtonProcurarDiretorio
            // 
            this.ButtonProcurarDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonProcurarDiretorio.BackColor = System.Drawing.Color.Gold;
            this.ButtonProcurarDiretorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonProcurarDiretorio.FlatAppearance.BorderSize = 0;
            this.ButtonProcurarDiretorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProcurarDiretorio.Location = new System.Drawing.Point(724, 44);
            this.ButtonProcurarDiretorio.Name = "ButtonProcurarDiretorio";
            this.ButtonProcurarDiretorio.Size = new System.Drawing.Size(31, 22);
            this.ButtonProcurarDiretorio.TabIndex = 21;
            this.ButtonProcurarDiretorio.UseVisualStyleBackColor = false;
            this.ButtonProcurarDiretorio.Click += new System.EventHandler(this.ButtonProcurarDiretorio_Click);
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalvar.FlatAppearance.BorderSize = 0;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSalvar.Location = new System.Drawing.Point(6, 140);
            this.ButtonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(87, 30);
            this.ButtonSalvar.TabIndex = 17;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "URL API do gerador";
            // 
            // TextBoxDiretorioGIT
            // 
            this.TextBoxDiretorioGIT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDiretorioGIT.Location = new System.Drawing.Point(6, 44);
            this.TextBoxDiretorioGIT.Name = "TextBoxDiretorioGIT";
            this.TextBoxDiretorioGIT.Size = new System.Drawing.Size(712, 23);
            this.TextBoxDiretorioGIT.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Diretório do Repositório";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(767, 433);
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxDiretorioGIT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button ButtonProcurarDiretorio;
        private System.Windows.Forms.ComboBox ComboBoxUrlApi;
    }
}
