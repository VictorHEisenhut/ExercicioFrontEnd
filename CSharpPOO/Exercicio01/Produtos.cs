    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Produtos
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public double valorUnit { get; set; }
        public double Porcentagem { get; set; }

        public double Desconto(double n)
        {
            var porcentagem = n / 100;
            var desconto = this.valorUnit * porcentagem;

            var aux = this.valorUnit;

            return aux -= desconto;
        }

        public double Acrescimo(double n)
        {
            var porcentagem = n / 100;
            var desconto = this.valorUnit * porcentagem;
            var aux = this.valorUnit;

            return aux += desconto;
        }

        public override string ToString()
        {
            return $"Código: {this.Codigo}\n" +
                $"Descrição: {this.Descricao}\n" +
                $"Estoque: {this.Estoque}\n" +
                $"Valor unitário: {this.valorUnit}\n";
        }

    }
}
