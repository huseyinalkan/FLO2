using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.AFDP
{



    public interface IScreen
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public RefreshRate RefreshRate { get; set; }
    }

    public interface IKeyboard
    {
        public bool IsLight { get; set; }
        public bool HasNumeric { get; set; }
    }
    public interface IRam
    {
        public int Memory { get; set; }
    }
    public interface IGPU
    {
        public int Memory { get; set; }
    }
    public interface ICPU
    {
        public int Core { get; set; }
    }


    public class Screen : IScreen
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public RefreshRate RefreshRate { get; set; }
    }
    public class Keyboard : IKeyboard
    {

        public bool IsLight { get; set; }
        public bool HasNumeric { get; set; }
    }
    public class GPU : IGPU
    {
        public int Memory { get; set; }
    }
    public class CPU : ICPU
    {
        public int Core { get; set; }
    }
    public class Ram : IRam
    {
        public int Memory { get; set; }
    }
    public enum RefreshRate
    {
        Hz60,
        Hz120,
        Hz240
    }

    public abstract class BaseComputer
    {
        public string Name { get; set; } = null!;

        public IRam Ram { get; set; }
        public IScreen Screen { get; set; }
        public ICPU CPU { get; set; }
        public IGPU GPU { get; set; }
        public IKeyboard Keyboard { get; set; }

        public override string ToString()
        {
            return $"{Name}- {Ram.Memory}- {Screen.Height}-  {CPU.Core}- {GPU.Memory}";
        }
    }


    public class Computer:BaseComputer
    {

    }
    public interface IComputerComponentFactory
    {
        public BaseComputer CreateCustomComputer(string name, IRam ram,IScreen screen,IKeyboard keyboard, ICPU cPU, IGPU gPU)
        {

            return new Computer()
            {
                Ram = ram,
                Screen = screen,
                GPU = gPU,
                CPU = cPU,
                Keyboard = keyboard
            };
        }

        public BaseComputer CreateComputer(string name)
        {

            return new Computer()
            {
                CPU = CreateCPU(),
                GPU = CreateGPU(),
                Keyboard = CreateKeyboard(),
                Screen = CreateScreen(),
                Name = name


            };
        }


        IScreen CreateScreen();
        IKeyboard CreateKeyboard();
        IRam CreateRam();
        IGPU CreateGPU();
        ICPU CreateCPU();



    }



    public class LowLevelComputerComponentFactory : IComputerComponentFactory
    {
        public ICPU CreateCPU()
        {
            return new CPU() { Core = 2 };
        }

        public IGPU CreateGPU()
        {
            return new GPU() { Memory = 4 };
        }

        public IKeyboard CreateKeyboard()
        {
            return new Keyboard() { HasNumeric = false, IsLight = false };
        }

        public IRam CreateRam()
        {
            return new Ram() { Memory = 8 };
        }

        public IScreen CreateScreen()
        {
            return new Screen() { Height = 800, Width = 1280, RefreshRate = RefreshRate.Hz60 };
        }
    }

    public class HighLevelComputerComponentFactory : IComputerComponentFactory
    {
        public ICPU CreateCPU()
        {
            return new CPU() { Core = 4 };
        }

        public IGPU CreateGPU()
        {
            return new GPU() { Memory = 8 };
        }

        public IKeyboard CreateKeyboard()
        {
            return new Keyboard() { HasNumeric = false, IsLight = false };
        }

        public IRam CreateRam()
        {
            return new Ram() { Memory = 8 };
        }

        public IScreen CreateScreen()
        {
            return new Screen() { Height = 800, Width = 1280, RefreshRate = RefreshRate.Hz120 };
        }
    }























    #region Prototype example
    //public interface IComputer { }
    //public interface IMobilePhone { }

    //public class LowLevelComputer : IComputer { }
    //public class MiddleLevelCompouter : IComputer { }
    //public class HighLevelCompouter : IComputer { }



    //public class LowLevelMobilePhone : IMobilePhone { }
    //public class MiddleLevelMobilePhone : IMobilePhone { }
    //public class HighLevelMobilePhone : IMobilePhone { }




    //public interface IComponentFactory
    //{
    //    IComputer CreateComputer();
    //    IMobilePhone CreateMobilePhone();
    //}

    //public class LowLevelComponentFactory : IComponentFactory
    //{
    //    public IComputer CreateComputer()
    //    {
    //        return new LowLevelComputer();
    //    }

    //    public IMobilePhone CreateMobilePhone()
    //    {
    //        return new LowLevelMobilePhone();
    //    }
    //}

    //public class MiddleLevelComponentFactory : IComponentFactory
    //{
    //    public IComputer CreateComputer()
    //    {
    //        return new MiddleLevelCompouter();
    //    }

    //    public IMobilePhone CreateMobilePhone()
    //    {
    //        return new MiddleLevelMobilePhone();
    //    }
    //} 
    #endregion
}
