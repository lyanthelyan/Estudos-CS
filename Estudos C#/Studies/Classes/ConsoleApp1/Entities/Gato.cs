using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Gato : Animal
    {
        public Gato() { }

        public override string EmitirSom()
        {
            return "Miau";
        }
    }
}
