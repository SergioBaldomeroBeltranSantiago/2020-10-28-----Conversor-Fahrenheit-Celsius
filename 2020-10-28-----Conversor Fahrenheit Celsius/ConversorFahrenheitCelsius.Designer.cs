namespace _2020_10_28_____Conversor_Fahrenheit_Celsius
{
    partial class ConversorFahrenheitCelsius
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CeToFa = new System.Windows.Forms.RadioButton();
            this.FaToCe = new System.Windows.Forms.RadioButton();
            this.UserDisplay = new System.Windows.Forms.TextBox();
            this.Doer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CeToFa);
            this.groupBox1.Controls.Add(this.FaToCe);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convertir";
            // 
            // CeToFa
            // 
            this.CeToFa.AutoSize = true;
            this.CeToFa.Location = new System.Drawing.Point(6, 49);
            this.CeToFa.Name = "CeToFa";
            this.CeToFa.Size = new System.Drawing.Size(148, 24);
            this.CeToFa.TabIndex = 4;
            this.CeToFa.TabStop = true;
            this.CeToFa.Text = "Celsius a Fahrenheit";
            this.CeToFa.UseVisualStyleBackColor = true;
            // 
            // FaToCe
            // 
            this.FaToCe.AutoSize = true;
            this.FaToCe.Location = new System.Drawing.Point(6, 19);
            this.FaToCe.Name = "FaToCe";
            this.FaToCe.Size = new System.Drawing.Size(148, 24);
            this.FaToCe.TabIndex = 3;
            this.FaToCe.TabStop = true;
            this.FaToCe.Text = "Fahrenheit a Celsius";
            this.FaToCe.UseVisualStyleBackColor = true;
            // 
            // UserDisplay
            // 
            this.UserDisplay.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDisplay.Location = new System.Drawing.Point(19, 15);
            this.UserDisplay.Name = "UserDisplay";
            this.UserDisplay.Size = new System.Drawing.Size(148, 26);
            this.UserDisplay.TabIndex = 1;
            // 
            // Doer
            // 
            this.Doer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doer.Location = new System.Drawing.Point(19, 127);
            this.Doer.Name = "Doer";
            this.Doer.Size = new System.Drawing.Size(148, 29);
            this.Doer.TabIndex = 2;
            this.Doer.Text = "Convertir";
            this.Doer.UseVisualStyleBackColor = true;
            this.Doer.Click += new System.EventHandler(this.Doer_Click);
            // 
            // ConversorFahrenheitCelsius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Doer);
            this.Controls.Add(this.UserDisplay);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConversorFahrenheitCelsius";
            this.Size = new System.Drawing.Size(198, 177);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CeToFa;
        private System.Windows.Forms.RadioButton FaToCe;
        private System.Windows.Forms.TextBox UserDisplay;
        private System.Windows.Forms.Button Doer;
    }
}
