using System;
using System.Collections.Generic;

namespace Programa
{
    class Paciente
    {
        private string nombre;
        private int edad;
        public string Nombre
        {
            get 
                {
                    return nombre;
                }
            set 
                {
                    nombre=value;
                }
        }
        public Paciente(string nombre, int e)
        {
            this.nombre=nombre;
            edad=e;
        }
        public void Imprime()
            {
                Console.WriteLine(nombre);
            }

            public void Imprime(int veces)
            {
                for (int i=0; i<=veces; i++)
                Imprime();
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Paciente p =new Paciente("Patricia", 41);
            List<Paciente> pacientes =new List<Paciente>();
            pacientes.Add(p);
            pacientes.Add(new Paciente("Yovanny", 22));
            p.Imprime(3);
        }
    }
}
