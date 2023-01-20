// See https://aka.ms/new-console-template for more information


using CreationalDP.PDP;

Console.WriteLine("Hello, World!");


var product = new Product() { Id = 1, Name = "Kalem 1", Address = new Address() { Line = "birinci satır" } };
var product2 = product.Clone() as Product;
Console.WriteLine(product.Address.Line);
Console.WriteLine(product2.Address.Line);
product.Address.Line = "ikinci satır";
Console.WriteLine(product.Address.Line);
Console.WriteLine(product2.Address.Line);


















//Builder with Fluent
//var carFluent = new HatchbackCarBuilderFluent().SetModel("model 2").SetGear().SetWindShield().SetSeat().GetCar();
//var carFluent2 = new SedanbackCarBuilderFluent().SetModel("sedan 2").SetGear().SetWindShield().SetSeat().GetCar();
//Console.WriteLine(carFluent);
//Console.WriteLine(carFluent2);




//Normal Builder
//var carDirector = new CarDirector(new HatchbackCarBuilder());
//var car1 = carDirector.GetCar("model 1");
//Console.WriteLine(car1);








#region Abstract Factory DP
//IComputerComponentFactory lowLevelComponentFactory = new LowLevelComputerComponentFactory();
//IComputerComponentFactory highLevelComponentFactory = new HighLevelComputerComponentFactory();
//var screen = lowLevelComponentFactory.CreateScreen();
//var computer1=lowLevelComponentFactory.CreateComputer("computer 1");

//var customComputer = highLevelComponentFactory.CreateCustomComputer("Custom 1", lowLevelComponentFactory.CreateRam(), lowLevelComponentFactory.CreateScreen(), highLevelComponentFactory.CreateKeyboard(), highLevelComponentFactory.CreateCPU(), highLevelComponentFactory.CreateGPU());
#endregion
#region Abstract Factory DP With ProtoType

//IComponentFactory componentFactory = new LowLevelComponentFactory();

//var computer= componentFactory.CreateComputer();
//var mobilePhone = componentFactory.CreateMobilePhone(); 
#endregion
#region Factory Method DP
//var response = Response<string>.Success("data", 200);

//var response2 = Response<string>.Fail("hata mesaj", 404);

////var product = new Product() { Created = DateTime.Now, Type = 1 };

//var productFactory = new ProductFactory();
//var newProduct = productFactory.CreateWithSea("Kalem 1"); 
#endregion
#region Singleton DP
//var instance1 = MySingletonThreadSafeShort.Instance2;
//var instance2 = MySingletonThreadSafeShort.Instance2;

//Console.WriteLine(instance1.Equals(instance2));

//var instance = MySingleton.CreateInstance();

//var instance2 = new MySingleton(); 
#endregion
