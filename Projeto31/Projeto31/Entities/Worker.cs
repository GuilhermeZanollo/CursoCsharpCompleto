using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.CompilerServices;
using Projeto31.Entities.Enums;

namespace Projeto31.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get;  set; } // Associação entre duas classes diferentes
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Associação entre duas classes diferentes // Composição de objetos worker / department
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>(); // trabalhador pode ter varios contratos - (lista de contratos pois sao varios contratos)

        public Worker()
        {
            Name = string.Empty;
            Department = new Department();
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) // VIA DE REGRA, NÃO É COMUM ADICIONAR LISTAS/ASSOCIAÇÃO PARA MUITOS EM CONSTRUTOR (POR ISSO NAO É COLOCADO CONTRACTS)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContract(HourContract contract) // Vai receber por entrada contrato e adicionar na lista de contratos
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract); // acessa lista contracts e chamar a operação remove(passando como argumento o contrato a ser removido)
        }

        public double Income(int year, int month) // GANHO DO FUNCIONARIO
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) // PERCORRE A LISTA DE CONTRATOS ADICIONANDO VALOR NOS CONTRATOS
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
