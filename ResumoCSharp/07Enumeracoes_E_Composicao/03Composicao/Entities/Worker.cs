using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._7Enumeracoes_E_Composicao._03Composicao.Entities.Enums;

namespace CSharp._7Enumeracoes_E_Composicao._03Composicao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }//enum
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //assim se faz associação entre classes diferentes(worker so pode pertencer a um depatment)
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //associação entre Worker e HourContracts(um worker pode ter vários contracts, por isso o uso da lista)

        public Worker() { 
        }

        public Worker(string name, WorkLevel level, double baseSalary, Department department) { //não incluir associações para muitos, no caso Contracts (não é usual passar uma lista instanciada no construtor do objeto)
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) 
        { 
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) { //renda naquele ano e mes (tem que percorrer a lista de contratos do objeto(Ex:João) acumulando a soma dos contratos referentes a aquele ano e mês)
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)    
                {
                    sum = sum + contract.TotalValue();
                }
            }

            return sum;
        }

    }
}
