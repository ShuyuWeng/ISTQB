using ConsoleApp1;
using StudentGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class UnitTestFractionOperations
    {
        [Test]
        public void TestFractionAddition()
        {
            FractionOperations f1 = new FractionOperations(1, 2);
            FractionOperations f2 = new FractionOperations(1, 3);
            FractionOperations expected = new FractionOperations(5, 6);
            FractionOperations result = FractionOperations.Add(f1, f2);
            Assert.That(result.Numerator, Is.EqualTo(expected.Numerator));
            Assert.That(result.Denominator, Is.EqualTo(expected.Denominator));
        }

        [Test]
        public void TestFractionSubtraction()
        {
            FractionOperations f1 = new FractionOperations(3, 4);
            FractionOperations f2 = new FractionOperations(1, 4);
            FractionOperations result = FractionOperations.Subtract(f1, f2);
            Assert.That(result,Is.EqualTo(new FractionOperations(1,2)));
        }

        [Test]
        public void TestFractionMultiplication()
        {
            FractionOperations f1 = new FractionOperations(2, 3);
            FractionOperations f2 = new FractionOperations(3, 5);
            FractionOperations result = FractionOperations.Multiply(f1, f2);
            Assert.That(result,Is.EqualTo(new FractionOperations(2, 5)));
        }

        [Test]
        public void TestFractionDivision()
        {
            FractionOperations f1 = new FractionOperations(2, 3);
            FractionOperations f2 = new FractionOperations(4, 5);
            FractionOperations result = FractionOperations.Divide(f1, f2);
            Assert.That(result,Is.EqualTo(new FractionOperations(5, 6)));
        }
    }
}
