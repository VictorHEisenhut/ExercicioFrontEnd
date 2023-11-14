using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class PersistenciaEmArquivo : IPersistenciaDaFatura
    {
        public void Salvar(Fatura fatura)
        {
            Console.WriteLine("Salvo em arquivo");
        }
    }
}
