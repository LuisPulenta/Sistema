using CADSistema;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmUsuarios : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private bool nuevo =false;
        String ClaveAnterior;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        //------------------- frmUsuarios_Load -------------------------
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.rolTableAdapter.Fill(this.dSSistema.Rol);
            this.rolTableAdapter.Fill(this.dSSistema.Rol);
            this.usuarioTableAdapter.Fill(this.dSSistema.Usuario);
            dgvDatos.AutoResizeColumns();
            VerificarPermisos();
        }
        private void VerificarPermisos()
        {
            bindingNavigatorAddNewItem.Enabled = CADPermisoRol.PermisoRolPuedeModificar(usuarioLogueado.IDRol, this.Name);
            bindingNavigatorEditItem.Enabled = CADPermisoRol.PermisoRolPuedeModificar(usuarioLogueado.IDRol, this.Name);
            bindingNavigatorDeleteItem.Enabled = CADPermisoRol.PermisoRolPuedeBorrar(usuarioLogueado.IDRol, this.Name);
        }        //------------------- Habilitar -------------------------
        private void Habilitar(bool campo)
        {
            Color color = Color.White;

            if (!campo)
            {
                color = Color.Aquamarine;
            }
            else
            {
                color = Color.White;
            }

            iDRolComboBox.Enabled = campo;
            nombreTextBox.ReadOnly = !campo;
            apellidoTextBox.ReadOnly = !campo;
            claveTextBox.ReadOnly = !campo;
            correoTextBox.ReadOnly = !campo;
            activoCheckBox.Enabled = campo;

            bindingNavigatorEditItem.Enabled = !campo;
            bindingNavigatorAddNewItem.Enabled = !campo;
            bindingNavigatorDeleteItem.Enabled = !campo;
            bindingNavigatorSaveItem.Enabled = campo;
            bindingNavigatorCancelItem.Enabled = campo;
            bindingNavigatorSearchItem.Enabled = !campo;

            bindingNavigatorMoveFirstItem.Enabled = !campo;
            bindingNavigatorMovePreviousItem.Enabled = !campo;
            bindingNavigatorMoveNextItem.Enabled = !campo;
            bindingNavigatorMoveLastItem.Enabled = !campo;
            bindingNavigatorPositionItem.Enabled = !campo;
            bindingNavigatorCountItem.Enabled = !campo;

            nombreTextBox.BackColor = color;
            apellidoTextBox.BackColor = color;
            correoTextBox.BackColor = color;
            claveTextBox.BackColor = color;
            iDRolComboBox.BackColor = color;
        }

        //------------------- Validarcampos -------------------------
        private bool Validarcampos()
        {
            errorProvider1.Clear();

            if (nuevo)
            {
                if (iDUsuarioTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(iDUsuarioTextBox, "Debe ingresar un IDUsuario");
                    iDUsuarioTextBox.Focus();
                    return false;
                }

                if (CADUsuario.ExisteUsuario(iDUsuarioTextBox.Text))
                {
                    errorProvider1.SetError(iDUsuarioTextBox, "Este IDUsuario ya existe");
                    iDUsuarioTextBox.Focus();
                    return false;
                }
            }

            if (iDRolComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDRolComboBox, "Debe seleccionar un Rol");
                iDRolComboBox.Focus();
                return false;
            }

            if (nombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, "Debe ingresar un Nombre");
                nombreTextBox.Focus();
                return false;
            }

            if (nombreTextBox.Text.Length > 30)
            {
                errorProvider1.SetError(nombreTextBox, "El Nombre no puede tener más de 30 caracteres");
                nombreTextBox.Focus();
                return false;
            }

            if (apellidoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(apellidoTextBox, "Debe ingresar un Apellido");
                apellidoTextBox.Focus();
                return false;
            }

            if (apellidoTextBox.Text.Length > 20)
            {
                errorProvider1.SetError(apellidoTextBox, "El Apellido no puede tener más de 20 caracteres");
                apellidoTextBox.Focus();
                return false;
            }

            if (claveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(claveTextBox, "Debe ingresar una Clave");
                claveTextBox.Focus();
                return false;
            }

            if (claveTextBox.Text.Length > 20)
            {
                errorProvider1.SetError(claveTextBox, "La Clave no puede tener más de 20 caracteres");
                claveTextBox.Focus();
                return false;
            }

            if (correoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(correoTextBox, "Debe ingresar un Correo");
                correoTextBox.Focus();
                return false;
            }

            if (correoTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(correoTextBox, "El Correo no puede tener más de 50 caracteres");
                correoTextBox.Focus();
                return false;
            }

            RegexUtilities regexUtilities = new RegexUtilities();
            if (!regexUtilities.IsValidEmail(correoTextBox.Text))
            {
                errorProvider1.SetError(correoTextBox, "El correo ingresado no es válido");
                correoTextBox.Focus();
                return false;
            }

            return true;
        }

        //------------------- bindingNavigatorEditItem_Click -------------------------
        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = false;
            ClaveAnterior = claveTextBox.Text;
        }

        //------------------- bindingNavigatorAddNewItem_Click -------------------------
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = true;
            iDUsuarioTextBox.ReadOnly = false;
            usuarioBindingSource.AddNew();
            fechaModificacionClaveTextBox.Text = DateTime.Now.ToString().Substring(0, DateTime.Now.ToString().Length-9);
            activoCheckBox.Checked = false;
            iDUsuarioTextBox.Focus();
        }

        //------------------- bindingNavigatorDeleteItem_Click -------------------------
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Está seguro de borrar el Registro actual?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            this.Validate();
            this.usuarioBindingSource.RemoveAt(usuarioBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSSistema);
            dgvDatos.AutoResizeColumns();
        }

        //------------------- bindingNavigatorCancelItem_Click -------------------------
        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.usuarioBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
            VerificarPermisos();
        }

        //------------------- usuarioBindingNavigatorSaveItem_Click -------------------------
        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();

            if (ClaveAnterior != claveTextBox.Text)
            {
                fechaModificacionClaveTextBox.Text = DateTime.Now.ToString().Substring(0, DateTime.Now.ToString().Length - 9);
            }

            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSistema);
            Habilitar(false);
            VerificarPermisos();
            dgvDatos.AutoResizeColumns();
        }
    }
}
