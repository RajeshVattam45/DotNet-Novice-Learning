using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.SolidPrincipals.LSP
{
    public abstract class AnimalsClass
    {
        public abstract string AnimalName(string animalName);
        public abstract string AnimalColor(string animalColor);
    }

    public class LionsClass : AnimalsClass
    {

        public override string AnimalName(string animalName)
        {
            return $"Animal name: {animalName}";
        }

        public override string AnimalColor(string animalColor)
        {
            return $"Animal color: {animalColor}";
        }
    }

    public class TigerClass : AnimalsClass
    {
        public override string AnimalName(string animalName)
        {
            return $"Animal name: {animalName}";
        }

        public override string AnimalColor(string animalColor)
        {
            return $"Animal color: {animalColor}";
        }
    }
}
