using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp60
{
    public class Car
    {
        public string Model { get; set; } = "Mercedes";

        public string Color { get; set; } = "Blue";

        public override string ToString() => $"The car's model is {this.Model} and its color is {this.Color}.";
    }
}
