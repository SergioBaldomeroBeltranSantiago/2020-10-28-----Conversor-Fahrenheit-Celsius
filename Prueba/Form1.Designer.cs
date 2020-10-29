namespace Prueba
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
            this.conversorFahrenheitCelsius1 = new _2020_10_28_____Conversor_Fahrenheit_Celsius.ConversorFahrenheitCelsius();
            this.SuspendLayout();
            // 
            // conversorFahrenheitCelsius1
            // 
            this.conversorFahrenheitCelsius1.Location = new System.Drawing.Point(8, 12);
            this.conversorFahrenheitCelsius1.Name = "conversorFahrenheitCelsius1";
            this.conversorFahrenheitCelsius1.Size = new System.Drawing.Size(198, 177);
            this.conversorFahrenheitCelsius1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 219);
            this.Controls.Add(this.conversorFahrenheitCelsius1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private _2020_10_28_____Conversor_Fahrenheit_Celsius.ConversorFahrenheitCelsius conversorFahrenheitCelsius1;
    }
}

