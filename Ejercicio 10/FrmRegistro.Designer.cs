
namespace Ejercicio_10
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.tblRegistro = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tblRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblRegistro
            // 
            this.tblRegistro.ColumnCount = 2;
            this.tblRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.51719F));
            this.tblRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.48281F));
            this.tblRegistro.Controls.Add(this.txtUsuario, 1, 1);
            this.tblRegistro.Controls.Add(this.txtContra, 1, 2);
            this.tblRegistro.Controls.Add(this.lblUsuario, 0, 1);
            this.tblRegistro.Controls.Add(this.lblContra, 0, 2);
            this.tblRegistro.Controls.Add(this.btnIngresar, 0, 7);
            this.tblRegistro.Controls.Add(this.lblRegistro, 1, 6);
            this.tblRegistro.Controls.Add(this.label1, 0, 3);
            this.tblRegistro.Controls.Add(this.label2, 0, 4);
            this.tblRegistro.Controls.Add(this.label3, 0, 5);
            this.tblRegistro.Controls.Add(this.textBox1, 1, 3);
            this.tblRegistro.Controls.Add(this.textBox2, 1, 4);
            this.tblRegistro.Controls.Add(this.textBox3, 1, 5);
            this.tblRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistro.Location = new System.Drawing.Point(0, 0);
            this.tblRegistro.Name = "tblRegistro";
            this.tblRegistro.RowCount = 9;
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.02008F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85141F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85141F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85141F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85141F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85141F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85141F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85141F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.02008F));
            this.tblRegistro.Size = new System.Drawing.Size(717, 495);
            this.tblRegistro.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(322, 27);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(262, 31);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(322, 90);
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
            this.lblUsuario.Location = new System.Drawing.Point(199, 24);
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
            this.lblContra.Location = new System.Drawing.Point(193, 87);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(123, 29);
            this.lblContra.TabIndex = 3;
            this.lblContra.Text = "Apellido: ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblRegistro.SetColumnSpan(this.btnIngresar, 2);
            this.btnIngresar.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(233, 412);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(251, 42);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Registrar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblRegistro.Location = new System.Drawing.Point(322, 339);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(56, 23);
            this.lblRegistro.TabIndex = 6;
            this.lblRegistro.Text = "Login";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(158, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirmar Contraseña: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 31);
            this.textBox1.TabIndex = 10;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 31);
            this.textBox2.TabIndex = 11;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(322, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 31);
            this.textBox3.TabIndex = 12;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 495);
            this.Controls.Add(this.tblRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.tblRegistro.ResumeLayout(false);
            this.tblRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblRegistro;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}