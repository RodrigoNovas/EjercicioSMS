using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioTelefono001
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string input;
            string sms;
            string result;
            bool valid = false;
            string rta = "n";
            bool repetir = false;

            do
            {
                do
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Menu: ");
                    Console.WriteLine("Ingrese 1 si desea decodificar SMS, Ingrese 2 si desea salir: ");

                    input = Console.ReadLine();
                    valid = int.TryParse(input, out i);
                    if (!valid)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe ingresar solo numeros!!!!");
                    }

                } while (!valid);
                do
                {
                    if (input == "1")
                    {
                        //inicializacion de variables 
                        string letras = "abcdefghijklmnopqrstuvwxyz "; //total de letras que posee
                        List<Pulsacion> pulsar = new List<Pulsacion>();

                        char[] primerTanda = new char[3];
                        IniciarPulsacion(ref letras, ref primerTanda); //metodo estatico (funcion) pasaje por referencia para inicializar array
                        Pulsacion pulsacion1 = new Pulsacion(primerTanda, 2); //instancia objeto

                        IncializarLista(ref pulsar, ref pulsacion1); //metodo estatico (funcion) pasaje por referencia para inicializar lista

                        char[] segundaTanda = new char[3];
                        IniciarPulsacion(ref letras, ref segundaTanda);
                        Pulsacion pulsacion2 = new Pulsacion(segundaTanda, 3);
                        IncializarLista(ref pulsar, ref pulsacion2);

                        char[] tercerTanda = new char[3];
                        IniciarPulsacion(ref letras, ref tercerTanda);
                        Pulsacion pulsacion3 = new Pulsacion(tercerTanda, 4);
                        IncializarLista(ref pulsar, ref pulsacion3);

                        char[] cuartaTanda = new char[3];
                        IniciarPulsacion(ref letras, ref cuartaTanda);
                        Pulsacion pulsacion4 = new Pulsacion(cuartaTanda, 5);
                        IncializarLista(ref pulsar, ref pulsacion4);

                        char[] quintaTanda = new char[3];
                        IniciarPulsacion(ref letras, ref quintaTanda);
                        Pulsacion pulsacion5 = new Pulsacion(quintaTanda, 6);
                        IncializarLista(ref pulsar, ref pulsacion5);

                        char[] sextaTanda = new char[4];
                        IniciarPulsacion(ref letras, ref sextaTanda);
                        Pulsacion pulsacion6 = new Pulsacion(sextaTanda, 7);
                        IncializarLista(ref pulsar, ref pulsacion6);

                        char[] septimaTanda = new char[3];
                        IniciarPulsacion(ref letras, ref septimaTanda);
                        Pulsacion pulsacion7 = new Pulsacion(septimaTanda, 8);
                        IncializarLista(ref pulsar, ref pulsacion7);

                        char[] octavaTanda = new char[4];
                        IniciarPulsacion(ref letras, ref octavaTanda);
                        Pulsacion pulsacion8 = new Pulsacion(octavaTanda, 9);
                        IncializarLista(ref pulsar, ref pulsacion8);

                        char[] espacio = new char[1];
                        IniciarPulsacion(ref letras, ref espacio);
                        Pulsacion pulsacion0 = new Pulsacion(espacio, 0);
                        IncializarLista(ref pulsar, ref pulsacion0);

                        Console.WriteLine("Bienvenido: ");
                        Console.WriteLine("Ingrese caracter SMS: ");
                        sms = Console.ReadLine();
                        result = Recorrido(sms, ref pulsar);
                        Console.WriteLine("Su mensaje es: {0}", result);
                        repetir = true;
                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Hasta Luego");

                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Usted ingreso un numero incorrecto");
                    }

                } while (input != "1" && input != "2");


                if (repetir == true)
                {
                    Console.WriteLine("¿Desea ingresar un nuevo SMS?/ Ingrese s/n");

                    rta = Console.ReadLine().ToLower();
                    if (rta == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Hasta Luego");

                    }

                    repetir = false;
                }


            } while (rta == "s");





            Console.ReadKey();
        }

        /// <summary>
        /// Incializa array de caracteres partiendo desde string consolodidado
        /// </summary>
        /// <param letras="arrayConsol"></param>
        /// <param primerTanda="arrayIndiv"></param>

        static void IniciarPulsacion(ref string arrayConsol, ref char[] arrayIndiv)
        {
            int cantidadCaracteres;

            cantidadCaracteres = arrayIndiv.Length;

            for (int i=0; i<cantidadCaracteres; i++)
            {

                arrayIndiv[i] = arrayConsol[i];

            }

           arrayConsol= arrayConsol.Remove(0,cantidadCaracteres);
        }



        /// <summary>
        /// Incializa lista de pulsaciones
        /// </summary>
        /// <param pulsar ="myList"></param>
        /// <param pulsacion1="pulsacion"></param>

        static void IncializarLista(ref List<Pulsacion> myList, ref Pulsacion pulsacion)
        {
            myList.Add(pulsacion);


        }
        
        /// <summary>
        /// Recorre toda la lista de objeto pulsacion para decodificar el mensaje
        /// </summary>
        /// <param sms="input"></param>
        /// <param pulsar="Pulsaciones"></param>
        /// <param "No pudo convertirse"="mensajeError"></param>
        /// <returns> Retorna valor de error en caso de no poder decodificar y resultado en caso de decodificarlo</returns>

        static string Recorrido(string input, ref List<Pulsacion> Pulsaciones)
        {
            string result="";
            for (int i = 0; i < input.Length; i++)
            {
                foreach (var pls in Pulsaciones)
                {
                    result += pls.BuscarChar(input[i]);          
                }
            }

            return result;
        }



    }
}
