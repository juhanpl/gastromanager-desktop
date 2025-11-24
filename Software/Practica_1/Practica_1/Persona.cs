using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_1
{
    public class Persona
    {

        public Persona() { }

        private string Nombre { get; set; }

        private int Edad;

        public string Sexo;

        public int GetEdad()
        {

            return Edad;

        }

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nombre) 
        {

            if (nombre.StartsWith("J"))
            {
                Console.WriteLine("Este nombre empieza por J");
                return;
            }


            Nombre = nombre;

        }

        

    }
}
