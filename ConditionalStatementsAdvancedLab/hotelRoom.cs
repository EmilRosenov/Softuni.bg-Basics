using System;

namespace hotelRoom
{
    class hotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());
            //May, June, July, August, September или October
            //На първия ред: "Apartment: {totalPriceApartment:f2} lv."         
            //На втория ред: "Studio: {totalPriceStudio:f2} lv."
            double pricePerStudioBeforeDiscount = 0.00;
            double pricePerStudioAfterDiscount = 0.00;
            double pricePerApartmentBeforeDiscount = 0.00;
            double pricePerApartmentAfterDiscount = 0.00;
            double totalPriceApartment = 0.00;
            double totalPriceStudio = 0.00;

            string output = string.Empty;
            //За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            //За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            //За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            //За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.


            if (month == "May" || month == "October")
            {
                pricePerStudioBeforeDiscount = 50;
                pricePerApartmentBeforeDiscount = 65;
                if (numberOfNights > 14)
                {
                    pricePerStudioAfterDiscount = pricePerStudioBeforeDiscount *= 0.70;
                    totalPriceStudio = numberOfNights * pricePerStudioAfterDiscount;
                    pricePerApartmentAfterDiscount = pricePerApartmentBeforeDiscount * 0.90;
                    totalPriceApartment = numberOfNights * pricePerApartmentAfterDiscount;
                }
                else if (numberOfNights <= 14)
                {
                    pricePerStudioAfterDiscount = pricePerApartmentBeforeDiscount *= 0.95;
                    totalPriceStudio = numberOfNights * pricePerStudioAfterDiscount;
                    totalPriceApartment = numberOfNights * pricePerApartmentBeforeDiscount;
                }

                output = $"Studio: {totalPriceStudio:f2} lv.";
                output = $"Apartment: {totalPriceApartment:f2} lv.";

            }
            else if (month == "June" || month == "September")
            {
                pricePerStudioBeforeDiscount = 75.20;
                pricePerApartmentBeforeDiscount = 68.70;

                if (numberOfNights > 14)
                {
                    pricePerStudioAfterDiscount = pricePerStudioBeforeDiscount *= 0.80;
                    totalPriceStudio = numberOfNights * pricePerStudioAfterDiscount;
                    pricePerApartmentAfterDiscount = pricePerApartmentBeforeDiscount * 0.90;
                    totalPriceApartment = numberOfNights * pricePerApartmentAfterDiscount;
                }
                else if (numberOfNights <= 14)

                {
                    totalPriceStudio = pricePerStudioBeforeDiscount * numberOfNights;
                    totalPriceApartment = pricePerApartmentBeforeDiscount * numberOfNights;
                }
                output = $"Studio: {totalPriceStudio:f2} lv.";
                output = $"Apartment: {totalPriceApartment:f2} lv.";
            }
            else
            {
                pricePerStudioBeforeDiscount = 76;
                pricePerApartmentBeforeDiscount = 77;
                if (numberOfNights > 14)
                {
                    totalPriceStudio = numberOfNights * pricePerStudioBeforeDiscount;
                    pricePerApartmentAfterDiscount = pricePerApartmentBeforeDiscount * 0.90;
                    totalPriceApartment = numberOfNights * pricePerApartmentAfterDiscount;
                }
                else
                {
                    totalPriceStudio = numberOfNights * pricePerStudioBeforeDiscount;
                    totalPriceApartment = numberOfNights * pricePerApartmentBeforeDiscount;
                }
                output = $"Studio: {totalPriceStudio:f2} lv.";
                output = $"Apartment: {totalPriceApartment:f2} lv.";

            }
            Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
        }
    }
}
