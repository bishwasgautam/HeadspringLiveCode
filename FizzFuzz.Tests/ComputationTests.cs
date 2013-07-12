using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Headspring.Computations.Tests
{
    [TestClass]
    public class ComputationTests
    {
        private Computation instant;

        [TestInitialize]
        public void Initialize()
        {
            instant = new Computation();
        }

        //Checks if instant is instantiated
        [TestMethod]
        public void CheckIfComputationInstanceIsNotNull()
        {
            Assert.IsNotNull(instant);
        }

        //Checks to see if returned value is null
        [TestMethod]
        public void PassLegitValueResultNotNull()
        {
            string result = instant.FizzBuzz(15, 15);

            Assert.IsNotNull(result);
        }

        //Passes 3, result should be "FIZZ"
        [TestMethod]
        public void PassIntegerThreeResultIsFizz()
        {
            string result = instant.FizzBuzz(3, 3);

            //Check result not null
            Assert.IsNotNull(result);

            //Compare and verify result
            Assert.AreEqual(result.Trim(), "FIZZ");
        }

        //Passes 5, result should be "BUZZ"
        [TestMethod]
        public void PassIntegerFiveResultIsBuzz()
        {
            string result = instant.FizzBuzz(5, 5);

            //Check result is not null
            Assert.IsNotNull(result);

            //Compare and verify result
            Assert.AreEqual(result.Trim(), "BUZZ");
        }
    }
}