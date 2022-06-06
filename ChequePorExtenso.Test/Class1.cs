using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.Test
{
    public class Actions
    {
        Dictionary<int, string> numeros = new Dictionary<int, string>();


        public Actions()
        {
            numeros.Add(1, "Um");
            numeros.Add(2, "Dois");
            numeros.Add(3, "Três");
            numeros.Add(4, "Quatro");
            numeros.Add(5, "Cinco");
            numeros.Add(6, "Seis");
            numeros.Add(7, "Sete");
            numeros.Add(8, "Oito");
            numeros.Add(9, "Nove");
            numeros.Add(10, "Dez");
            numeros.Add(11, "Onze");
            numeros.Add(12, "Doze");
            numeros.Add(13, "Treze");
            numeros.Add(14, "Quatorze");
            numeros.Add(15, "Quinze");
            numeros.Add(16, "Dezesseis");
            numeros.Add(17, "Dezessete");
            numeros.Add(18, "Dezoito");
            numeros.Add(19, "Dezenove");
            numeros.Add(20, "Vinte");
            numeros.Add(30, "Trinta");
            numeros.Add(40, "Quarenta");
            numeros.Add(50, "Cinquenta");
            numeros.Add(60, "Sessenta");
            numeros.Add(70, "Setenta");
            numeros.Add(80, "Oitenta");
            numeros.Add(90, "Noventa");
            numeros.Add(100, "Cento");
            numeros.Add(200, "Duzentos");
            numeros.Add(300, "Trezentos");
            numeros.Add(400, "Quatrocentos");
            numeros.Add(500, "Quinhentos");
            numeros.Add(600, "Seiscentos");
            numeros.Add(700, "Setecentos");
            numeros.Add(800, "Oitocentos");
            numeros.Add(900, "Novecentos");



        }


        public string Converter(int numero)
        {
            string numeroPorExtenso = "";
            string numeroString = numero.ToString();



            if (numero == 100)
                return "Cem";

            if (numero > 100)
            {
                //Pega centena
                int centena = Int32.Parse(numeroString.Substring(0, 1));
                centena = centena * 100;

                numeroPorExtenso += numeros[centena];

                numero -= centena;

                numeroPorExtenso += " e ";
                
                numeroString = numero.ToString();
            }
            //Pega Dezena

            if (numero > 20)
            {

                int dezena = Int32.Parse(numeroString.Substring(0, 1));
                dezena = dezena * 10;

                if (dezena != 0)
                {
   
                    numeroPorExtenso += numeros[dezena];

                    numero -= dezena;
                }


                numeroPorExtenso += " e ";
            }
                numeroPorExtenso += numeros[numero];
            


                return numeroPorExtenso;
            
        }
    }
}
