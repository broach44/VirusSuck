using System;
using System.Collections.Generic;

namespace VirusSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("Rabies");
            names.Add("SARS");
            names.Add("Stupidity");

            names.Remove("Stupidity");
        }
    }
}
