namespace miPrimerProyectoCsharp {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.optExponente = new System.Windows.Forms.RadioButton();
            this.optDivision = new System.Windows.Forms.RadioButton();
            this.optMultiplicacion = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.btnCalcularOpciones = new System.Windows.Forms.Button();
            this.optPrimo = new System.Windows.Forms.RadioButton();
            this.optFactorial = new System.Windows.Forms.RadioButton();
            this.grbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(67, 23);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 0;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(26, 26);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(41, 13);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "Num 1:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(41, 145);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(115, 52);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(26, 63);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(41, 13);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "Num 2:";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(67, 60);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 3;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(26, 116);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(70, 13);
            this.lblrespuesta.TabIndex = 5;
            this.lblrespuesta.Text = "Respuesta: ?";
            // 
            // grbOpciones
            // 
            this.grbOpciones.Controls.Add(this.optFactorial);
            this.grbOpciones.Controls.Add(this.optPrimo);
            this.grbOpciones.Controls.Add(this.optExponente);
            this.grbOpciones.Controls.Add(this.optDivision);
            this.grbOpciones.Controls.Add(this.optMultiplicacion);
            this.grbOpciones.Controls.Add(this.optResta);
            this.grbOpciones.Controls.Add(this.optSuma);
            this.grbOpciones.Location = new System.Drawing.Point(173, 23);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(117, 201);
            this.grbOpciones.TabIndex = 6;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // optExponente
            // 
            this.optExponente.AutoSize = true;
            this.optExponente.Location = new System.Drawing.Point(16, 114);
            this.optExponente.Name = "optExponente";
            this.optExponente.Size = new System.Drawing.Size(70, 17);
            this.optExponente.TabIndex = 4;
            this.optExponente.Text = "Expoente";
            this.optExponente.UseVisualStyleBackColor = true;
            // 
            // optDivision
            // 
            this.optDivision.AutoSize = true;
            this.optDivision.Location = new System.Drawing.Point(16, 91);
            this.optDivision.Name = "optDivision";
            this.optDivision.Size = new System.Drawing.Size(62, 17);
            this.optDivision.TabIndex = 3;
            this.optDivision.Text = "Division";
            this.optDivision.UseVisualStyleBackColor = true;
            // 
            // optMultiplicacion
            // 
            this.optMultiplicacion.AutoSize = true;
            this.optMultiplicacion.Location = new System.Drawing.Point(16, 66);
            this.optMultiplicacion.Name = "optMultiplicacion";
            this.optMultiplicacion.Size = new System.Drawing.Size(89, 17);
            this.optMultiplicacion.TabIndex = 2;
            this.optMultiplicacion.Text = "Multiplicacion";
            this.optMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(16, 43);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(53, 17);
            this.optResta.TabIndex = 1;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Checked = true;
            this.optSuma.Location = new System.Drawing.Point(16, 20);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(52, 17);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // cboOpciones
            // 
            this.cboOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division",
            "Primo",
            "Factorial"});
            this.cboOpciones.Location = new System.Drawing.Point(298, 26);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(121, 21);
            this.cboOpciones.TabIndex = 7;
            // 
            // btnCalcularOpciones
            // 
            this.btnCalcularOpciones.Location = new System.Drawing.Point(296, 66);
            this.btnCalcularOpciones.Name = "btnCalcularOpciones";
            this.btnCalcularOpciones.Size = new System.Drawing.Size(115, 52);
            this.btnCalcularOpciones.TabIndex = 8;
            this.btnCalcularOpciones.Text = "Calcular";
            this.btnCalcularOpciones.UseVisualStyleBackColor = true;
            this.btnCalcularOpciones.Click += new System.EventHandler(this.btnCalcularOpciones_Click);
            // 
            // optPrimo
            // 
            this.optPrimo.AutoSize = true;
            this.optPrimo.Location = new System.Drawing.Point(16, 140);
            this.optPrimo.Name = "optPrimo";
            this.optPrimo.Size = new System.Drawing.Size(51, 17);
            this.optPrimo.TabIndex = 5;
            this.optPrimo.Text = "Primo";
            this.optPrimo.UseVisualStyleBackColor = true;
            // 
            // optFactorial
            // 
            this.optFactorial.AutoSize = true;
            this.optFactorial.Location = new System.Drawing.Point(16, 163);
            this.optFactorial.Name = "optFactorial";
            this.optFactorial.Size = new System.Drawing.Size(65, 17);
            this.optFactorial.TabIndex = 6;
            this.optFactorial.Text = "Factorial";
            this.optFactorial.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 269);
            this.Controls.Add(this.btnCalcularOpciones);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.grbOpciones);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbOpciones.ResumeLayout(false);
            this.grbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.RadioButton optDivision;
        private System.Windows.Forms.RadioButton optMultiplicacion;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
        private System.Windows.Forms.RadioButton optExponente;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.Button btnCalcularOpciones;
        private System.Windows.Forms.RadioButton optFactorial;
        private System.Windows.Forms.RadioButton optPrimo;
    }
}

