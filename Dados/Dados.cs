using System;
using System.Collections.Generic;

class Dado
{
   private int valor;
   private string color;

   public Dado(int valor, string co)
   {
      this.valor = valor;
      this.color = co;
   }

   public void imprime()
   {
      Console.WriteLine("{0}", color);
   }

   public override bool Equals(object o)
        {
            return this.valor.Equals((o as Dado).valor);
        }

        public static bool operator==(Dado a, Dado b)
        {
            return a.valor==b.valor;
        }
        public static bool operator!=(Dado a, Dado b)
        {
            return a.valor!=b.valor;
        }
}

class Program
{
   static void Main()
   {  
      Dado a =new Dado(1, "Verde");
      Dado b=new Dado(1, "Verde");
      Dado c =new Dado(1, "Verde");
            if (a == b && a == c)
            {
                Console.WriteLine("Los dados son iguales");
            }
            else 
            {
                Console.WriteLine("Los dados tienen valores distintos");
            }
   } 
}