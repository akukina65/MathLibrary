using System;
using Xunit;
using MathLibrary;

namespace MathLibrary.Tests
{
    public class Class1Tests
    {
        private readonly Class1 _logic = new Class1();

        [Fact]
        public void AndOperation_TrueAndTrue_ReturnsTrue()
        {
            Assert.True(_logic.AndOperation(true, true));
        }

        [Fact]
        public void AndOperation_TrueAndFalse_ReturnsFalse()
        {
            Assert.False(_logic.AndOperation(true, false));
        }

        [Fact]
        public void OrOperation_TrueAndFalse_ReturnsTrue()
        {
            Assert.True(_logic.OrOperation(true, false));
        }

        [Fact]
        public void NotOperation_True_ReturnsFalse()
        {
            Assert.False(_logic.NotOperation(true));
        }

        [Fact]
        public void ConOperation_TrueAndFalse_ReturnsTrue()
        {
            Assert.True(_logic.ConOperation(true, false));
        }

        [Fact]
        public void Evaluate_TrueString_ReturnsTrue()
        {
            Assert.True(_logic.Evaluate("TRUE"));
        }

        [Fact]
        public void Evaluate_FalseString_ReturnsFalse()
        {
            Assert.False(_logic.Evaluate("FALSE"));
        }

        [Fact]
        public void Evaluate_InvalidString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _logic.Evaluate("Invalid"));
        }

        [Fact]
        public void Evaluate_EmptyString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _logic.Evaluate(""));
        }
    }
}