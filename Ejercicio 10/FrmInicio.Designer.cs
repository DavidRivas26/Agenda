
namespace Ejercicio_10
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblRegistro = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefonoPersonal = new System.Windows.Forms.Label();
            this.lblTelefonoTrabajo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefonoPersonal = new System.Windows.Forms.TextBox();
            this.txtTelefonoTrabajo = new System.Windows.Forms.TextBox();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.msMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.msCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.msPrincipal.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.Controls.Add(this.tblRegistro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvContactos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 704);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tblRegistro
            // 
            this.tblRegistro.ColumnCount = 2;
            this.tblRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRegistro.Controls.Add(this.txtNombre, 1, 0);
            this.tblRegistro.Controls.Add(this.txtApellido, 1, 1);
            this.tblRegistro.Controls.Add(this.lblUsuario, 0, 0);
            this.tblRegistro.Controls.Add(this.lblContra, 0, 1);
            this.tblRegistro.Controls.Add(this.btnGuardar, 0, 5);
            this.tblRegistro.Controls.Add(this.lblDireccion, 0, 2);
            this.tblRegistro.Controls.Add(this.lblTelefonoPersonal, 0, 3);
            this.tblRegistro.Controls.Add(this.lblTelefonoTrabajo, 0, 4);
            this.tblRegistro.Controls.Add(this.txtDireccion, 1, 2);
            this.tblRegistro.Controls.Add(this.txtTelefonoPersonal, 1, 3);
            this.tblRegistro.Controls.Add(this.txtTelefonoTrabajo, 1, 4);
            this.tblRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistro.Location = new System.Drawing.Point(102, 3);
            this.tblRegistro.Name = "tblRegistro";
            this.tblRegistro.RowCount = 6;
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblRegistro.Size = new System.Drawing.Size(893, 310);
            this.tblRegistro.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(449, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 31);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(449, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(262, 31);
            this.txtApellido.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(326, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(117, 29);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Nombre: ";
            // 
            // lblContra
            // 
            this.lblContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblContra.Location = new System.Drawing.Point(320, 51);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(123, 29);
            this.lblContra.TabIndex = 3;
            this.lblContra.Text = "Apellido: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblRegistro.SetColumnSpan(this.btnGuardar, 2);
            this.btnGuardar.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(321, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(251, 42);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(308, 102);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(135, 29);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion: ";
            // 
            // lblTelefonoPersonal
            // 
            this.lblTelefonoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoPersonal.AutoSize = true;
            this.lblTelefonoPersonal.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTelefonoPersonal.Location = new System.Drawing.Point(211, 153);
            this.lblTelefonoPersonal.Name = "lblTelefonoPersonal";
            this.lblTelefonoPersonal.Size = new System.Drawing.Size(232, 29);
            this.lblTelefonoPersonal.TabIndex = 8;
            this.lblTelefonoPersonal.Text = "Telefono Personal: ";
            // 
            // lblTelefonoTrabajo
            // 
            this.lblTelefonoTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefonoTrabajo.AutoSize = true;
            this.lblTelefonoTrabajo.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTelefonoTrabajo.Location = new System.Drawing.Point(186, 204);
            this.lblTelefonoTrabajo.Name = "lblTelefonoTrabajo";
            this.lblTelefonoTrabajo.Size = new System.Drawing.Size(257, 29);
            this.lblTelefonoTrabajo.TabIndex = 9;
            this.lblTelefonoTrabajo.Text = "Telefono de Trabajo: ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(449, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(262, 31);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtTelefonoPersonal
            // 
            this.txtTelefonoPersonal.Location = new System.Drawing.Point(449, 156);
            this.txtTelefonoPersonal.Name = "txtTelefonoPersonal";
            this.txtTelefonoPersonal.Size = new System.Drawing.Size(262, 31);
            this.txtTelefonoPersonal.TabIndex = 11;
            // 
            // txtTelefonoTrabajo
            // 
            this.txtTelefonoTrabajo.Location = new System.Drawing.Point(449, 207);
            this.txtTelefonoTrabajo.Name = "txtTelefonoTrabajo";
            this.txtTelefonoTrabajo.Size = new System.Drawing.Size(262, 31);
            this.txtTelefonoTrabajo.TabIndex = 12;
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContactos.Location = new System.Drawing.Point(102, 319);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 62;
            this.dgvContactos.RowTemplate.Height = 33;
            this.dgvContactos.Size = new System.Drawing.Size(893, 310);
            this.dgvContactos.TabIndex = 5;
            this.dgvContactos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnDeseleccionar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEliminar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(102, 635);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(893, 66);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnDeseleccionar.Location = new System.Drawing.Point(544, 12);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(251, 42);
            this.btnDeseleccionar.TabIndex = 8;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.UseVisualStyleBackColor = true;
            this.btnDeseleccionar.Click += new System.EventHandler(this.btnDeseleccionar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(97, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(251, 42);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // msPrincipal
            // 
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenu});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1100, 33);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // msMenu
            // 
            this.msMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCerrarSesion});
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(73, 29);
            this.msMenu.Text = "Menu";
            // 
            // msCerrarSesion
            // 
            this.msCerrarSesion.Name = "msCerrarSesion";
            this.msCerrarSesion.Size = new System.Drawing.Size(218, 34);
            this.msCerrarSesion.Text = "Cerrar Sesión";
            this.msCerrarSesion.Click += new System.EventHandler(this.msCerrarSesion_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(3, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(3, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 737);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.msPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblRegistro.ResumeLayout(false);
            this.tblRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tblRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefonoPersonal;
        private System.Windows.Forms.Label lblTelefonoTrabajo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefonoPersonal;
        private System.Windows.Forms.TextBox txtTelefonoTrabajo;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem msMenu;
        private System.Windows.Forms.ToolStripMenuItem msCerrarSesion;
        private System.Windows.Forms.Button btnDeseleccionar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}