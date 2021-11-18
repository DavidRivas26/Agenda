
namespace Ejercicio_10
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tblLogin = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.tblLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLogin
            // 
            this.tblLogin.ColumnCount = 2;
            this.tblLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLogin.Controls.Add(this.txtUsuario, 1, 1);
            this.tblLogin.Controls.Add(this.txtContra, 1, 2);
            this.tblLogin.Controls.Add(this.lblUsuario, 0, 1);
            this.tblLogin.Controls.Add(this.lblContra, 0, 2);
            this.tblLogin.Controls.Add(this.btnIngresar, 0, 4);
            this.tblLogin.Controls.Add(this.lblRegistro, 1, 3);
            this.tblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLogin.Location = new System.Drawing.Point(0, 0);
            this.tblLogin.Name = "tblLogin";
            this.tblLogin.RowCount = 5;
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tblLogin.Size = new System.Drawing.Size(603, 348);
            this.tblLogin.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(304, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(262, 31);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(304, 129);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(262, 31);
            this.txtContra.TabIndex = 1;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(182, 63);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(116, 29);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // lblContra
            // 
            this.lblContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblContra.Location = new System.Drawing.Point(140, 126);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(158, 29);
            this.lblContra.TabIndex = 3;
            this.lblContra.Text = "Contraseña: ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLogin.SetColumnSpan(this.btnIngresar, 2);
            this.btnIngresar.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(176, 279);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(251, 42);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblRegistro.Location = new System.Drawing.Point(304, 189);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(115, 23);
            this.lblRegistro.TabIndex = 6;
            this.lblRegistro.Text = "Registrarme";
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 348);
            this.Controls.Add(this.tblLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.tblLogin.ResumeLayout(false);
            this.tblLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblRegistro;
    }
}