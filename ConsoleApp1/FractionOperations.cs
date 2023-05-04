using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FractionOperations
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public FractionOperations(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero");
            Numerator = numerator;
            Denominator = denominator;
        }

        public static FractionOperations Add(FractionOperations f1, FractionOperations f2)
        {
            int numerator = f1.Numerator * f1.Denominator + f2.Numerator * f2.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            return new FractionOperations(numerator, denominator);
        }

        public static FractionOperations Subtract(FractionOperations f1, FractionOperations f2)
        {
            int numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
            return new FractionOperations(numerator, denominator);
        }

        public static FractionOperations Multiply(FractionOperations f1, FractionOperations f2)
        {
            int numerator = f1.Numerator *  f2.Numerator ;
            int denominator = f1.Denominator * f2.Denominator;
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
            return new FractionOperations(numerator, denominator);
        }

        public static FractionOperations Divide(FractionOperations f1, FractionOperations f2)
        {
            int numerator = f1.Numerator * f2.Denominator;
            int denominator = f1.Denominator * f2.Numerator;
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
            return new FractionOperations(numerator, denominator);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            FractionOperations other = (FractionOperations)obj;
            return (Numerator == other.Numerator && Denominator == other.Denominator);
        }

        public override int GetHashCode()
        {
            int hashCode = 17;
            hashCode = hashCode * 23 + Numerator.GetHashCode();
            hashCode = hashCode * 23 + Denominator.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        private static int GCD(int numerator, int denominator)
        {
            if (denominator == 0)
                return numerator;
            return GCD(denominator, numerator % denominator);
        }
    }
}
