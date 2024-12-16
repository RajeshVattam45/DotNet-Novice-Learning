using System;

namespace sample1.oops
{
    class Animals
    {
        public string AnimalName;
        public string AnimalColor;
        public int AnimalWeight;

        public Animals(string Name, string Color, int Weight)
        {
            AnimalName = Name;
            AnimalColor = Color;
            AnimalWeight = Weight;
        }

        public void DisplayAnimal()
        {
            Console.WriteLine(AnimalName + " " + AnimalColor + " " + AnimalWeight);
        }
    }
}
