// See https://aka.ms/new-console-template for more information
using SOLID;

Console.WriteLine("Hello, World!");

Phone phone = new IPhone12();

phone.Call();



((ITakePhoto)phone).TakePhoto();
phone = new Nokia3310();


if(phone is ITakePhoto takePhoto)
{
   takePhoto.TakePhoto();
}

phone.Call();








//Open Closed
//var lowLevelSalary = new LowSalaryCalculate();

//SalaryCalculator salaryCalculator = new();

//salaryCalculator.CalculateGood(100, lowLevelSalary);

//Console.WriteLine(salaryCalculator.CalculateGoodDelegate(1000,new LowMiddle().Calculate));