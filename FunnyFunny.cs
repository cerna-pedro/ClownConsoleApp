using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownConsoleApp
{
    internal class FunnyFunny : IClown
    {
        public string FunnyThingIHave { get { return funnyThingIHave; } }
        private string funnyThingIHave;

        public FunnyFunny(string funnyThingIHave)        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            Console.WriteLine($"Hi kids!, I have a {funnyThingIHave}.");
        }

    }
}
