using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversionUtility
{
    class ConversionUtility
    {
        //the numbers we need for conversion
        private const float INCH_PER_FOOT = 12;
        private const float TBLSPN_PER_GALLON = 256;
        private const double PARSEC_PER_LIGHTYEAR = 3.26156378;
        private const float CUP_TO_TEASPOON = 48;
        private const float MILES_TO_CNTMTR = 160934.4f;
        private const float WEEK_TO_MINUTE = 10080;



        //default class function
        public ConversionUtility()
        {
            


        }



        //conver feet to inches
        public static void convertFeetToInches(float feet)
        {
            float result = INCH_PER_FOOT * feet;
            Console.WriteLine("There are {1} inches in {0} ft", feet, result);


        }
        //convert gallons to table spoons
        public static void convertGallonstoTableSpns(float gallons)
        {

            float result = TBLSPN_PER_GALLON * gallons;
            Console.WriteLine("There are {1} table Spoons in {0} gallons", gallons, result);


        }
        //convert parsec to lightyear
        public static void convertParsecToLightyear(double Parsec)
        {

            double result = PARSEC_PER_LIGHTYEAR * Parsec;
            Console.WriteLine("There are {1} light Years in {0} Parsecs", Parsec, result);


        }
        //convert cup to teaspoon
        public static void convertCupToTeaspn(double cup)
        {

            double result = CUP_TO_TEASPOON * cup;
            Console.WriteLine("There are {1} tea Spoons in {0} cups", cup, result);


        }
        //convert miles to centimeters
        public static void convertMilesToCntmtr(float mile)
        {

            double result = MILES_TO_CNTMTR * mile;
            Console.WriteLine("There are {1} centimeters in {0} miles", mile, result);


        }
        //convert weeks to minutes
        public static void convertWeekToMinute(double week)
        {

            double result = WEEK_TO_MINUTE * week;
            Console.WriteLine("There are {1} minutes in {0} weeks", week, result);


        }


    }
}
