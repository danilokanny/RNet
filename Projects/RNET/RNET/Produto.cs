using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNET
{
    class Produto
    {
        public string Codigo;
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Codigo = "000";
            Nome = "Sem Nome";
            Quantidade = 0;
            Preco = 0;
        }

        public Produto(string _codigo, string _nome, int _quantidade, double _preco )
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Quantidade = _quantidade;
            this.Preco = _preco;
        }

        public string GetDetalhes()
        {
            return $"[ Código: {Codigo} | Nome: {Nome} | Quanitdade: {Quantidade} | Preço: {Preco} ]";
        }
        /// <summary>
        ///  Aplica um desconto percentual no preço do produto
        /// </summary>
        /// <param name="desconto">Desconto em %</param>
        public void AplicarDesconto(double desconto)
        {
            if (desconto < 0)
                desconto = 0;
            if (desconto > 100)
                desconto = 100;
            Preco = Preco * (1 - desconto / 100);
        }
    }
}
