using System;

namespace ClassLibrary.SolidPrincipals.ISP
{
    // Interface for general car properties.
    public interface CarsClass
    {
        // Method to set or get the car propertices.
        public string CarName(string carName);
        public string CarColor(string carColor);
        public int CarCost(int carCost);
    }

    // Interface for car brand-related properties.
    public interface CarsBrands
    {
        // Method to set or get the car brand name.
        public string CarBrandName(string carBrandName);
    }

    // Concrete class implementing both CarsClass and CarsBrands interfaces.
    public class AudiClass : CarsClass, CarsBrands
    {
        // Implementation of the CarName method.
        public string CarName(string carName)
        {
            return $"car name {carName}";
        }

        // Implementation of the CarColor method.
        public string CarColor(string carColor)
        {
            return $"car color {carColor}";
        }

        // Implementation of the CarCost method.
        public int CarCost(int carCost)
        {
            return carCost;
        }

        // Implementation of the CarBrandName method.
        public string CarBrandName(string carBrandName)
        {
            return $"Car brand {carBrandName}";
        }
    }
}
