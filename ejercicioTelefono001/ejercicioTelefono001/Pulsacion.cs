using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioTelefono001
{
    class Pulsacion
    {
        private char[] caracteres { get; set; }
        private int numero { get; set; }

        public bool espacio = false;


        public Pulsacion(char[] caracteres, int numero) //metodo constructor
        {   
            this.caracteres = caracteres;
            this.numero = numero;
        }

        public void SetCaracteres(char[] caracteres)
        {
            this.caracteres = caracteres;
        }

        public char[] GetCaracteres()
        {
            return this.caracteres;
        }

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public int GetNumero()
        {
            return this.numero;
        }

        public  string BuscarChar(char c)
        {
            bool encontrado = false;
            int i = 0;
            string mostrar = "";

            while (encontrado == false && i < this.GetCaracteres().Length)
            {
                
                if (this.GetCaracteres()[i] == c)
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
                if (espacio == true)
                {
                    mostrar += " " + GetNumero();
                    espacio = false;
                }
                else
                    mostrar += GetNumero();
            }
            if (encontrado == true)
            {
                espacio = true;
                return mostrar;
            }
            {

            }
            return null;
        }


    }
}
