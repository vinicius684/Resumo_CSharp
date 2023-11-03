using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._3Construtores_This_Sobrecarga_Encapsulamento._9ExContaBancaria
{
    internal class ContaBancaria
    {
        public int IdConta { get; private set; }//id da conta não deve ser alterado -> Private set
        private string _titular;//nome do titular pode ser alterado, casamento etc -> Set deve estar livre
        public double Saldo { get; private set; }//saldo pode ser alterado, porém apenas pelas operações -> Private set

        public ContaBancaria(int idConta, string titular)
        {
            IdConta = idConta;
            _titular = titular;
            Saldo = 0.0;
        }

        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _titular = value;
                }
            }
        }

        public void Depósito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor)
        {
            Saldo = (Saldo - 5) - valor;
        }


        public override string ToString()
        {
            return "Conta " + IdConta + ", Titular: " + _titular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
