
namespace Sistema
{
    partial class frmUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDUsuarioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label fechaModificacionClaveLabel;
            System.Windows.Forms.Label iDRolLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label activoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dSSistema = new Sistema.DSSistema();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Sistema.DSSistemaTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new Sistema.DSSistemaTableAdapters.TableAdapterManager();
            this.usuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearchItem = new System.Windows.Forms.ToolStripButton();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.iDUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.fechaModificacionClaveTextBox = new System.Windows.Forms.TextBox();
            this.iDRolComboBox = new System.Windows.Forms.ComboBox();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rolTableAdapter = new Sistema.DSSistemaTableAdapters.RolTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            iDUsuarioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            fechaModificacionClaveLabel = new System.Windows.Forms.Label();
            iDRolLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).BeginInit();
            this.usuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDUsuarioLabel
            // 
            iDUsuarioLabel.AutoSize = true;
            iDUsuarioLabel.Location = new System.Drawing.Point(17, 44);
            iDUsuarioLabel.Name = "iDUsuarioLabel";
            iDUsuarioLabel.Size = new System.Drawing.Size(61, 17);
            iDUsuarioLabel.TabIndex = 1;
            iDUsuarioLabel.Text = "Usuario:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(29, 70);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(29, 98);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(62, 17);
            apellidoLabel.TabIndex = 9;
            apellidoLabel.Text = "Apellido:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(44, 126);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(47, 17);
            claveLabel.TabIndex = 11;
            claveLabel.Text = "Clave:";
            // 
            // fechaModificacionClaveLabel
            // 
            fechaModificacionClaveLabel.AutoSize = true;
            fechaModificacionClaveLabel.Location = new System.Drawing.Point(283, 126);
            fechaModificacionClaveLabel.Name = "fechaModificacionClaveLabel";
            fechaModificacionClaveLabel.Size = new System.Drawing.Size(172, 17);
            fechaModificacionClaveLabel.TabIndex = 13;
            fechaModificacionClaveLabel.Text = "Fecha Modificacion Clave:";
            // 
            // iDRolLabel
            // 
            iDRolLabel.AutoSize = true;
            iDRolLabel.Location = new System.Drawing.Point(337, 45);
            iDRolLabel.Name = "iDRolLabel";
            iDRolLabel.Size = new System.Drawing.Size(33, 17);
            iDRolLabel.TabIndex = 3;
            iDRolLabel.Text = "Rol:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(36, 154);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(55, 17);
            correoLabel.TabIndex = 15;
            correoLabel.Text = "Correo:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(547, 44);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(50, 17);
            activoLabel.TabIndex = 5;
            activoLabel.Text = "Activo:";
            // 
            // dSSistema
            // 
            this.dSSistema.DataSetName = "DSSistema";
            this.dSSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dSSistema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema.DSSistemaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // usuarioBindingNavigator
            // 
            this.usuarioBindingNavigator.AddNewItem = null;
            this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
            this.usuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuarioBindingNavigator.DeleteItem = null;
            this.usuarioBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.usuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripSeparator1,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorCancelItem,
            this.bindingNavigatorSearchItem});
            this.usuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuarioBindingNavigator.Name = "usuarioBindingNavigator";
            this.usuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuarioBindingNavigator.Size = new System.Drawing.Size(1001, 27);
            this.usuarioBindingNavigator.TabIndex = 0;
            this.usuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditItem.Image")));
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorEditItem.Text = "Editar registro";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorSaveItem.Text = "Guardar datos";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.usuarioBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCancelItem
            // 
            this.bindingNavigatorCancelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancelItem.Enabled = false;
            this.bindingNavigatorCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancelItem.Image")));
            this.bindingNavigatorCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancelItem.Name = "bindingNavigatorCancelItem";
            this.bindingNavigatorCancelItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorCancelItem.Text = "Cancelar cambios";
            this.bindingNavigatorCancelItem.Click += new System.EventHandler(this.bindingNavigatorCancelItem_Click);
            // 
            // bindingNavigatorSearchItem
            // 
            this.bindingNavigatorSearchItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSearchItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSearchItem.Image")));
            this.bindingNavigatorSearchItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearchItem.Name = "bindingNavigatorSearchItem";
            this.bindingNavigatorSearchItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorSearchItem.Text = "Buscar registro";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.dgvDatos.DataSource = this.usuarioBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDatos.Location = new System.Drawing.Point(12, 188);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(977, 469);
            this.dgvDatos.TabIndex = 17;
            // 
            // iDUsuarioTextBox
            // 
            this.iDUsuarioTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "IDUsuario", true));
            this.iDUsuarioTextBox.Location = new System.Drawing.Point(97, 41);
            this.iDUsuarioTextBox.Name = "iDUsuarioTextBox";
            this.iDUsuarioTextBox.ReadOnly = true;
            this.iDUsuarioTextBox.Size = new System.Drawing.Size(139, 22);
            this.iDUsuarioTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(97, 67);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(279, 22);
            this.nombreTextBox.TabIndex = 8;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(97, 95);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.ReadOnly = true;
            this.apellidoTextBox.Size = new System.Drawing.Size(279, 22);
            this.apellidoTextBox.TabIndex = 10;
            // 
            // claveTextBox
            // 
            this.claveTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(97, 123);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.ReadOnly = true;
            this.claveTextBox.Size = new System.Drawing.Size(139, 22);
            this.claveTextBox.TabIndex = 12;
            // 
            // fechaModificacionClaveTextBox
            // 
            this.fechaModificacionClaveTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.fechaModificacionClaveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "FechaModificacionClave", true));
            this.fechaModificacionClaveTextBox.Location = new System.Drawing.Point(461, 123);
            this.fechaModificacionClaveTextBox.Name = "fechaModificacionClaveTextBox";
            this.fechaModificacionClaveTextBox.ReadOnly = true;
            this.fechaModificacionClaveTextBox.Size = new System.Drawing.Size(105, 22);
            this.fechaModificacionClaveTextBox.TabIndex = 14;
            this.fechaModificacionClaveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iDRolComboBox
            // 
            this.iDRolComboBox.BackColor = System.Drawing.Color.Aquamarine;
            this.iDRolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioBindingSource, "IDRol", true));
            this.iDRolComboBox.DataSource = this.rolBindingSource;
            this.iDRolComboBox.DisplayMember = "Descripcion";
            this.iDRolComboBox.Enabled = false;
            this.iDRolComboBox.FormattingEnabled = true;
            this.iDRolComboBox.Location = new System.Drawing.Point(376, 40);
            this.iDRolComboBox.Name = "iDRolComboBox";
            this.iDRolComboBox.Size = new System.Drawing.Size(136, 24);
            this.iDRolComboBox.TabIndex = 4;
            this.iDRolComboBox.ValueMember = "IDRol";
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.dSSistema;
            // 
            // correoTextBox
            // 
            this.correoTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(97, 151);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.ReadOnly = true;
            this.correoTextBox.Size = new System.Drawing.Size(279, 22);
            this.correoTextBox.TabIndex = 16;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Activo", true));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(603, 42);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(43, 24);
            this.activoCheckBox.TabIndex = 6;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1001, 3);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Clave";
            this.dataGridViewTextBoxColumn4.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaModificacionClave";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fec. Modif. Clave";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IDRol";
            this.dataGridViewTextBoxColumn6.DataSource = this.rolBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "IDRol";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1001, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(iDRolLabel);
            this.Controls.Add(this.iDRolComboBox);
            this.Controls.Add(fechaModificacionClaveLabel);
            this.Controls.Add(this.fechaModificacionClaveTextBox);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(iDUsuarioLabel);
            this.Controls.Add(this.iDUsuarioTextBox);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.usuarioBindingNavigator);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).EndInit();
            this.usuarioBindingNavigator.ResumeLayout(false);
            this.usuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSSistema dSSistema;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DSSistemaTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private DSSistemaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox iDUsuarioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox fechaModificacionClaveTextBox;
        private System.Windows.Forms.ComboBox iDRolComboBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearchItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private DSSistemaTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}