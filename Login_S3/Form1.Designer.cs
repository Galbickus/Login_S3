namespace Login_S3
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picBoxUsuario = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(200, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(216, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Diseño de Login";
            // 
            // picBoxUsuario
            // 
            this.picBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUsuario.Image")));
            this.picBoxUsuario.Location = new System.Drawing.Point(61, 103);
            this.picBoxUsuario.Name = "picBoxUsuario";
            this.picBoxUsuario.Size = new System.Drawing.Size(147, 156);
            this.picBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUsuario.TabIndex = 1;
            this.picBoxUsuario.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIngresar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(265, 203);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(152, 55);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(248, 103);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(193, 32);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(248, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 348);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.picBoxUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Equipo 10";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picBoxUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

