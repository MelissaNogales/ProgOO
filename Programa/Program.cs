using System;
using System.Collections.Generic;

namespace Programa
{
    class Paciente
    {
        private string nombre;
        private int edad;
        private int consulta=60;
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
                Console.WriteLine("Total consulta: {0:C}", Pago.TotalConsulta(this));
            }
            public void Imprime(int veces)
            {
                for (int i=0; i<=veces; i++)
                Imprime();
            }
            public int Consulta
            {
                get
                {
                    return consulta;
                }
            }
    }
    class Pago
    {
        public static int TotalConsulta(Paciente P)
        {
            return 10+P.Consulta;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Paciente p =new Paciente("Patricia", 41);
            p.Imprime(3);
        }
    }
}
