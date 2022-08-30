namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Hours: {Hours:N2}" +
                $"\n\t Hours Values: {HourValue:N2}" +
                $" \n\t Value to Pay: {GetValueToPay():C2}";
        }
    }
}
