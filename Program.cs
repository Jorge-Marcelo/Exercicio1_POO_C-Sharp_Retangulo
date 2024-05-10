using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Retangulo_Exercicio_POO
{
 internal class Program
 {
  static void Main(string[] args)
  {
   Retangulo ret = new Retangulo();

   Console.WriteLine("Entre com a altura e a largura do retangulo");
   ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

   Console.WriteLine($"Area: {ret.Area().ToString("F2", CultureInfo.InvariantCulture)}");
   Console.WriteLine($"Perimetro: {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
   Console.WriteLine($"Diagonal: {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

  }
 }
}
