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
        public string Name { get; private set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Propriedade do tipo lista de Hour contract, nome: Contracts // Para representar o vários da classe Worker

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) // Não adicionar a lista pois inicia zerada normalmente/ será preenchida
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) // Acessa e adiciona na lista Contracts esse contrato que chegou de parametro
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) // Acessa e remove na lista Contracts esse contrato que chegou de parametro
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) // Percorre a lista de contratos para acrescentar os contratos dos respectivos meses
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue(); // Calcula o salario total de um determinado mês e soma ao salário base
                }
            }
            return sum;
        }
    }
}