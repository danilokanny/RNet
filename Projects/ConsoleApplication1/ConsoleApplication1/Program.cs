using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 10;

            strings = new List<string>();

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(String.Format("Digite o {0}º nome", i + 1));
                strings.Add(Console.ReadLine());

            }

            pesquisa();
        }


        private static void pesquisa()
        {
            String c;
            Console.WriteLine("O que vc procura?");
            c = Console.ReadLine();

            var resultado = strings.Where(x => x.Contains(c)).ToList();

            if (resultado.Any())
            {
                Console.WriteLine("encontrei");
                if (resultado.Count() == 1)
                {
                    Console.WriteLine(resultado[0]);

                }
                else
                {
                    int i = 0;
                    foreach (var m in resultado)
                    {
                        i++;
                        Console.WriteLine(String.Format("Resultado {0}:", i) + m);

                    }
                }

            }
            else
            {
                Console.WriteLine("nao encontrei");

            }

            Console.WriteLine("Pesquisa outro termo?\n" +
                "Digite 1 para pesquisar outro termo\n" +
                "Digite 2 iniciar novamente o cadastro\n" +
                "ou qualquer tecla para sair");
            try
            {
                Char ch = Console.ReadLine().ToCharArray()[0];
                if (ch == '1')
                {
                    pesquisa();
                }
                else if (ch == '2')
                {
                    Main(new String[0]);
                }
            }
            catch (Exception) { }
        }

        private static List<String> strings
        {
            get; set;
        }
    }
}
