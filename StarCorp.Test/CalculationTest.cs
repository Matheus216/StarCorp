using NUnit.Framework;
using StarCorp.Business;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Calculation_BasicRetuns()
        {
            Calculate calc = new Calculate();


            Assert.AreEqual("StarCorpianos", calc.Calculation(15));
            Assert.AreEqual("StarCorp", calc.Calculation(3));
            Assert.AreEqual("Type indefined", calc.Calculation(-5));
            Assert.AreEqual("Type indefined", calc.Calculation(0));
            Assert.AreEqual("IT", calc.Calculation(35));
            Assert.AreEqual("IT", calc.Calculation(5555555));
        }

        [Test]
        public void ExtensionsMethod_IsNumberValidTest()
        {
            int[] testNumbers = { -1, 0, 1, 2, 3, 4, 21 };
            

            Assert.IsFalse(testNumbers[0].IsNumberValid());
            Assert.IsFalse(testNumbers[1].IsNumberValid());
            Assert.IsTrue(testNumbers[2].IsNumberValid());
            Assert.IsTrue(testNumbers[3].IsNumberValid());
            Assert.IsTrue(testNumbers[4].IsNumberValid());
            Assert.IsTrue(testNumbers[5].IsNumberValid());
            Assert.IsTrue(testNumbers[6].IsNumberValid());
        }
         
        [Test]
        public void ExtensionsMethod_IsMultiples()
        {
            int[] values = { 15, 30, 45, 1 , 5, 3};
            int[] testNumbers = { 3, 5 };


            Assert.IsTrue(values[0].IsMultiple(testNumbers));
            Assert.IsTrue(values[1].IsMultiple(testNumbers));
            Assert.IsTrue(values[2].IsMultiple(testNumbers));
            Assert.IsFalse(values[3].IsMultiple(testNumbers));
            Assert.IsFalse(values[4].IsMultiple(testNumbers));
            Assert.IsFalse(values[5].IsMultiple(testNumbers));
        }
    }
}