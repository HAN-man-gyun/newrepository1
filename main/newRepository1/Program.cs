using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newRepository1
{
    public class Program
    { //
        static void Main(string[] args)
        {
            // { 2023. 07. 03. Add user input /Beta}
            string userInput = string.Empty;
            Console.WriteLine("This program convert Cm to Inch");
            Console.WriteLine("Input Cm value : ");
            userInput = Console.ReadLine();
            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(cmInput);
            // { 2023. 07. 03. Add user input /Beta}
            ruler.Run();
            
        }
        public class Ruler
        {
            private const float ONE_INCH = 2.54F;
            public int Centimeter { get; set; } = 0;

            public float Inch
            {
                get { return Centimeter * ONE_INCH; }
            // {2023.07.03. Add private _SetInch function / Gamma}
                private set { this._SetInch(value); }
            }

            public Ruler(int cmValue) { Centimeter = cmValue; }

            public void Run()
            {
                Console.WriteLine($"{this.Centimeter}cm는 {this.Inch}inch입니다.");
            }

            private void _SetInch(float inchValue) { Centimeter = (int)(inchValue / ONE_INCH); }
            // {2023.07.03. Add private _SetInch function / Gamma}
        }
    }
}
