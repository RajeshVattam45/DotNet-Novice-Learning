using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.SolidPrincipals.ISP
{
    public interface CarsClass
    {
        public string CarName(string carName);
        public string CarColor(string carColor);
        public int CarCost(int carCost);
    }

    public interface CarsBrands
    {
        public string CarBrandName(string carBrandName);
    }

    public class AudiClass : CarsClass, CarsBrands
    {
        public string CarName(string carName)
        {
            return $"car name {carName}";
        }

        public string CarColor(string carColor)
        {
            return $"car color {carColor}";
        }

        public int CarCost(int carCost)
        {
            return carCost;
        }

        public string CarBrandName(string carBrandName)
        {
            return $"Car brand {carBrandName}";
        }
    }
}
