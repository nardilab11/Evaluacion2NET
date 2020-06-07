namespace Vista
{
    partial class _ventanaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ventanaLogin));
            this._botonLogin = new System.Windows.Forms.Button();
            this._labelRut = new System.Windows.Forms.Label();
            this._labelContr = new System.Windows.Forms.Label();
            this._textboxRut = new System.Windows.Forms.TextBox();
            this._textboxContr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _botonLogin
            // 
            this._botonLogin.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._botonLogin.Location = new System.Drawing.Point(189, 238);
            this._botonLogin.Name = "_botonLogin";
            this._botonLogin.Size = new System.Drawing.Size(296, 35);
            this._botonLogin.TabIndex = 0;
            this._botonLogin.Text = "Ingresar";
            this._botonLogin.UseVisualStyleBackColor = true;
            // 
            // _labelRut
            // 
            this._labelRut.AutoSize = true;
            this._labelRut.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelRut.Location = new System.Drawing.Point(184, 105);
            this._labelRut.Name = "_labelRut";
            this._labelRut.Size = new System.Drawing.Size(59, 25);
            this._labelRut.TabIndex = 1;
            this._labelRut.Text = "RUT";
            // 
            // _labelContr
            // 
            this._labelContr.AutoSize = true;
            this._labelContr.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelContr.Location = new System.Drawing.Point(184, 149);
            this._labelContr.Name = "_labelContr";
            this._labelContr.Size = new System.Drawing.Size(145, 25);
            this._labelContr.TabIndex = 2;
            this._labelContr.Text = "Contraseña";
            // 
            // _textboxRut
            // 
            this._textboxRut.Location = new System.Drawing.Point(385, 105);
            this._textboxRut.Name = "_textboxRut";
            this._textboxRut.Size = new System.Drawing.Size(100, 20);
            this._textboxRut.TabIndex = 3;
            // 
            // _textboxContr
            // 
            this._textboxContr.Location = new System.Drawing.Point(385, 149);
            this._textboxContr.Name = "_textboxContr";
            this._textboxContr.Size = new System.Drawing.Size(100, 20);
            this._textboxContr.TabIndex = 4;
            // 
            // _ventanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._textboxContr);
            this.Controls.Add(this._textboxRut);
            this.Controls.Add(this._labelContr);
            this.Controls.Add(this._labelRut);
            this.Controls.Add(this._botonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_ventanaLogin";
            this.Text = "Sistema De Pedidos en Local Pizza Hat Spa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _botonLogin;
        private System.Windows.Forms.Label _labelRut;
        private System.Windows.Forms.Label _labelContr;
        private System.Windows.Forms.TextBox _textboxRut;
        private System.Windows.Forms.TextBox _textboxContr;
    }
}

