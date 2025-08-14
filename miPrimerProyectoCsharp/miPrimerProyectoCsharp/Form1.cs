﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta=0;
            num1 = Double.Parse( txtnum1.Text);
            num2 = double.Parse(txtnum2.Text);

            if( optSuma.Checked){
                respuesta = num1 + num2;
            }
            if (optResta.Checked) {
                respuesta = num1 - num2;
            }
            if (optMultiplicacion.Checked) {
                respuesta = num1 * num2;
            }
            if (optDivision.Checked) {
                respuesta = num1 / num2;
            }
            if (optExponente.Checked) {
                respuesta = Math.Pow(num1, num2);
            }
            if (optFactorial.Checked) {
                respuesta = (int)num1;
                for (int i=(int)num1 - 1; i>1; i--) { //5!=5*4*3*2=120
                    respuesta *= i;
                }
            }
            lblrespuesta.Text = "Respuesta: " + respuesta;

            if (optPrimo.Checked){
                int i = 1, acum=0;
                while (i <= num1 && acum<3) {
                    if( num1%i==0) {
                        acum++; //acum = acum + 1;
                    }
                    i++;
                }
                if (acum <= 2) {
                    lblrespuesta.Text = "Respuesta: "+ num1 + " es primo";
                } else {
                    lblrespuesta.Text = "Respuesta: "+ num1 + " NO es primo";
                }
            }
            //Porcentaje.
            //Factorial. 5! = 5x4x3x2x1=120
            //Modulo.
        }

        private void btnCalcularOpciones_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txtnum1.Text);
            num2 = double.Parse(txtnum2.Text);

            switch (cboOpciones.SelectedIndex) {
                case 0:
                    respuesta = num1 + num2;
                    break;
                case 1:
                    respuesta = num1 - num2;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    break;
                case 3:
                    respuesta = num1 / num2;
                    break;
            }
            lblrespuesta.Text = "Respuesta: " + respuesta;
        }
    }
}
