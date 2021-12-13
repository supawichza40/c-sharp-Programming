using ICalculatorInputService;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{

    public class TesMock : IkeyBoardReader
    {
        public string GetNextTokenFromKeyBoard()
        {
            return "2 +3";
        }
    }


    [TestFixture]
    public class UserInputTest
    {
        private Mock<IkeyBoardReader> _m;
        [SetUp]
        public void SetUp()
        {
            _m = new Mock<IkeyBoardReader>();
        }

        [Test]
        public void EnterTwoPlusThreeWillReturn3TimeinList()
        {
            _m.Setup(s => s.GetNextTokenFromKeyBoard()).Returns(" ");
            UserInput sut = new UserInput(_m.Object);
            List<string> x = sut.GetInput();
            Assert.AreEqual(0, x.Count);


        }
        [Test]
        public void EnterTwoPlusSpaceThreeWillReturn3ItemInList() 
        {

            _m.SetupSequence(s => s.GetNextTokenFromKeyBoard()).Returns("3")
                                                                .Returns("+")
                                                                .Returns("2")
                                                                .Returns(" ");

            UserInput sut = new UserInput(_m.Object);
            var x = sut.GetInput();
            Assert.AreEqual(3, x.Count);
        }
        [Test]
        public void GetUserInput_PassingWrongFormat_returnValidString()
        {

            _m.SetupSequence(s => s.GetNextTokenFromKeyBoard()).Returns("3")
                                                                .Returns("+")
                                                                .Returns("a")
                                                                .Returns("2")
                                                                .Returns(" ");
            UserInput sut = new UserInput(_m.Object);
            var result = sut.GetInput();
            Assert.That(result, Is.EqualTo(new List<string> { "3", "+", "2" }));
        }
        [Test]
        public void GetUserInput_PassingTwoAdjacentNumber_ReturnValidString() 
        {
            _m.SetupSequence(s => s.GetNextTokenFromKeyBoard()).Returns("3")
                                                    .Returns("+")
                                                    .Returns("3")
                                                    .Returns("2")
                                                    .Returns(" ");
            UserInput sut = new UserInput(_m.Object);
            var result = sut.GetInput();
            Assert.That(result, Is.EqualTo(new List<string> {"3","+","3"}));
        }
        [Test]
        public void GetUserInput_PassingThreeAdjacentOperator_ReturnValidString()
        {
            _m.SetupSequence(s => s.GetNextTokenFromKeyBoard()).Returns("3")
                                        .Returns("+")
                                        .Returns("+")
                                        .Returns("+")
                                        .Returns("2")
                                        .Returns(" ");
            UserInput sut = new UserInput(_m.Object);
            var result = sut.GetInput();
            Assert.That(result, Is.EqualTo(new List<string> { "3","+","2" }));
        }
        //[Test]
        //public void UserInput_UserEnterInvalidValue_ReturnError()
        //{
        //    _m.Setup(s => s.GetNextTokenFromKeyBoard()).Returns("a");
        //    UserInput sut = new UserInput(_m.Object);
        //    Assert.That(() => sut.GetInput() ,Throws.Exception.TypeOf<FormatException> ());
        //}

    }
}
