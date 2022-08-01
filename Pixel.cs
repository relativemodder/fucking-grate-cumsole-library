using System;
using System.Collections.Generic;

namespace ConsoleLib
{
    public class Pixel
    {
        public override string ToString() => GetSymbol();

        public string GetSymbol()
        {
            try
            {
                return brightnessCharacters[this.Brightness];
            }
            catch (KeyNotFoundException)
            {
                if (this.Brightness > 4)
                    return brightnessCharacters[4];

                return brightnessCharacters[0];
            }
        }

        public int Brightness;
        private Dictionary<int, string> brightnessCharacters = new Dictionary<int, string>()
        { 
            [0] = " ",
            [1] = ".",
            [2] = "r",
            [3] = "g",
            [4] = "@"
        };
    }
}
