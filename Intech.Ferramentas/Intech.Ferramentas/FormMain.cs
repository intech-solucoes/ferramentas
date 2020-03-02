#region Usings
using Intech.Ferramentas.Controles;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms; 
#endregion

namespace Intech.Ferramentas
{
    public partial class FormMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
            {
                Navigate<Controles.Home.Home>();

                PictureLogo.Image = FontAwesome.Instance
                    .GetImage(new FontAwesome.Properties(FontAwesome.Type.Beer)
                    {
                        Size = 50,
                        ForeColor = Color.White
                    });

                ButtonClose.Image = FontAwesome.Instance
                    .GetImage(new FontAwesome.Properties(FontAwesome.Type.Times)
                    {
                        Size = 14
                    });

                ButtonMaximize.Image = FontAwesome.Instance
                    .GetImage(new FontAwesome.Properties(FontAwesome.Type.WindowMaximize)
                    {
                        Size = 14,
                        Location = new Point(0, 4)
                    });

                ButtonMinimize.Image = FontAwesome.Instance
                    .GetImage(new FontAwesome.Properties(FontAwesome.Type.WindowMinimize)
                    {
                        Size = 14,
                        Location = new Point(0, 3)
                    });
            }
        }

        #region Window Header

        private void ButtonClose_Click(object sender, EventArgs e) =>
            Close();

        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                ButtonMaximize.Image = FontAwesome.Instance
                .GetImage(new FontAwesome.Properties(FontAwesome.Type.WindowMaximize)
                {
                    Size = 14,
                    Location = new System.Drawing.Point(0, 4)
                });

                WindowState = FormWindowState.Normal;
            }
            else
            {
                ButtonMaximize.Image = FontAwesome.Instance
                .GetImage(new FontAwesome.Properties(FontAwesome.Type.WindowRestore)
                {
                    Size = 16,
                    Location = new System.Drawing.Point(0, 2)
                });

                WindowState = FormWindowState.Maximized;
            }
        }

        private void ButtonMinimize_Click(object sender, EventArgs e) =>
            WindowState = FormWindowState.Minimized;

        private void PanelWindowHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #region Navigation

        private void Navigate<T>()
        {
            PanelContent.Controls.Clear();
            var control = (PageControl)Activator.CreateInstance(typeof(T));
            control.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(control);
            LabelTitulo.Text = control.Titulo;
        }

        private void ButtonHome_Click(object sender, EventArgs e) =>
            Navigate<Controles.Home.Home>();

        private void ButtonDados_Click(object sender, EventArgs e) =>
            Navigate<Controles.Dados.GeradorDados>();

        private void ButtonSistemas_Click(object sender, EventArgs e) =>
            Navigate<Controles.Sistemas.Sistemas>();

        private void ButtonProjetos_Click(object sender, EventArgs e) =>
            Navigate<Controles.Projetos.Projetos>();

        private void ButtonServices_Click(object sender, EventArgs e) =>
            Navigate<Controles.Services.Services>();

        private void ButtonConexoes_Click(object sender, EventArgs e) =>
            Navigate<Controles.Conexoes.Conexoes>();

        #endregion
    }
}