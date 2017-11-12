using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saber_si_son_pares{

    class Program{

        static void Main(string[] args){


            string Numero = "", Numero2 = "";

            Console.WriteLine("Escriba un numero de dos cifras o dos numeros");

            Numero = Console.ReadLine();

            Console.WriteLine();

            if (Numero.Length != 2) { //Si no tiene 2 digitos

                Console.WriteLine("Debe digitar un numero de dos crifras o dos numeros para poder continuar");
            }
            else { 
                    //caso contrario

                for (int index = 0; index <= Numero.Length - 1; index += 1){                       

                    double Numeros = double.Parse(Numero.Substring(index, 1));


                    Numeros = (Numeros / 2);
                    Numero2 += Numeros.ToString();
                }

                //Si contiene uno de esos caracteres es porque es negativo
                if (Numero2.Contains(".") || Numero2.Contains(",")){

                    Console.WriteLine("Entre los digitos introducidos existe uno o ambos que son impares");
                }

                else{
                    Console.WriteLine("Escribio digitos que son pares");
                }
            }
            Console.ReadKey();
        }
    }
}
