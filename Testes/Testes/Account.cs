using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    public class Account
    {
        public double Balance { get; set; }
        public void Store(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                throw new ArgumentException("Quantia deve ser maior que 0");
            }
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Saldo Insuficiente");
            }
        }
    }
}
