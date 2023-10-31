    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Produtos
    {
        private int codigo;
        private string descricao;
        private int estoque;
        private double valorUnit;
        private double porcentagem;    

        public int Codigo {
            get { return codigo; } 
            set
            {
                if (value > 0)
                {
                    codigo = value;
                }
                else
                {
                    Console.WriteLine("Código inválido!");
                }
            }
        }
        public string Descricao { 
            get 
            {
                return descricao;
            } 
            set 
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Descrição inválida");
                }
                else
                {
                    descricao = value;
                }
            }
        }
        public int Estoque { 
            get
            {
                return estoque;
            }
            set
            {
                if (value > 0)
                {
                    estoque = value;
                }
                else
                {
                    Console.WriteLine("Estoque inválido");
                }
            }
        }
        public double ValorUnit { 
            get
            {
                return valorUnit;
            }
            set
            {
                if (value > 0)
                {
                    valorUnit = value;
                }
                else
                {
                    Console.WriteLine("Valor unitário inválido!");
                }
            }
        }
        public double Porcentagem {
            get
            {
                return porcentagem;
            }
            set
            {
                if (value > 0)
                {
                    porcentagem = value;
                }
                else
                {
                    Console.WriteLine("Porcentagem inválida!");
                }
            }
        }

        public Produtos()
        {

        }

        public Produtos(int codigo, string descricao, int estoque, double valorUnit, double porcentagem)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.estoque = estoque;
            this.valorUnit = valorUnit;
            this.porcentagem = porcentagem;
        }

        public double Desconto(double n)
        {
            var porcentagem = n / 100;
            var desconto = this.ValorUnit * porcentagem;

            var aux = this.ValorUnit;

            return aux -= desconto;
        }

        public double Acrescimo(double n)
        {
            var porcentagem = n / 100;
            var desconto = this.ValorUnit * porcentagem;
            var aux = this.ValorUnit;

            return aux += desconto;
        }

        public override string ToString()
        {
            return $"Código: {this.Codigo}\n" +
                $"Descrição: {this.Descricao}\n" +
                $"Estoque: {this.Estoque}\n" +
                $"Valor unitário: {this.ValorUnit}\n";
        }

    }
}
