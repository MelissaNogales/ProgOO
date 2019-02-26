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

   /* public static bool operator ==(Dado a, int valor )
   {
      return a.valor == valor;

   } */
}

class Program
{
   static void Main()
   {  
      List<Dado> dados = new List<Dado>();

      dados.Add(new Dado(1, "verde"));
      dados.Add(new Dado(2, "rojo"));
      dados.Add(new Dado(3, "azul"));

      
        //if (dados[0] > dados[1])
      
      {
         Dado temp = dados[0];
         dados[0] = dados[1];
         dados[1] = temp;

      }
      //if (dados[0] < dados[1])
      
      {
         Dado temp = dados[0];
         dados[0] = dados[1];
         dados[1] = temp;

      }

      /* int valor = 1;
      foreach (var d in dados)
      {
         if (d == 1)
            d.imprime();
      }/* */
      
      Console.ReadKey();
   } 
}