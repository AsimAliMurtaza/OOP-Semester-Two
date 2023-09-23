using ChallengeOne.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.DL
{
    internal class MenuList
    {
        public static List<MenuItem> list = new List<MenuItem>();

        public static bool readFromFile(string path,CoffeeShop C)
        {
            string line;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((line = f.ReadLine()) != null)
                {
                    string[] splittedLine = line.Split(',');
                    string name = splittedLine[0];
                    string type = splittedLine[1];
                    float price = float.Parse(splittedLine[2]);
                    MenuItem s = new MenuItem(name, type, price);
                    C.AddMenuItem(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
