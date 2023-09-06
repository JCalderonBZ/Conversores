
namespace Parcial_1
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblValorAPagarImpuesto = new System.Windows.Forms.Label();
            this.txtCantidadImpuesto = new System.Windows.Forms.TextBox();
            this.btnCalcularImpuesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(604, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Calculo de Impuesto a las Actividades Economicas";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 75);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(124, 29);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblValorAPagarImpuesto
            // 
            this.lblValorAPagarImpuesto.AutoSize = true;
            this.lblValorAPagarImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAPagarImpuesto.Location = new System.Drawing.Point(12, 135);
            this.lblValorAPagarImpuesto.Name = "lblValorAPagarImpuesto";
            this.lblValorAPagarImpuesto.Size = new System.Drawing.Size(244, 29);
            this.lblValorAPagarImpuesto.TabIndex = 2;
            this.lblValorAPagarImpuesto.Text = "El Valor a Pagar es:";
            // 
            // txtCantidadImpuesto
            // 
            this.txtCantidadImpuesto.Location = new System.Drawing.Point(142, 82);
            this.txtCantidadImpuesto.Name = "txtCantidadImpuesto";
            this.txtCantidadImpuesto.Size = new System.Drawing.Size(129, 22);
            this.txtCantidadImpuesto.TabIndex = 3;
            // 
            // btnCalcularImpuesto
            // 
            this.btnCalcularImpuesto.Location = new System.Drawing.Point(318, 75);
            this.btnCalcularImpuesto.Name = "btnCalcularImpuesto";
            this.btnCalcularImpuesto.Size = new System.Drawing.Size(140, 37);
            this.btnCalcularImpuesto.TabIndex = 4;
            this.btnCalcularImpuesto.Text = "Calcular";
            this.btnCalcularImpuesto.UseVisualStyleBackColor = true;
            this.btnCalcularImpuesto.Click += new System.EventHandler(this.btnCalcularImpuesto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 181);
            this.Controls.Add(this.btnCalcularImpuesto);
            this.Controls.Add(this.txtCantidadImpuesto);
            this.Controls.Add(this.lblValorAPagarImpuesto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblValorAPagarImpuesto;
        private System.Windows.Forms.TextBox txtCantidadImpuesto;
        private System.Windows.Forms.Button btnCalcularImpuesto;
    }
}

