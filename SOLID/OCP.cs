using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface ISalaryCalculate
    {
        decimal Calculate(decimal salary);
    }


    public class LowMiddle
    {

        public decimal Calculate(decimal salary)
        {
            return salary * 10;
        }

    }



    public class LowSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }
    public class MiddleSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }
    public class HighSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 8;
        }
    }


    public class SalaryCalculator
    {
    
        public decimal CustomCalculate(decimal salary)
        {
            return salary * 5;

     
           
        }

        public decimal CalculateGoodDelegate(decimal salary,Func<decimal,decimal> funcCalculate)
        {

            return funcCalculate(salary);
        }



        public decimal CalculateGood(decimal salary,ISalaryCalculate salaryCalculate)
        {
            return salaryCalculate.Calculate(salary);
        }



        public decimal Calculate(decimal salary,SalaryType salaryType)
        {
            decimal newSalary = 0;
            switch (salaryType)
            {
                case SalaryType.Low:
                    newSalary = salary * 2;
                    break;
                case SalaryType.Middle:
                    newSalary = salary * 4;
                    break;
                case SalaryType.High:
                    newSalary = salary * 8;
                    break;
                default:
                    break;
            }
            return newSalary;
        }





    }

    public enum SalaryType
    {
        Low=1,
        Middle=2,
        High=3,

    }
}
