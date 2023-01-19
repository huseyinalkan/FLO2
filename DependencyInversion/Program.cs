// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");

var bl = new BL(new DALFactory().GetDalWithOracle());

bl.GetProduct().ForEach(x =>
{
    Console.WriteLine($"{x.Id} {x.Name}");
});
