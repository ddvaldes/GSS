using System;

namespace PruebaSeleccion_GSS
{
    partial class Alquiler
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
            this.SALD = new System.Windows.Forms.TextBox();
            this.MARCA = new System.Windows.Forms.TextBox();
            this.PLACA = new System.Windows.Forms.TextBox();
            this.NOMBRE = new System.Windows.Forms.TextBox();
            this.CEDULA = new System.Windows.Forms.TextBox();
            this.TIEMPO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SALDO = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MOSTRAR = new System.Windows.Forms.Button();
            this.FECHA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SALD
            // 
            this.SALD.Location = new System.Drawing.Point(112, 232);
            this.SALD.Name = "SALD";
            this.SALD.Size = new System.Drawing.Size(100, 20);
            this.SALD.TabIndex = 0;
            // 
            // MARCA
            // 
            this.MARCA.Location = new System.Drawing.Point(546, 232);
            this.MARCA.Name = "MARCA";
            this.MARCA.Size = new System.Drawing.Size(100, 20);
            this.MARCA.TabIndex = 1;
            // 
            // PLACA
            // 
            this.PLACA.Location = new System.Drawing.Point(333, 232);
            this.PLACA.Name = "PLACA";
            this.PLACA.Size = new System.Drawing.Size(100, 20);
            this.PLACA.TabIndex = 2;
            // 
            // NOMBRE
            // 
            this.NOMBRE.Location = new System.Drawing.Point(261, 146);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(100, 20);
            this.NOMBRE.TabIndex = 3;
            // 
            // CEDULA
            // 
            this.CEDULA.Location = new System.Drawing.Point(31, 146);
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.Size = new System.Drawing.Size(100, 20);
            this.CEDULA.TabIndex = 4;
            // 
            // TIEMPO
            // 
            this.TIEMPO.Location = new System.Drawing.Point(470, 146);
            this.TIEMPO.Name = "TIEMPO";
            this.TIEMPO.Size = new System.Drawing.Size(100, 20);
            this.TIEMPO.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(333, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ALQUILER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CEDULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TIEMPO ALQUILADO";
            // 
            // SALDO
            // 
            this.SALDO.AutoSize = true;
            this.SALDO.Location = new System.Drawing.Point(140, 205);
            this.SALDO.Name = "SALDO";
            this.SALDO.Size = new System.Drawing.Size(43, 13);
            this.SALDO.TabIndex = 12;
            this.SALDO.Text = "SALDO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "PLACA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "MARCA";
            // 
            // MOSTRAR
            // 
            this.MOSTRAR.Location = new System.Drawing.Point(358, 296);
            this.MOSTRAR.Name = "MOSTRAR";
            this.MOSTRAR.Size = new System.Drawing.Size(75, 23);
            this.MOSTRAR.TabIndex = 15;
            this.MOSTRAR.Text = "MOSTRAR";
            this.MOSTRAR.UseVisualStyleBackColor = true;
            this.MOSTRAR.Click += new System.EventHandler(this.MOSTRAR_Click);
            // 
            // FECHA
            // 
            this.FECHA.Location = new System.Drawing.Point(669, 146);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(100, 20);
            this.FECHA.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "FECHA ALQUILER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "SIGUIENTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FECHA);
            this.Controls.Add(this.MOSTRAR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SALDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TIEMPO);
            this.Controls.Add(this.CEDULA);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.PLACA);
            this.Controls.Add(this.MARCA);
            this.Controls.Add(this.SALD);
            this.Name = "Alquiler";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SALD;
        private System.Windows.Forms.TextBox MARCA;
        private System.Windows.Forms.TextBox PLACA;
        private System.Windows.Forms.TextBox NOMBRE;
        private System.Windows.Forms.TextBox CEDULA;
        private System.Windows.Forms.TextBox TIEMPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SALDO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button MOSTRAR;
        private EventHandler label2_Click;
        private EventHandler textBox5_TextChanged;
        private System.Windows.Forms.TextBox FECHA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;

        public EventHandler Form1_Load { get; private set; }
    }
}

