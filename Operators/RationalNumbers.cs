using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class RationalNumbers
    {
        public long numerator { get; }
        public long denominator { get; }

        public RationalNumbers(long numerator, long denominator)
        {
            if (denominator == 0) throw new ArgumentException("The denominator cannot be equal to zero.");
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static RationalNumbers operator +(RationalNumbers left, RationalNumbers right)
        {
            long numerator = left.numerator * right.denominator + right.numerator * left.denominator;
            long denominator = left.denominator * right.denominator;

            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator -(RationalNumbers left, RationalNumbers right)
        {
            long numerator = left.numerator * right.denominator - right.numerator * left.denominator;
            long denominator = left.denominator * right.denominator;

            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator *(RationalNumbers left, RationalNumbers right)
        {
            long numerator = left.numerator * right.numerator;
            long denominator = left.denominator * right.denominator;

            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator /(RationalNumbers left, RationalNumbers right)
        {
            if (left.denominator == 0) throw new DivideByZeroException("The denominator cannot be equal to zero.");

            long numerator = left.numerator * right.denominator;
            long denominator = right.numerator * left.denominator;

            return new RationalNumbers(numerator, denominator);
        }

        public static bool operator >(RationalNumbers left, RationalNumbers right)
        {
            return left.numerator * right.denominator > right.numerator * left.denominator;
        }

        public static bool operator <(RationalNumbers left, RationalNumbers right)
        {
            return left.numerator * right.denominator < right.numerator * left.denominator;
        }

        public static bool operator ==(RationalNumbers left, RationalNumbers right)
        {
            return left.numerator * right.denominator == right.numerator * left.denominator;
        }

        public static bool operator !=(RationalNumbers left, RationalNumbers right)
        {
            return left.numerator * right.denominator != right.numerator * left.denominator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}