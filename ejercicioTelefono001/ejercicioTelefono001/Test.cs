using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioTelefono001
{
   [TestFixture]

   
    class Test 
    {
       
       
        [TestCase]

        public void Comercio() //test con resultado incorrecto
        {
            //arrange planteamiento

            string result = "";
            string input = "Comercio";
            string output = "333666 666022 2777";
            char[] letra2 = new char[3];
            letra2[0] = 'a';
            letra2[1] = 'b';
            letra2[2] = 'c';
            Pulsacion pulsacion = new Pulsacion(letra2, 2);
            char[] letra3 = new char[3];
            letra3[0] = 'd';
            letra3[1] = 'e';
            letra3[2] = 'f';
            Pulsacion pulsacion2 = new Pulsacion(letra3, 3);
            char[] letra4 = new char[3];
            letra4[0] = 'g';
            letra4[1] = 'h';
            letra4[2] = 'i';
            Pulsacion pulsacion3 = new Pulsacion(letra4, 4);
            char[] letra5 = new char[3];
            letra5[0] = 'j';
            letra5[1] = 'k';
            letra5[2] = 'l';
            Pulsacion pulsacion4 = new Pulsacion(letra5, 5);
            char[] letra6 = new char[3];
            letra6[0] = 'm';
            letra6[1] = 'n';
            letra6[2] = 'o';
            Pulsacion pulsacion5 = new Pulsacion(letra6, 6);
            char[] letra7 = new char[4];
            letra7[0] = 'p';
            letra7[1] = 'q';
            letra7[2] = 'r';
            letra7[3] = 's';
            Pulsacion pulsacion6 = new Pulsacion(letra7, 7);
            char[] letra8 = new char[3];
            letra8[0] = 't';
            letra8[1] = 'u';
            letra8[2] = 'v';
            Pulsacion pulsacion7 = new Pulsacion(letra8, 8);
            char[] letra9 = new char[4];
            letra9[0] = 'w';
            letra9[1] = 'x';
            letra9[2] = 'y';
            letra9[3] = 'z';
            Pulsacion pulsacion8 = new Pulsacion(letra9, 9);

            char[] letra0 = new char[1];
            letra0[0] = ' ';
            Pulsacion pulsacion9 = new Pulsacion(letra0, 0);

            List<Pulsacion> pulsaciones = new List<Pulsacion>();
            pulsaciones.Add(pulsacion);
            pulsaciones.Add(pulsacion2);
            pulsaciones.Add(pulsacion3);
            pulsaciones.Add(pulsacion4);
            pulsaciones.Add(pulsacion5);
            pulsaciones.Add(pulsacion6);
            pulsaciones.Add(pulsacion7);
            pulsaciones.Add(pulsacion8);
            pulsaciones.Add(pulsacion9);

           
            


            for (int i = 0; i < input.Length; i++)
            {
                foreach (var pls in pulsaciones)
                {
                    result = result + pls.BuscarChar(input[i]);
                }
            }
           

            //act o prueba



            
             //assert o Afirmacion
            Assert.AreEqual(output, result);
        }


        [TestCase]

        public void Hola() //test con resultado correcto
        {
            //arrange planteamiento

            string result = "";
            string input = "Hola";
            string output = "6665552";
            char[] letra2 = new char[3];
            letra2[0] = 'a';
            letra2[1] = 'b';
            letra2[2] = 'c';
            Pulsacion pulsacion = new Pulsacion(letra2, 2);
            char[] letra3 = new char[3];
            letra3[0] = 'd';
            letra3[1] = 'e';
            letra3[2] = 'f';
            Pulsacion pulsacion2 = new Pulsacion(letra3, 3);
            char[] letra4 = new char[3];
            letra4[0] = 'g';
            letra4[1] = 'h';
            letra4[2] = 'i';
            Pulsacion pulsacion3 = new Pulsacion(letra4, 4);
            char[] letra5 = new char[3];
            letra5[0] = 'j';
            letra5[1] = 'k';
            letra5[2] = 'l';
            Pulsacion pulsacion4 = new Pulsacion(letra5, 5);
            char[] letra6 = new char[3];
            letra6[0] = 'm';
            letra6[1] = 'n';
            letra6[2] = 'o';
            Pulsacion pulsacion5 = new Pulsacion(letra6, 6);
            char[] letra7 = new char[4];
            letra7[0] = 'p';
            letra7[1] = 'q';
            letra7[2] = 'r';
            letra7[3] = 's';
            Pulsacion pulsacion6 = new Pulsacion(letra7, 7);
            char[] letra8 = new char[3];
            letra8[0] = 't';
            letra8[1] = 'u';
            letra8[2] = 'v';
            Pulsacion pulsacion7 = new Pulsacion(letra8, 8);
            char[] letra9 = new char[4];
            letra9[0] = 'w';
            letra9[1] = 'x';
            letra9[2] = 'y';
            letra9[3] = 'z';
            Pulsacion pulsacion8 = new Pulsacion(letra9, 9);

            char[] letra0 = new char[1];
            letra0[0] = ' ';
            Pulsacion pulsacion9 = new Pulsacion(letra0, 0);

            List<Pulsacion> pulsaciones = new List<Pulsacion>();
            pulsaciones.Add(pulsacion);
            pulsaciones.Add(pulsacion2);
            pulsaciones.Add(pulsacion3);
            pulsaciones.Add(pulsacion4);
            pulsaciones.Add(pulsacion5);
            pulsaciones.Add(pulsacion6);
            pulsaciones.Add(pulsacion7);
            pulsaciones.Add(pulsacion8);
            pulsaciones.Add(pulsacion9);





            for (int i = 0; i < input.Length; i++)
            {
                foreach (var pls in pulsaciones)
                {
                    result = result + pls.BuscarChar(input[i]);
                }
            }


            //act o prueba




            //assert o Afirmacion
            Assert.AreEqual(output, result);
        }

    }
}
