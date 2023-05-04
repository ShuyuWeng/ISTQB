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
    public class UnitTestFractionOperations2
    {
        [Test]
        public void TestFractionSubtraction()
        {
            FractionOperations f1 = new FractionOperations(3, 4);
            FractionOperations f2 = new FractionOperations(1, 4);
            FractionOperations result = FractionOperations.Subtract(f1, f2);
            Assert.That(result, Is.EqualTo(new FractionOperations(1, 2)));
        }

        [Test]
        public void TestFractionEdgeCases()
        {
            // Test 1: Zero denominator should throw exception
            Assert.Throws<ArgumentException>(() => new FractionOperations(1, 0));

            // Test 2: Adding fractions with different denominators
            FractionOperations f1 = new FractionOperations(1, 2);
            FractionOperations f2 = new FractionOperations(1, 3);
            FractionOperations expected = new FractionOperations(5, 6);
            FractionOperations result = FractionOperations.Add(f1, f2);
            Assert.That(result, Is.EqualTo(expected));

            // Test 3: Subtracting fractions with different denominators
            f1 = new FractionOperations(3, 4);
            f2 = new FractionOperations(1, 4);
            expected = new FractionOperations(1, 2);
            result = FractionOperations.Subtract(f1, f2);
            Assert.That(result, Is.EqualTo(expected));

            // Test 4: Multiplying fractions with negative numerator and denominator
            f1 = new FractionOperations(-2, 3);
            f2 = new FractionOperations(3, -5);
            expected = new FractionOperations(2, 5);
            result = FractionOperations.Multiply(f1, f2);
            Assert.That(result, Is.EqualTo(expected));

            // Test 5: Dividing fractions with negative numerator and denominator
            f1 = new FractionOperations(-2, 3);
            f2 = new FractionOperations(4, -5);
            expected = new FractionOperations(5, 6);
            result = FractionOperations.Divide(f1, f2);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
