using DogDoorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoorSimulator.DogDoorTestPath(2000);

            DogDoorSimulator.DogDoorTestPath(10000);
        }
    }
}
