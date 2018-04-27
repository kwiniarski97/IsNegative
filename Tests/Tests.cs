using System;

using Xunit;

namespace Tests
{
    using IsNegative;

    public class Tests
    {
        [Fact]
        public void CanTellFalseForRightInput()
        {
            sbyte numberByte = 1;
            short numberShort = 1;
            int numerInt = 1;
            long numberLong = 1L;
            float numberFloat = 1.0F;
            double numberDouble = 1.0D;
            decimal numberDecimal = 1;
            Assert.False(IsNegative.Check(numberByte));
            Assert.False(IsNegative.Check(numberShort));
            Assert.False(IsNegative.Check(numerInt));
            Assert.False(IsNegative.Check(numberLong));
            Assert.False(IsNegative.Check(numberFloat));
            Assert.False(IsNegative.Check(numberDouble));
            Assert.False(IsNegative.Check(numberDecimal));
        }

        [Fact]
        public void CanTellFor0()
        {
            sbyte numberByte = 0;
            short numberShort = 0;
            int numerInt = 0;
            long numberLong = 0;
            float numberFloat = 0;
            double numberDouble = 0;
            decimal numberDecimal = 0;
            Assert.False(IsNegative.Check(numberByte));
            Assert.False(IsNegative.Check(numberShort));
            Assert.False(IsNegative.Check(numerInt));
            Assert.False(IsNegative.Check(numberLong));
            Assert.False(IsNegative.Check(numberFloat));
            Assert.False(IsNegative.Check(numberDouble));
            Assert.False(IsNegative.Check(numberDecimal));
        }

        [Fact]
        public void CanTellTrueForRightInput()
        {
            sbyte numberByte = -1;
            short numberShort = -1;
            int numerInt = -1;
            long numberLong = -1L;
            float numberFloat = -1.0F;
            double numberDouble = -1.0D;
            decimal numberDecimal = -1;
            Assert.True(IsNegative.Check(numberByte));
            Assert.True(IsNegative.Check(numberShort));
            Assert.True(IsNegative.Check(numerInt));
            Assert.True(IsNegative.Check(numberLong));
            Assert.True(IsNegative.Check(numberFloat));
            Assert.True(IsNegative.Check(numberDouble));
            Assert.True(IsNegative.Check(numberDecimal));
        }

        [Fact]
        public void CanTellForMaxValues()
        {
            sbyte numberByte = sbyte.MaxValue;
            short numberShort = short.MaxValue;
            int numerInt = int.MaxValue;
            long numberLong = long.MaxValue;
            float numberFloat = float.MaxValue;
            double numberDouble = double.MaxValue;
            decimal numberDecimal = decimal.MaxValue;
            Assert.False(IsNegative.Check(numberByte));
            Assert.False(IsNegative.Check(numberShort));
            Assert.False(IsNegative.Check(numerInt));
            Assert.False(IsNegative.Check(numberLong));
            Assert.False(IsNegative.Check(numberFloat));
            Assert.False(IsNegative.Check(numberDouble));
            Assert.False(IsNegative.Check(numberDecimal));
        }

        [Fact]
        public void CanTellForMinValues()
        {
            sbyte numberByte = sbyte.MinValue;
            short numberShort = short.MinValue;
            int numerInt = int.MinValue;
            long numberLong = long.MinValue;
            float numberFloat = float.MinValue;
            double numberDouble = double.MinValue;
            decimal numberDecimal = decimal.MinValue;
            Assert.True(IsNegative.Check(numberByte));
            Assert.True(IsNegative.Check(numberShort));
            Assert.True(IsNegative.Check(numerInt));
            Assert.True(IsNegative.Check(numberLong));
            Assert.True(IsNegative.Check(numberFloat));
            Assert.True(IsNegative.Check(numberDouble));
            Assert.True(IsNegative.Check(numberDecimal));
        }
    }
}