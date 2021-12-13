
using NUnit.Framework;
using System;

namespace FizzBuzz.Library.UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void FizzBuzzerTests()
        {
            
        }

        [Test]
        public void SampleTest()
        {
          
            
        }

        [Test]
        public void Buzzer_When1_Return1()
        {
            //Arrage
            int input = 1;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("1", output);
        }
        [Test]
        public void Buzzer_When2_Return1()
        {
            //Arrage
            int input = 2;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("2", output);
        }
        [Test]
        public void Buzzer_When3_ReturnFizz()
        {
            //Arrage
            int input = 3;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_When4_Return4()
        {
            //Arrage
            int input = 4;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("4", output);
        }
        [Test]
        public void Buzzer_When5_ReturnBuzz()
        {
            //Arrage
            int input = 5;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void Buzzer_When6_ReturnFizz()
        {
            //Arrage
            int input = 6;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_When7_Return7()
        {
            //Arrage
            int input = 7;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("7", output);
        }
        [Test]
        public void Buzzer_When8_Return8()
        {
            //Arrage
            int input = 8;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("8", output);
        }
        [Test]
        public void Buzzer_When9_ReturnFizz()
        {
            //Arrage
            int input = 9;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_When10_Return10()
        {
            //Arrage
            int input = 10;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void Buzzer_When11_Return11()
        {
            //Arrage
            int input = 11;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("11", output);
        }
        [Test]
        public void Buzzer_When12_Return12()
        {
            //Arrage
            int input = 12;

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_WhenDefault_ReturnInput([Values(1,2,4,7,8,11,13,14)] int input) //general purpose test, instead of each single number for number
        {
            //Arrage
            

            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void Buzzer_WhenMultipleOf3_ReturnFizz([Values(3,6,9,12)] int input) //general purpose test for fizz
        {
            //Arrage


            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_WhenMultipleOf5_ReturnBuzz([Values(5, 10)] int input) //general purpose test for fizz
        {
            //Arrage


            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void Buzzer_WhenMultipleOf3And5_ReturnFizzBuzz([Values(15)] int input) //general purpose test for fizz
        {
            //Arrage


            //Act
            string output = FizzBuzzer.GetValue(input);
            //Assert
            Assert.AreEqual("FizzBuzz", output);
        }
        




    }
}
