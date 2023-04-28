using NUnit.Framework;
using StudentGrades;

namespace TestProject1
{
    public class Tests
    {
        private GradeCalculator _gradeCalculator;
        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }
        [TestCase(99)]
        [TestCase(90)]
        public void Test1(int percentage)
        {
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            var expectedGrade = "A";
            Assert.That(grade, Is.EqualTo(expectedGrade));
        }
        [TestCase(89)]
        [TestCase(80)]
        public void Test2(int percentage)
        {
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            var expectedGrade = "B";
            Assert.That(grade, Is.EqualTo(expectedGrade));
        }
        [TestCase(79)]
        [TestCase(70)]
        public void Test3(int percentage)
        {
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            var expectedGrade = "C";
            Assert.That(grade, Is.EqualTo(expectedGrade));
        }
        [TestCase(69)]
        [TestCase(60)]
        public void Test4(int percentage)
        {
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            var expectedGrade = "D";
            Assert.That(grade, Is.EqualTo(expectedGrade));
        }
        [TestCase(59)]
        [TestCase(0)]
        public void Test5(int percentage)
        {
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            var expectedGrade = "F";
            Assert.That(grade, Is.EqualTo(expectedGrade));
        }
        [TestCase(120)]
        [TestCase(-1)]
        public void Test6(int percentage)
        {
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            var expectedGrade = "Invalid";
            Assert.That(grade, Is.EqualTo(expectedGrade));
        }
    }
}