namespace Intech.Ferramentas
{
    partial class FormMain
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
            this.PanelWindowHeader = new System.Windows.Forms.Panel();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonMaximize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonServices = new System.Windows.Forms.Button();
            this.ButtonProjetos = new System.Windows.Forms.Button();
            this.ButtonSistemas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.ButtonDados = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.ButtonConexoes = new System.Windows.Forms.Button();
            this.PanelWindowHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelWindowHeader
            // 
            this.PanelWindowHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelWindowHeader.Controls.Add(this.LabelTitulo);
            this.PanelWindowHeader.Controls.Add(this.ButtonMinimize);
            this.PanelWindowHeader.Controls.Add(this.ButtonMaximize);
            this.PanelWindowHeader.Controls.Add(this.ButtonClose);
            this.PanelWindowHeader.Location = new System.Drawing.Point(200, 0);
            this.PanelWindowHeader.Name = "PanelWindowHeader";
            this.PanelWindowHeader.Size = new System.Drawing.Size(769, 35);
            this.PanelWindowHeader.TabIndex = 0;
            this.PanelWindowHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelWindowHeader_MouseMove);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(15, 10);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(62, 24);
            this.LabelTitulo.TabIndex = 3;
            this.LabelTitulo.Text = "Título";
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.Location = new System.Drawing.Point(643, 0);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(42, 35);
            this.ButtonMinimize.TabIndex = 2;
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonMaximize
            // 
            this.ButtonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonMaximize.FlatAppearance.BorderSize = 0;
            this.ButtonMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMaximize.Location = new System.Drawing.Point(685, 0);
            this.ButtonMaximize.Name = "ButtonMaximize";
            this.ButtonMaximize.Size = new System.Drawing.Size(42, 35);
            this.ButtonMaximize.TabIndex = 1;
            this.ButtonMaximize.UseVisualStyleBackColor = true;
            this.ButtonMaximize.Click += new System.EventHandler(this.ButtonMaximize_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Location = new System.Drawing.Point(727, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(42, 35);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ButtonConexoes);
            this.panel1.Controls.Add(this.ButtonServices);
            this.panel1.Controls.Add(this.ButtonProjetos);
            this.panel1.Controls.Add(this.ButtonSistemas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PictureLogo);
            this.panel1.Controls.Add(this.ButtonDados);
            this.panel1.Controls.Add(this.ButtonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 682);
            this.panel1.TabIndex = 1;
            // 
            // ButtonServices
            // 
            this.ButtonServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(233)))));
            this.ButtonServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonServices.FlatAppearance.BorderSize = 0;
            this.ButtonServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(218)))));
            this.ButtonServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonServices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonServices.ForeColor = System.Drawing.Color.White;
            this.ButtonServices.Location = new System.Drawing.Point(0, 345);
            this.ButtonServices.Name = "ButtonServices";
            this.ButtonServices.Size = new System.Drawing.Size(200, 50);
            this.ButtonServices.TabIndex = 9;
            this.ButtonServices.Text = "Services";
            this.ButtonServices.UseVisualStyleBackColor = false;
            this.ButtonServices.Click += new System.EventHandler(this.ButtonServices_Click);
            // 
            // ButtonProjetos
            // 
            this.ButtonProjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(233)))));
            this.ButtonProjetos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonProjetos.FlatAppearance.BorderSize = 0;
            this.ButtonProjetos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(218)))));
            this.ButtonProjetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProjetos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonProjetos.ForeColor = System.Drawing.Color.White;
            this.ButtonProjetos.Location = new System.Drawing.Point(0, 241);
            this.ButtonProjetos.Name = "ButtonProjetos";
            this.ButtonProjetos.Size = new System.Drawing.Size(200, 50);
            this.ButtonProjetos.TabIndex = 8;
            this.ButtonProjetos.Text = "Projetos";
            this.ButtonProjetos.UseVisualStyleBackColor = false;
            this.ButtonProjetos.Click += new System.EventHandler(this.ButtonProjetos_Click);
            // 
            // ButtonSistemas
            // 
            this.ButtonSistemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(233)))));
            this.ButtonSistemas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSistemas.FlatAppearance.BorderSize = 0;
            this.ButtonSistemas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(218)))));
            this.ButtonSistemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSistemas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSistemas.ForeColor = System.Drawing.Color.White;
            this.ButtonSistemas.Location = new System.Drawing.Point(-1, 189);
            this.ButtonSistemas.Name = "ButtonSistemas";
            this.ButtonSistemas.Size = new System.Drawing.Size(200, 50);
            this.ButtonSistemas.TabIndex = 7;
            this.ButtonSistemas.Text = "Sistemas";
            this.ButtonSistemas.UseVisualStyleBackColor = false;
            this.ButtonSistemas.Click += new System.EventHandler(this.ButtonSistemas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Intech";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Breja";
            // 
            // PictureLogo
            // 
            this.PictureLogo.Location = new System.Drawing.Point(29, 17);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(54, 50);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureLogo.TabIndex = 4;
            this.PictureLogo.TabStop = false;
            // 
            // ButtonDados
            // 
            this.ButtonDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(233)))));
            this.ButtonDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDados.FlatAppearance.BorderSize = 0;
            this.ButtonDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(218)))));
            this.ButtonDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDados.ForeColor = System.Drawing.Color.White;
            this.ButtonDados.Location = new System.Drawing.Point(-1, 137);
            this.ButtonDados.Name = "ButtonDados";
            this.ButtonDados.Size = new System.Drawing.Size(200, 50);
            this.ButtonDados.TabIndex = 3;
            this.ButtonDados.Text = "Dados";
            this.ButtonDados.UseVisualStyleBackColor = false;
            this.ButtonDados.Click += new System.EventHandler(this.ButtonDados_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(233)))));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(218)))));
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.White;
            this.ButtonHome.Location = new System.Drawing.Point(-1, 85);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(200, 50);
            this.ButtonHome.TabIndex = 2;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PanelContent);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.PanelWindowHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 684);
            this.panel2.TabIndex = 2;
            // 
            // PanelContent
            // 
            this.PanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContent.Location = new System.Drawing.Point(200, 41);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Padding = new System.Windows.Forms.Padding(10);
            this.PanelContent.Size = new System.Drawing.Size(769, 642);
            this.PanelContent.TabIndex = 2;
            // 
            // ButtonConexoes
            // 
            this.ButtonConexoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(233)))));
            this.ButtonConexoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonConexoes.FlatAppearance.BorderSize = 0;
            this.ButtonConexoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(218)))));
            this.ButtonConexoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConexoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConexoes.ForeColor = System.Drawing.Color.White;
            this.ButtonConexoes.Location = new System.Drawing.Point(0, 293);
            this.ButtonConexoes.Name = "ButtonConexoes";
            this.ButtonConexoes.Size = new System.Drawing.Size(200, 50);
            this.ButtonConexoes.TabIndex = 10;
            this.ButtonConexoes.Text = "Conexões";
            this.ButtonConexoes.UseVisualStyleBackColor = false;
            this.ButtonConexoes.Click += new System.EventHandler(this.ButtonConexoes_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 684);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(970, 684);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intech - Ferramentas";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelWindowHeader.ResumeLayout(false);
            this.PanelWindowHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelWindowHeader;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonMaximize;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Button ButtonDados;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSistemas;
        private System.Windows.Forms.Button ButtonProjetos;
        private System.Windows.Forms.Button ButtonServices;
        private System.Windows.Forms.Button ButtonConexoes;
    }
}