using System;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmBusquedaUsuario : Form
    {
        private String idElegido;
        public String IDElegido { get => idElegido; }
        public frmBusquedaUsuario()
        {
            InitializeComponent();
        }

        private void frmBusquedaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSSistema.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.dSSistema.Rol);
            // TODO: esta línea de código carga datos en la tabla 'dSSistema.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dSSistema.Usuario);
            dgvDatos.AutoResizeColumns();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            string nombre, apellido;

            if (rbtContenga.Checked)
            {
                nombre = "%" + nombreToolStripTextBox.Text + "%";
                apellido = "%" + apellidoToolStripTextBox.Text + "%";
            }

            else if (rbtEmpieza.Checked)
            {
                nombre = nombreToolStripTextBox.Text + "%";
                apellido = apellidoToolStripTextBox.Text + "%";
            }

            else if (rbtTermina.Checked)
            {
                nombre = "%" + nombreToolStripTextBox.Text;
                apellido = "%" + apellidoToolStripTextBox.Text;
            }

            else
            {
                nombre = "%%";
                apellido = "%%";
                if (nombreToolStripTextBox.Text != string.Empty) nombre = nombreToolStripTextBox.Text;
                if (apellidoToolStripTextBox.Text != string.Empty) apellido = apellidoToolStripTextBox.Text;
            }

            try
            {
                this.usuarioTableAdapter.FillBy(
                    this.dSSistema.Usuario,
                    nombre,
                    apellido);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idElegido = "";
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                idElegido = "";
            }
            else if (dgvDatos.SelectedRows.Count != 0)
            {
                idElegido = dgvDatos.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                idElegido = dgvDatos.Rows[0].Cells[0].Value.ToString();
            }
            this.Close();
        }

        private void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            nombreToolStripTextBox.Text = string.Empty;
            apellidoToolStripTextBox.Text = string.Empty;
            fillByToolStripButton_Click(sender, e);
        }
    }
}
