namespace lifo_y_fifo
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbCola = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.txtgAgregarCola = new System.Windows.Forms.TextBox();
            this.btnPrimerElementoCola = new System.Windows.Forms.Button();
            this.btnAgregarCola = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuitaCola = new System.Windows.Forms.Button();
            this.gbPila = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgregarPila = new System.Windows.Forms.TextBox();
            this.btnAgregarPila = new System.Windows.Forms.Button();
            this.btnQuitarPila = new System.Windows.Forms.Button();
            this.btnPrimerElementoPila = new System.Windows.Forms.Button();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCola.SuspendLayout();
            this.gbPila.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(658, 324);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 57);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbCola
            // 
            this.gbCola.Controls.Add(this.label2);
            this.gbCola.Controls.Add(this.lstCola);
            this.gbCola.Controls.Add(this.txtgAgregarCola);
            this.gbCola.Controls.Add(this.btnPrimerElementoCola);
            this.gbCola.Controls.Add(this.btnAgregarCola);
            this.gbCola.Controls.Add(this.label4);
            this.gbCola.Controls.Add(this.btnQuitaCola);
            this.gbCola.Location = new System.Drawing.Point(442, 27);
            this.gbCola.Name = "gbCola";
            this.gbCola.Size = new System.Drawing.Size(377, 277);
            this.gbCola.TabIndex = 20;
            this.gbCola.TabStop = false;
            this.gbCola.Text = "Group box Cola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingrese Cola";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(207, 65);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(164, 212);
            this.lstCola.TabIndex = 5;
            // 
            // txtgAgregarCola
            // 
            this.txtgAgregarCola.Location = new System.Drawing.Point(88, 25);
            this.txtgAgregarCola.Name = "txtgAgregarCola";
            this.txtgAgregarCola.Size = new System.Drawing.Size(100, 20);
            this.txtgAgregarCola.TabIndex = 6;
            // 
            // btnPrimerElementoCola
            // 
            this.btnPrimerElementoCola.Location = new System.Drawing.Point(9, 177);
            this.btnPrimerElementoCola.Name = "btnPrimerElementoCola";
            this.btnPrimerElementoCola.Size = new System.Drawing.Size(170, 23);
            this.btnPrimerElementoCola.TabIndex = 13;
            this.btnPrimerElementoCola.Text = "Primer elemento Cola";
            this.btnPrimerElementoCola.UseVisualStyleBackColor = true;
            this.btnPrimerElementoCola.Click += new System.EventHandler(this.btnPrimerElementoCola_Click);
            // 
            // btnAgregarCola
            // 
            this.btnAgregarCola.Location = new System.Drawing.Point(9, 80);
            this.btnAgregarCola.Name = "btnAgregarCola";
            this.btnAgregarCola.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCola.TabIndex = 7;
            this.btnAgregarCola.Text = "Agregar Cola";
            this.btnAgregarCola.UseVisualStyleBackColor = true;
            this.btnAgregarCola.Click += new System.EventHandler(this.btnAgregarCola_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(212, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "FIFO - Cola";
            // 
            // btnQuitaCola
            // 
            this.btnQuitaCola.Location = new System.Drawing.Point(113, 80);
            this.btnQuitaCola.Name = "btnQuitaCola";
            this.btnQuitaCola.Size = new System.Drawing.Size(75, 41);
            this.btnQuitaCola.TabIndex = 9;
            this.btnQuitaCola.Text = "Quitar  de la Cola";
            this.btnQuitaCola.UseVisualStyleBackColor = true;
            this.btnQuitaCola.Click += new System.EventHandler(this.btnQuitaCola_Click);
            // 
            // gbPila
            // 
            this.gbPila.Controls.Add(this.label1);
            this.gbPila.Controls.Add(this.txtAgregarPila);
            this.gbPila.Controls.Add(this.btnAgregarPila);
            this.gbPila.Controls.Add(this.btnQuitarPila);
            this.gbPila.Controls.Add(this.btnPrimerElementoPila);
            this.gbPila.Controls.Add(this.lstPila);
            this.gbPila.Controls.Add(this.label3);
            this.gbPila.Location = new System.Drawing.Point(12, 24);
            this.gbPila.Name = "gbPila";
            this.gbPila.Size = new System.Drawing.Size(371, 294);
            this.gbPila.TabIndex = 19;
            this.gbPila.TabStop = false;
            this.gbPila.Text = "Group Box Pila";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese Pila";
            // 
            // txtAgregarPila
            // 
            this.txtAgregarPila.Location = new System.Drawing.Point(74, 24);
            this.txtAgregarPila.Name = "txtAgregarPila";
            this.txtAgregarPila.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarPila.TabIndex = 0;
            // 
            // btnAgregarPila
            // 
            this.btnAgregarPila.Location = new System.Drawing.Point(3, 80);
            this.btnAgregarPila.Name = "btnAgregarPila";
            this.btnAgregarPila.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPila.TabIndex = 1;
            this.btnAgregarPila.Text = "Agregar Pila";
            this.btnAgregarPila.UseVisualStyleBackColor = true;
            this.btnAgregarPila.Click += new System.EventHandler(this.btnAgregarPila_Click);
            // 
            // btnQuitarPila
            // 
            this.btnQuitarPila.Location = new System.Drawing.Point(97, 80);
            this.btnQuitarPila.Name = "btnQuitarPila";
            this.btnQuitarPila.Size = new System.Drawing.Size(86, 49);
            this.btnQuitarPila.TabIndex = 3;
            this.btnQuitarPila.Text = "Quitar  de la Pila";
            this.btnQuitarPila.UseVisualStyleBackColor = true;
            this.btnQuitarPila.Click += new System.EventHandler(this.btnQuitarPila_Click);
            // 
            // btnPrimerElementoPila
            // 
            this.btnPrimerElementoPila.Location = new System.Drawing.Point(3, 180);
            this.btnPrimerElementoPila.Name = "btnPrimerElementoPila";
            this.btnPrimerElementoPila.Size = new System.Drawing.Size(171, 23);
            this.btnPrimerElementoPila.TabIndex = 12;
            this.btnPrimerElementoPila.Text = "Primer elemento Pila";
            this.btnPrimerElementoPila.UseVisualStyleBackColor = true;
            this.btnPrimerElementoPila.Click += new System.EventHandler(this.btnPrimerElementoPila_Click);
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(189, 58);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(153, 212);
            this.lstPila.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(228, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "LIFO - Pila";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 402);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbCola);
            this.Controls.Add(this.gbPila);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCola.ResumeLayout(false);
            this.gbCola.PerformLayout();
            this.gbPila.ResumeLayout(false);
            this.gbPila.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbCola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.TextBox txtgAgregarCola;
        private System.Windows.Forms.Button btnPrimerElementoCola;
        private System.Windows.Forms.Button btnAgregarCola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuitaCola;
        private System.Windows.Forms.GroupBox gbPila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgregarPila;
        private System.Windows.Forms.Button btnAgregarPila;
        private System.Windows.Forms.Button btnQuitarPila;
        private System.Windows.Forms.Button btnPrimerElementoPila;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.Label label3;
    }
}

