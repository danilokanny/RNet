using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto arroz = new Produto();
            //arroz.Codigo = "01";
            //arroz.Nome = "arroz";
            //arroz.Quantidade = 100;
            //arroz.Preco = 4.0;

            //Produto Feijao = new Produto();
            //Feijao.Codigo = "02";
            //Feijao.Nome = "Feijão Preto";
            //Feijao.Quantidade = 100;
            //Feijao.Preco = 5.0;

            //Console.WriteLine("Codigo: {0}| Nome: {1} | Quantidade: {2} | Preço: {3}",arroz.Codigo,arroz.Nome,arroz.Quantidade, arroz.Preco);
            ////$ Serve para colocar as class dentro das {}
            //Console.WriteLine($"Codigo: {Feijao.Codigo} | Nome: {Feijao.Nome}| Quantidade: {Feijao.Codigo}| Preço: {Feijao.Preco}");

            //Produto produto = new Produto();
            //Console.WriteLine("Codigo:");
            //produto.Codigo = Console.ReadLine();
            //Console.WriteLine("Nome:");
            //produto.Nome = Console.ReadLine();
            //Console.WriteLine("Quanitdade");
            //produto.Quantidade = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Preço:");
            //produto.Preco = Convert.ToDouble(Console.ReadLine());
            ////ctrl+k+C << Comenta o Código selecionado | CTRL+K+U <<< descomenta
            //// Console.WriteLine($"Código: {produto.Codigo}| Nome: {produto.Nome}| Quantidade: {produto.Quantidade}| Preço: {produto.Preco}");
            //Console.WriteLine("Valores Originais");
            //Console.WriteLine(produto.GetDetalhes());

            ////Console.WriteLine("Informe o Valor do Desconto em %: ");
            ////desconto = Convert.ToDouble(Console.ReadLine());

            ////produto.AplicarDesconto(desconto);

            //produto.AplicarDesconto(10);
            //Console.WriteLine("Valores com o Desconto");
            //Console.WriteLine(produto.GetDetalhes());

            Produto p1 = new Produto();
            Console.WriteLine(p1.GetDetalhes());

            Produto p2 = new Produto("999","Melancia", 4, 0.9);
            Console.WriteLine(p2.GetDetalhes());

            Produto p3 = new Produto
            {
                Codigo = "335"
            };
            Console.WriteLine(p3.GetDetalhes());
            Console.ReadKey();
        }
    }
}
