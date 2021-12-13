using System;

namespace CovarianceContravariance
{
    class Program
    {
        //Must be declared before the function but inside a class.
        //Why do we need to do this? 
        //I think it will define in the program segment, so when call, it will run
        delegate Small covarDel(Big mc);
        
        static void Main(string[] args)
        {
            //Covariance allow the base class to hold the derive class but not the opposite.

            Small sm = new Small();
            Big bg = new Big();
            //The polymorphism and covariance allow us to do this
            Small sm_bgInstance = new Big();

            //Not the Opposite
            //Big big_smInstance = new Small();//Compile error

            sm_bgInstance.PrintSmall(); //we can only run function of a small eventhought it an instance of a big.
            covarDel del = Method1;
            del += Method2;
            del += Method3;
            del += Method4;
            del(new Big());//This is contravariance - we can pass the derived class where the base class is expected, since if we pass small class, then it will not have a function for a big class.
            //The covariance and contravariance will generate compile error even before its run.


            

        }
        static Big Method1(Big bg)
        {
            bg.PrintBig();
            Console.WriteLine("Method1");
            return new Big();
        }
        static Small Method2(Big bg)
        {
            bg.PrintBig();
            Console.WriteLine("Method2");
            return new Small();
        }
        static Small Method3(Small cm)
        {
            cm.PrintSmall();
            Console.WriteLine("Method3");
            return new Small();
        }
        static Big Method4(Small sm)
        {
            sm.PrintSmall();
            Console.WriteLine("Method4");
            return new Big();
        }
    }

    class Small
    {
        public void PrintSmall()
        {
            Console.WriteLine("I am part of small");
        }
    }
    class Big : Small
    {
        public void PrintBig()
        {
            Console.WriteLine("I am part of Big");
        }
    }
    class Bigger: Big
    {
        public void PrintBigger()
        {
            Console.WriteLine("I am part of Bigger");
        }
    }
}
