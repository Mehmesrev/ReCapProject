using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string DailyPriceInvalid = "Daily price must be greater than zero.";
        public static string CarAdded = "Car added successfully.";
        public static string BrandNameInvalid = "Brand name must be longer than 2 characters.";
        public static string BrandAdded = "Brand added successfully.";

        public static string CantBeRental = "This car is already rented.";
        public static string RentalAddad = "Rental added successfully.";
    }
}
