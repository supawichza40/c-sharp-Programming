using System;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleInsuranceCutomerProfile vehicle = new VehicleInsuranceCutomerProfile();
            
            Console.WriteLine(vehicle.isLoyalCustomer());
        }
    }
    //class InsurancePremiumDiscountCalculator
    //{
    //    public int calculatePremiumDiscountPercent(HealthInsuranceCustomerProfile customer)
    //    {
    //        if (customer.isLoyalCustomer())
    //        {
    //            return 20;
    //        }
    //        return 0;

    //    }
    //}
    class InsurancePremiumDiscountCalculator
    {
        public int calculatePremiumDiscountPercent(ICustomerProfile customer)
        {
            if (customer.isLoyalCustomer())
            {
                return 20;
            }
            return 0;
        }
    }
    //class HealthInsuranceCustomerProfile
    //{
    //    public bool isLoyalCustomer()
    //    {
    //        return true;
    //    }
    //}
    class HealthInsuranceCustomerProfile : ICustomerProfile
    {
        public bool isLoyalCustomer()
        {
            return true;
        }
    }
    //Right now the company is only doing HealthInsurance
    //What if the company would like to expand and accept a Vehicle Insurance, can you design a class so that it is an open/close principle.
    //class VehicleInsuranceCustomerProfile
    //{
    //    public bool isLoyalCustomer()
    //    {
    //        return true;
    //    }
    //}
    class VehicleInsuranceCutomerProfile : ICustomerProfile
    {
        public bool isLoyalCustomer()
        {
            Random ran = new Random();
            var result = ran.Next(0, 2);
            return Convert.ToBoolean(result);
        }
    }

    interface ICustomerProfile
    {
        public bool isLoyalCustomer();
    }
    //Normally we would need to change the calculatepremiumdiscountpercentage, but this would violate the open/close principle.therefore

    //As you can see, now we do not need to change the code and it allow us to extend other type of insurance in the future.
}
