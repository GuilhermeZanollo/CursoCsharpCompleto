using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto18
{
    internal class Calculator
    {
        public static int Sum(params int[] nums) // adiciona a palavra PARAMS avisando ao compilador que voce quer uma função que possa receber uma quantia variavel de valores
        {
            int sum = 0;
            for (int i = 0; i< nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
