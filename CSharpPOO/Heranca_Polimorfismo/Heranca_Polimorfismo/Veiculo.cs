using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    internal class Veiculo
    {
        public string Marca { get; set; }
        public int VelocidadeMax { get; set; }
        public string Modelo { get; set; }

        public Veiculo()
        {
            
        }
        public Veiculo(string marca, int velocidadeMax, string modelo)
        {
            VelocidadeMax = velocidadeMax; 
            Modelo = modelo;
            Marca = marca;
        }

        public string ToString()
        {
            return $"Marca: {Marca}\n Modelo: {Modelo}\n Velocidade Máxima: {VelocidadeMax} km/h";
        }

    }
}
