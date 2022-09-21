using CADSistema;
using System;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmPrincipal : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado 
        { 
            get => usuarioLogueado; 
            set => usuarioLogueado = value;
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios miForm = new frmUsuarios();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.MdiParent = this;
            miForm.Show();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            nombreUsuarioToolStripStatusLabel.Text = "Usuario: " + usuarioLogueado.Nombre + " " + usuarioLogueado.Apellido;
            VerificaCambioClave(sender, e);
            VerificarPermisos();
        }

        private void VerificarPermisos()
        {
            usuariosToolStripMenuItem.Visible = CADPermisoRol.PermisoRolPuedeVer(usuarioLogueado.IDRol, "frmUsuarios");
        }
        private void VerificaCambioClave(object sender, System.EventArgs e)
        {
            if (usuarioLogueado.FechaModificacionClave.AddDays(30) < DateTime.Now)
            {
                MessageBox.Show("Su último Cambio de Clave fue hace más de 30 días. Debe generar una Nueva Clave.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cambioDeClaveToolStripMenuItem_Click(sender, e);
            }
        }

        private void cambioDeClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioClave miForm = new frmCambioClave();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.ShowDialog();
        }

        private void cambioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioUsuario miForm = new frmCambioUsuario();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.ShowDialog();
            if (miForm.UsuarioLogueado != null)
            {
                usuarioLogueado = miForm.UsuarioLogueado;
                nombreUsuarioToolStripStatusLabel.Text = "Usuario: " + usuarioLogueado.Nombre + " " + usuarioLogueado.Apellido;
                VerificarPermisos();
            }
        }
    }
}
