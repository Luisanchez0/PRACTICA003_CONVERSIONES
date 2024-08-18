
namespace PRACTICA003_CONVERSIONES
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
            this.lb_Farenheit = new System.Windows.Forms.Label();
            this.lb_Celcius = new System.Windows.Forms.Label();
            this.tbFarenheit = new System.Windows.Forms.TextBox();
            this.tbCelcius = new System.Windows.Forms.TextBox();
            this.lbtitle = new System.Windows.Forms.Label();
            this.btCelFar = new System.Windows.Forms.Button();
            this.btFarCel = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Farenheit
            // 
            this.lb_Farenheit.AutoSize = true;
            this.lb_Farenheit.Location = new System.Drawing.Point(402, 123);
            this.lb_Farenheit.Name = "lb_Farenheit";
            this.lb_Farenheit.Size = new System.Drawing.Size(117, 13);
            this.lb_Farenheit.TabIndex = 0;
            this.lb_Farenheit.Text = "GRADOS FARENHEIT";
            this.lb_Farenheit.Click += new System.EventHandler(this.lb_Farenheit_Click);
            // 
            // lb_Celcius
            // 
            this.lb_Celcius.AutoSize = true;
            this.lb_Celcius.Location = new System.Drawing.Point(56, 123);
            this.lb_Celcius.Name = "lb_Celcius";
            this.lb_Celcius.Size = new System.Drawing.Size(101, 13);
            this.lb_Celcius.TabIndex = 1;
            this.lb_Celcius.Text = "GRADOS CELCIUS";
            this.lb_Celcius.Click += new System.EventHandler(this.lb_Celcius_Click);
            // 
            // tbFarenheit
            // 
            this.tbFarenheit.Location = new System.Drawing.Point(405, 155);
            this.tbFarenheit.Name = "tbFarenheit";
            this.tbFarenheit.Size = new System.Drawing.Size(100, 20);
            this.tbFarenheit.TabIndex = 2;
            this.tbFarenheit.TextChanged += new System.EventHandler(this.tbFarenheit_TextChanged);
            // 
            // tbCelcius
            // 
            this.tbCelcius.Location = new System.Drawing.Point(57, 155);
            this.tbCelcius.Name = "tbCelcius";
            this.tbCelcius.Size = new System.Drawing.Size(100, 20);
            this.tbCelcius.TabIndex = 3;
            this.tbCelcius.TextChanged += new System.EventHandler(this.tbCelcius_TextChanged);
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Location = new System.Drawing.Point(202, 38);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(178, 13);
            this.lbtitle.TabIndex = 4;
            this.lbtitle.Text = "CONVERSOR DE TEMPERATURA";
            // 
            // btCelFar
            // 
            this.btCelFar.Location = new System.Drawing.Point(70, 199);
            this.btCelFar.Name = "btCelFar";
            this.btCelFar.Size = new System.Drawing.Size(75, 46);
            this.btCelFar.TabIndex = 5;
            this.btCelFar.Text = "Celcius a Frenheit";
            this.btCelFar.UseVisualStyleBackColor = true;
            this.btCelFar.Click += new System.EventHandler(this.btCelFar_Click);
            // 
            // btFarCel
            // 
            this.btFarCel.Location = new System.Drawing.Point(415, 199);
            this.btFarCel.Name = "btFarCel";
            this.btFarCel.Size = new System.Drawing.Size(75, 46);
            this.btFarCel.TabIndex = 6;
            this.btFarCel.Text = "Farenheit a Celcius";
            this.btFarCel.UseVisualStyleBackColor = true;
            this.btFarCel.Click += new System.EventHandler(this.btFarCel_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(240, 222);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 7;
            this.btLimpiar.Text = "LIMPIAR ";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 340);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btFarCel);
            this.Controls.Add(this.btCelFar);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.tbCelcius);
            this.Controls.Add(this.tbFarenheit);
            this.Controls.Add(this.lb_Celcius);
            this.Controls.Add(this.lb_Farenheit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Farenheit;
        private System.Windows.Forms.Label lb_Celcius;
        private System.Windows.Forms.TextBox tbFarenheit;
        private System.Windows.Forms.TextBox tbCelcius;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Button btCelFar;
        private System.Windows.Forms.Button btFarCel;
        private System.Windows.Forms.Button btLimpiar;
    }
}

