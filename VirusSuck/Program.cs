using System;
using System.Collections.Generic;

namespace VirusSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            // add items to the list one at a time
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("Rabies");
            names.Add("SARS");
            names.Add("Stupidity");

            // remove items from the list one at a time
            names.Remove("Stupidity");

            // remove something from a specific index
            names.RemoveAt(3);

            // inserts an item at the beginning
            names.Insert(0, "Shebola");

            // add multiple items
            var people = new List<string> { "Nathan", "Martin", "Randy's Kid" };
            
            names.AddRange(people);

            // remove multiple items
            names.RemoveRange(names.Count - 4, 3);

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}");
            }

            //--------------------------------------------
            // Dictionaries
            //--------------------------------------------
            var symptoms = new Dictionary<string, string>();

            // add single items
            symptoms.Add("COVID-19", "Dry cough, fever, respiratory problems, cancels everything");
            symptoms.Add("Ebola", "Fever, headache, muscle pain, and chills");
            symptoms.Add("Spanish Flu", " fever, a dry cough, fatigue and difficulty breathing");
            symptoms.Add("SARS", "Fever, dry cough, headache, muscle aches, and difficulty breathing");
            symptoms.Add("Rabies", "Symptoms include fever, headache, excess salivation, muscle spasms, paralysis, and mental confusion.");

            // get single thing
            var covidSymptoms = symptoms["COVID-19"];

            // remove single thing
            symptoms.Remove("Ebola");

            // colletion initializer
            var otherDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 } };

            foreach (var (virus, symptom) in symptoms)
            {
                Console.WriteLine($"The {virus} virus has the following symptoms: {symptom}");
            }

            foreach (var name in names)
            {
                if (symptoms.ContainsKey(name))
                {
                    Console.WriteLine($"The {name} virus has the following symptoms: {symptoms[name]}");
                }
                else
                {
                    Console.WriteLine($"The {name} virus is unknown...");
                }
            }
        }
    }
}
