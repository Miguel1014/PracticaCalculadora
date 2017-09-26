using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PracticaCalculadora
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            LPrin.Text = "0";
            
        }


        public void EvtIgual(object sender, EventArgs e)
        {
            char primero = LPrin.Text[0];

            

            if (primero.Equals("-"))
            {

                LPrin.Text = "0";
            }
            else
            if (LPrin.Text.Equals(""))
            {
                LPrin.Text = "0";
            }
            else
            {

                string operacion = LPrin.Text;
                int tam = operacion.Length;
                string[] A = new string[100];
                string[] operaciones = new string[100];
                int pos = 0;
                double sum = 0;
                String aux = "";
                operaciones[0] = "+";
                int index_operacion = 1;
                for (int i = 0; i < tam; i++)
                {
                    if (operacion[i] == '+' || operacion[i] == '-' || operacion[i] == 'x' || operacion[i] == '÷')
                    {
                        A[pos] = aux;
                        operaciones[index_operacion] = Convert.ToString(operacion[i]);
                        pos++;
                        index_operacion++;
                        aux = "";
                    }
                    else
                    {
                        aux = aux + operacion[i];
                    }
                }
                A[pos] = aux;
                pos++;

                for (int i = 0; i < pos; i++)
                {
                    if (operaciones[i].Equals("+"))
                    {

                        sum = sum + Convert.ToDouble(A[i]);
                    }
                    else if (operaciones[i].Equals("-"))
                    {
                        sum = sum - Convert.ToDouble(A[i]);
                    }
                    else if (operaciones[i].Equals("x"))
                    {
                        sum = sum * Convert.ToDouble(A[i]);
                    }
                    else if (operaciones[i].Equals("÷"))
                    {
                        sum = sum / Convert.ToDouble(A[i]);
                    }
                    LPrin.Text = ("" + sum);
                }
            }
        }












        private void EvtDiv(object sender, EventArgs e)
        {

            
            string ultimo = LPrin.Text.Substring(LPrin.Text.Length - 1);


           
             if (ultimo.Equals("x"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "÷";
             }else if(ultimo.Equals("+"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "÷";
            }
            else if (ultimo.Equals("-"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "÷";
            }
            else if (ultimo.Equals("÷"))
            {
            } else if (LPrin.Text.Equals("0"))
            {
             LPrin.Text = LPrin.Text + "÷";
            }
            else
            {
                LPrin.Text = LPrin.Text + "÷";   
            }




        }
        private void EvtMul(object sender, EventArgs e)
        {
            string ultimo = LPrin.Text.Substring(LPrin.Text.Length - 1);
            if (ultimo.Equals("÷"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "x";
            }
            else if(ultimo.Equals("+"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "x";
            }
            else if (ultimo.Equals("-"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "x";
            }

            else if (ultimo.Equals("x"))
            {
            }
            else if (LPrin.Text.Equals("0"))
            {
                LPrin.Text = LPrin.Text + "x";
            }
            else
            {
                LPrin.Text = LPrin.Text + "x";
            }

        }

        private void EvtMas(object sender, EventArgs e)
        {

            string ultimo = LPrin.Text.Substring(LPrin.Text.Length - 1);
            if (ultimo.Equals("÷"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "+";
            }
            else if (ultimo.Equals("+"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "+";
            }
            else if (ultimo.Equals("-"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "+";
            }

            else if (ultimo.Equals("x"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "+";
            }
            else if (LPrin.Text.Equals("0"))
            {
                LPrin.Text = LPrin.Text + "+";
            }
            else
            {
                LPrin.Text = LPrin.Text + "+";
            }


        }
        private void EvtRes(object sender, EventArgs e)
        {
            string ultimo = LPrin.Text.Substring(LPrin.Text.Length - 1);
            if (ultimo.Equals("÷"))
            {
                
                LPrin.Text = LPrin.Text + "-";
            }
            else if (ultimo.Equals("+"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "-";
            }
            else if (ultimo.Equals("-"))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text + "-";
            }

            else if (ultimo.Equals("x"))
            {
                
                LPrin.Text = LPrin.Text + "-";
            }
            else if (LPrin.Text.Equals("0"))
            {
                LPrin.Text = "0-";
            }
            else
            {
                LPrin.Text = LPrin.Text + "-";
            }
        }




        private void EvtBorrar(object sender, EventArgs e)
        {

          

            
            if (LPrin.Text.Length==1)
            {
                LPrin.Text = "0";
            }
            else
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
               
            }

           

           

        }



        private void Evt7(object sender, EventArgs e)
        {
            string cero = LPrin.Text.Substring(0);
            if (cero.Equals("0"))
            {
                LPrin.Text = "7";
            }
            else
            {
                LPrin.Text = LPrin.Text + "7";
            }

           
           
            
          



    }
        private void Evt4(object sender, EventArgs e)
        {
            string cero = LPrin.Text.Substring(0);
            if (cero.Equals("0"))
            {
                LPrin.Text = "4";
            }
            else
            {
                LPrin.Text = LPrin.Text + "4";
            }
        }
        private void Evt1(object sender, EventArgs e)
        {
            string cero = LPrin.Text.Substring(0);
            if (cero.Equals("0"))
            {
                LPrin.Text = "1";
            }
            else
            {
                LPrin.Text = LPrin.Text + "1";
            }
        }
        private void Evt0(object sender, EventArgs e)
        {



            /* else if (LPrin.Text[1].Equals("."))
            {
                LPrin.Text = LPrin.Text + "0";
            }*/
           
            
            string b = LPrin.Text.Substring(0);

            if (b.Equals("0"))
            {
                
            }
           
            else
            {
               
                LPrin.Text = LPrin.Text + "0";
            }
        


        }


        private void Evt8(object sender, EventArgs e)
        {

            string cero = LPrin.Text.Substring(0);
            if (cero.Equals("0"))
            {
                LPrin.Text = "8";
            }
            else { 
            LPrin.Text = LPrin.Text + "8";
            }


            
        }
        private void Evt5(object sender, EventArgs e)
        {
            string cero = LPrin.Text.Substring(0);
            if (cero.Equals("0"))
            {
                LPrin.Text = "5";
            }
            else
            {
                LPrin.Text = LPrin.Text + "5";
            }
        }
        private void Evt2(object sender, EventArgs e)
        {
            string cero = LPrin.Text.Substring(0);
            if (cero.Equals("0"))
            {
                LPrin.Text = "2";
            }
            else
            {
                LPrin.Text = LPrin.Text + "2";
            }
        }



        private void EvtPunto(object sender, EventArgs e)
        {



            string ultimo = LPrin.Text.Substring(LPrin.Text.Length - 1);
            if (ultimo.Equals("÷"))
            {

                LPrin.Text = LPrin.Text + "0";
            }
            else if (ultimo.Equals("+"))
            {
                
                LPrin.Text = LPrin.Text + "0.";
            }
            else if (ultimo.Equals("-"))
            {
                
                LPrin.Text = LPrin.Text + "0.";
            }

            else if (ultimo.Equals("x"))
            {

                LPrin.Text = LPrin.Text + "0.";
            }
            else if (ultimo.Equals("0"))
            {
                LPrin.Text = "0.";
            }
            else if (ultimo.Equals("."))
            {
                LPrin.Text = LPrin.Text.Substring(0, LPrin.Text.Length - 1);
                LPrin.Text = LPrin.Text=("0.");
            }
            else
            {
                LPrin.Text = LPrin.Text = (".");
            }

        }



        private void Evt9(object sender, EventArgs e)
        {
            string cero = LPrin.Text.Substring(0);
            if (cero.Equals("0"))
            {
                LPrin.Text = "9";
            }
            else
            {
                LPrin.Text = LPrin.Text + "9";
            }
        }
        private void Evt6(object sender, EventArgs e)
        {
            string cero = LPrin.Text.Substring(0);
            if (cero.Equals("0"))
            {
                LPrin.Text = "6";
            }
            else
            {
                LPrin.Text = LPrin.Text + "6";
            }
        }
        private void Evt3(object sender, EventArgs e)
        {
            string cero = LPrin.Text.Substring(0);
            if (cero.Equals("0"))
            {
                LPrin.Text = "3";
            }
            else
            {
                LPrin.Text = LPrin.Text + "3";
            }
        }
        





    }
}
