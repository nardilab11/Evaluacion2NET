namespace Evaluacion2NET.Vista
{
    partial class _ventanaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ventanaMenu));
            this._botonNuevaCaja = new System.Windows.Forms.Button();
            this._botonNuevoPedido = new System.Windows.Forms.Button();
            this._botonConsultarPedidos = new System.Windows.Forms.Button();
            this._labelBienvenido = new System.Windows.Forms.Label();
            this._botonVolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _botonNuevaCaja
            // 
            this._botonNuevaCaja.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._botonNuevaCaja.Location = new System.Drawing.Point(248, 88);
            this._botonNuevaCaja.Name = "_botonNuevaCaja";
            this._botonNuevaCaja.Size = new System.Drawing.Size(229, 47);
            this._botonNuevaCaja.TabIndex = 0;
            this._botonNuevaCaja.Text = "Nueva Caja";
            this._botonNuevaCaja.UseVisualStyleBackColor = true;
            // 
            // _botonNuevoPedido
            // 
            this._botonNuevoPedido.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._botonNuevoPedido.Location = new System.Drawing.Point(248, 160);
            this._botonNuevoPedido.Name = "_botonNuevoPedido";
            this._botonNuevoPedido.Size = new System.Drawing.Size(229, 49);
            this._botonNuevoPedido.TabIndex = 1;
            this._botonNuevoPedido.Text = "Nuevo Pedido";
            this._botonNuevoPedido.UseVisualStyleBackColor = true;
            // 
            // _botonConsultarPedidos
            // 
            this._botonConsultarPedidos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._botonConsultarPedidos.Location = new System.Drawing.Point(248, 233);
            this._botonConsultarPedidos.Name = "_botonConsultarPedidos";
            this._botonConsultarPedidos.Size = new System.Drawing.Size(229, 47);
            this._botonConsultarPedidos.TabIndex = 2;
            this._botonConsultarPedidos.Text = "Consultar Pedidos";
            this._botonConsultarPedidos.UseVisualStyleBackColor = true;
            // 
            // _labelBienvenido
            // 
            this._labelBienvenido.AutoSize = true;
            this._labelBienvenido.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBienvenido.Location = new System.Drawing.Point(257, 27);
            this._labelBienvenido.Name = "_labelBienvenido";
            this._labelBienvenido.Size = new System.Drawing.Size(220, 35);
            this._labelBienvenido.TabIndex = 3;
            this._labelBienvenido.Text = "¡Bienvenido!";
            // 
            // _botonVolverMenu
            // 
            this._botonVolverMenu.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._botonVolverMenu.Location = new System.Drawing.Point(248, 296);
            this._botonVolverMenu.Name = "_botonVolverMenu";
            this._botonVolverMenu.Size = new System.Drawing.Size(229, 33);
            this._botonVolverMenu.TabIndex = 4;
            this._botonVolverMenu.Text = "Volver";
            this._botonVolverMenu.UseVisualStyleBackColor = true;
            // 
            // _ventanaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._botonVolverMenu);
            this.Controls.Add(this._labelBienvenido);
            this.Controls.Add(this._botonConsultarPedidos);
            this.Controls.Add(this._botonNuevoPedido);
            this.Controls.Add(this._botonNuevaCaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_ventanaMenu";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _botonNuevaCaja;
        private System.Windows.Forms.Button _botonNuevoPedido;
        private System.Windows.Forms.Button _botonConsultarPedidos;
        private System.Windows.Forms.Label _labelBienvenido;
        private System.Windows.Forms.Button _botonVolverMenu;
    }
}