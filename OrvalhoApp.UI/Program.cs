using System;
using System.Collections.Generic;
using System.Linq;
using OrvalhoApp.Infra.Data.Contexto;

namespace OrvalhoApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Teste com LINQ............");

            string separator = "";
            var lista1 = new List<int>() { 1,3,5,6,8 };
            var lista2 = new List<int>() { 1,2,5,7,8 };

            Console.WriteLine("Diferença............");
            //var diferenca = lista1.Except(lista2).ToList();
            var diferenca = (from num in lista1
                            select num)
                            .Except(from num in lista2 select num);

            foreach(var item in diferenca) 
            {
                System.Console.Write($"{separator}{item}");
                separator = ", ";
            }

            Console.WriteLine("");
            Console.WriteLine("Itens iguais (Intersect)............");
            
            //var iguais = lista1.Intersect(lista2).ToList();

            var iguais = (from num in lista1
                            select num)
                            .Intersect(from num in lista2 select num);

            separator = "";
            foreach(var item in iguais) 
            {
                System.Console.Write($"{separator}{item}");
                separator = ", ";
            }


            using (OrvalhoContext db = new OrvalhoContext())
            {
                Console.WriteLine("");
                Console.WriteLine("CATEGORIAS............");

                var categorias =  db.Categorias.ToList();

                categorias.ForEach(c => 
                    Console.WriteLine($"{c.Id} - \t {c.Nome}")
                );

                Console.WriteLine("");
                Console.WriteLine("MEDIDAS............");

                var medidas = db.UnidadeMedidas.ToList();

                medidas.ForEach(p=> 
                    Console.WriteLine($"{p.Id} \t {p.Nome} \t\t {p.Descricao}")
                );




            }

            


            
        }
    }
}
