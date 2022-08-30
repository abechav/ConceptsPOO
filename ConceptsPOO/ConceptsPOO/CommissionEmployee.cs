using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()} +" +
                $"\n\t Commission percentaje: {CommissionPercentaje:P2}" +
                $"\n\t Sales: {Sales:C2}" +
                $" \n\t Value to Pay: {GetValueToPay():C2}";
        }
    }
}
