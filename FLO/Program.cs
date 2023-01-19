// See https://aka.ms/new-console-template for more information

using HASAISA.HasA;

Console.WriteLine("Hello, World!");

var car1 = new Car1();
car1.Forward();
car1.Backward();
car1.Right();
car1.Left();
car1.SetBackwardBehavior(new SuperBackwardBehavior());
car1.Backward();