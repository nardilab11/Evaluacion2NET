namespace Evaluacion2NET.Vista
{
    partial class _ventanaSeleccionCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ventanaSeleccionCaja));
            this._labelSeleccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelSeleccion
            // 
            this._labelSeleccion.AutoSize = true;
            this._labelSeleccion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSeleccion.Location = new System.Drawing.Point(242, 43);
            this._labelSeleccion.Name = "_labelSeleccion";
            this._labelSeleccion.Size = new System.Drawing.Size(250, 25);
            this._labelSeleccion.TabIndex = 0;
            this._labelSeleccion.Text = "Seleccione una caja:";
            // 
            // _ventanaSeleccionCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._labelSeleccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_ventanaSeleccionCaja";
            this.Text = "Selección de Caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelSeleccion;
    }
}