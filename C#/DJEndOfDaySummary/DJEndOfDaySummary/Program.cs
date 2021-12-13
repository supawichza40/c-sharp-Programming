using System;
using System.Collections.Generic;

namespace DJEndOfDaySummary
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff nisa = new Staff("Nisa");
            nisa.AddBooking();
        }
    }
    class Staff
    {
        
        public string Name { get; set; }
        const float rate = 8.91f;
        List<Booking> bk = new List<Booking>();
        public Staff(string name)
        {
            Name = name;
        }
        public void AddBooking()
        {
            Console.WriteLine("Start Time: e.g.10am");
            string startTime = Console.ReadLine();
            Console.WriteLine("End Time: e.g. 11am");
            string endTime = Console.ReadLine();
            Console.WriteLine("Is this treatwell booking? e.g true/false");
            bool isTreatwell = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Is it Cash or Card e.g. Cash/Card");
            string cashOrCard = Console.ReadLine();
            Console.WriteLine("What is the Amount to Pay? 40.00 = £40");
            double amountToPay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the duration of the treatment? e.g. 1 00 00 == hr");
            string userTimeInput = Console.ReadLine();
            string[] arr = userTimeInput.Split(" ");

            bk.Add(new Booking(startTime, endTime, isTreatwell, cashOrCard, amountToPay, new TimeSpan(Int32.Parse(arr[0]), Int32.Parse(arr[1]), Int32.Parse(arr[2]))));
        }

    }
    class Booking
    {
        const double staffRatePerSecond = 0.006111111; 
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool IsTreatwell { get; set; }
        public string CashOrCard { get; set; }
        public double GrossAmount { get; set; }
        public double NetAmount { get; set; }
        public int PercentageOfTreatwellDeduct { get; set; }

        public TimeSpan NumberOfHours { get; set; }
        public double AmountToPayStaff { get; set; }

        public Booking(string starttime,string endtime,bool isTreatwell,string cashOrCard,double amount,TimeSpan numberOfHours)
        {
            StartTime = starttime;
            EndTime = endtime;
            IsTreatwell = isTreatwell;
            CashOrCard = cashOrCard;
            GrossAmount = amount;
            NumberOfHours = numberOfHours;
            AmountToPayStaff = CalculateAmountToPayStaff();
            if (isTreatwell)
            {
                Console.WriteLine("What is the percentage of treatwell deduct?");

                PercentageOfTreatwellDeduct = Convert.ToInt32(Console.ReadLine());
                NetAmount = (((double)(100 - PercentageOfTreatwellDeduct) / 100) * GrossAmount);
            }
        }
        public double CalculateAmountToPayStaff()
        {
            double val = NumberOfHours.TotalSeconds* staffRatePerSecond;
            return Math.Round(val, 2);
        }
        public static void PrintHeaderSummary()
        {
            Console.WriteLine($"StartTime:     - EndTime:      For: 00:00:00 Amount:£      CashOrCard  ");
        }
        public void PrintBookingSummary()
        {
            PrintHeaderSummary();
            Console.WriteLine($"          {StartTime}           {EndTime}       {NumberOfHours.ToString()}         {GrossAmount}       {CashOrCard}");
        }
        
    }
}
