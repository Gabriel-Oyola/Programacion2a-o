using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FechaTarea
{
    public partial class Fecha : Form
    {
        public Fecha()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            // aqui es donde se van a guardar los valores que ingresemos en los textbox para posteriormente utilizarlos
            int dia = Convert.ToInt32(txtDia.Text);
            int mes = Convert.ToInt32(txtMes.Text);
            int año = Convert.ToInt32(txtAño.Text);

            //declaramos una variable mesString para guardar el mes en formato de texto segun sea valor de la variable mes 
            string mesString= "";
            
            //declaramos una variable diasFebrero en la cual guardaremos la cantidad de dias
            //de fabreros segun sea un año bisiesto o no
            int diasFebrero = 0;

            //declaramos variables booleanas para validar si todos los datos ingresados son correctos
            // a DiaValido le daremos valor inicial false y posteriormente se lo cambiaremos a true si 
            //esta dentro del rango de dias que le corresponda al mes 
            bool diaValido = false;
            bool MesValido = mes <=12;
            bool AñoValido = año <=2022; 

            //comprobamos el si el año es bisiesto o no para asignarle la cantidad de dias a febrero
            if (año%4 == 0)
            {
               diasFebrero = 29; 
            }
            else
            {
                diasFebrero = 28;
            }


            //validamos que el año sea correcto 

            if (año <= 2022)
            {
                //segun el entero de mes se va ejecutar cual corresponda y se modificara el valor de las variables
                // mesString y diaValido 
                switch (mes)
                {
                    case 1:
                        if(dia> 0 && dia<= 31)
                        {
                            mesString = "Enero";
                            diaValido= true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        
                        break;
                    case 2:
                       
                        if(dia > 0 && dia <= diasFebrero)
                        {
                            mesString = "Febrero";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;
                    case 3:
                        if (dia > 0 && dia <= 31)
                        {
                            mesString = "Marzo";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;
                    case 4:
                       
                        if (dia > 0 && dia <= 30)
                        {
                            mesString = "Abril";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;
                    case 5:
                        if (dia > 0 && dia <= 31)
                        {
                            mesString = "Mayo";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;
                    case 6:
                        if (dia > 0 && dia <= 30)
                        {
                            mesString = "Junio";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;
                    case 7:
                        if (dia > 0 && dia <= 31)
                        {
                            mesString = "Julio";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;
                    case 8:
                        if (dia > 0 && dia <= 31)
                        {
                            mesString = "Agosto";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;
                    case 9:
                        if (dia > 0 && dia <= 30)
                        {
                            mesString = "Septiembre";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;
                    case 10:
                        if (dia > 0 && dia <= 31)
                        {
                            mesString = "Octubre";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;
                    case 11:
                        if (dia > 0 && dia<= 30)
                        {
                            mesString = "Noviembre";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;
                    case 12:
                        if (dia > 0 && dia <= 31)
                        {
                            mesString = "Diciembre";
                            diaValido = true;
                        }
                        else
                        {
                            MessageBox.Show("Dia invalido");
                        }
                        break;


                    default:
                        MessageBox.Show("Mes Invalido");

                        break;
                }

                //comprobamos si todos los datos son correctos y se ejecuta el messageBox con la fecha.
                if (diaValido && MesValido && AñoValido)
                {
                    MessageBox.Show(dia + " de " + mesString + " de " + año);
                }
                else
                {
                    MessageBox.Show("Intente de nuevo, dia o mes o año invalido");
                }
                
                
            }
            else
            {
                MessageBox.Show("Año invalido"); 
            }
           

           
        }
    }
}
