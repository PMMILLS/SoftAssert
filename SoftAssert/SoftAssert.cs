using NUnit.Framework;
using System;
using System.Collections;

namespace AutomationTests.ApplcationSpecificMethods
{
    public static class SoftAssert
    {
        #region Equality
        public static void AreEqual(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreEqual(int expected, int actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreEqual(double expected, double actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreEqual(float expected, float actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreEqual(decimal expected, decimal actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreEqual(object expected, object actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreNotEqual(string expected, string actual)
        {
            try
            {
                Assert.AreNotEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreNotEqual(int expected, int actual)
        {
            try
            {
                Assert.AreNotEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreNotEqual(double expected, double actual)
        {
            try
            {
                Assert.AreNotEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreNotEqual(float expected, float actual)
        {
            try
            {
                Assert.AreNotEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreNotEqual(decimal expected, decimal actual)
        {
            try
            {
                Assert.AreNotEqual(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreNotEqual(object expected, object actual)
        {
            try
            {
                Assert.AreNotEqual(expected, actual);
            }
            catch (AssertionException) { }
        }
        #endregion

        #region Identity
        public static void AreSame(object expected, object actual)
        {
            try
            {
                Assert.AreSame(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void AreNotSame(object expected, object actual)
        {
            try
            {
                Assert.AreNotSame(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void Contains(object expected, ICollection actual)
        {
            try
            {
                Assert.Contains(expected, actual);
            }
            catch (AssertionException) { }
        }
        #endregion

        #region Conparison
        public static void Greater(int arg1, int arg2)
        {
            try
            {
                Assert.Greater(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Greater(uint arg1, uint arg2)
        {
            try
            {
                Assert.Greater(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Greater(decimal arg1, decimal arg2)
        {
            try
            {
                Assert.Greater(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Greater(double arg1, double arg2)
        {
            try
            {
                Assert.Greater(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Greater(float arg1, float arg2)
        {
            try
            {
                Assert.Greater(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Greater(IComparable arg1, IComparable arg2)
        {
            try
            {
                Assert.Greater(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Less(int arg1, int arg2)
        {
            try
            {
                Assert.Less(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Less(uint arg1, uint arg2)
        {
            try
            {
                Assert.Less(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Less(decimal arg1, decimal arg2)
        {
            try
            {
                Assert.Less(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Less(double arg1, double arg2)
        {
            try
            {
                Assert.Less(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Less(float arg1, float arg2)
        {
            try
            {
                Assert.Less(arg1, arg2);
            }
            catch (AssertionException) { }
        }

        public static void Less(IComparable arg1, IComparable arg2)
        {
            try
            {
                Assert.Less(arg1, arg2);
            }
            catch (AssertionException) { }
        }
        #endregion

        #region Type
        public static void IsInstanceOf(Type expected, object actual)
        {
            try
            {
                Assert.IsInstanceOf(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void IsNotInstanceOf(Type expected, object actual)
        {
            try
            {
                Assert.IsNotInstanceOf(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void IsAssignableFrom(Type expected, object actual)
        {
            try
            {
                Assert.IsAssignableFrom(expected, actual);
            }
            catch (AssertionException) { }
        }

        public static void IsNotAssignableFrom(Type expected, object actual)
        {
            try
            {
                Assert.IsNotAssignableFrom(expected, actual);
            }
            catch (AssertionException) { }
        }
        #endregion

        #region Condition
        public static void IsTrue(bool expected)
        {
            try
            {
                Assert.IsTrue(expected);
            }
            catch (AssertionException) { }
        }

        public static void IsFalse(bool expected)
        {
            try
            {
                Assert.IsFalse(expected);
            }
            catch (AssertionException) { }
        }

        public static void IsNull(object expected)
        {
            try
            {
                Assert.IsNull(expected);
            }
            catch (AssertionException) { }
        }

        public static void IsNotNull(object expected)
        {
            try
            {
                Assert.IsNotNull(expected);
            }
            catch (AssertionException) { }
        }

        public static void IsNaN(double expected)
        {
            try
            {
                Assert.IsNaN(expected);
            }
            catch (AssertionException) { }
        }

        public static void IsEmpty(string expected)
        {
            try
            {
                Assert.IsEmpty(expected);
            }
            catch (AssertionException) { }
        }

        public static void IsNotEmpty(string expected)
        {
            try
            {
                Assert.IsNotEmpty(expected);
            }
            catch (AssertionException) { }
        }

        public static void IsEmpty(ICollection expected)
        {
            try
            {
                Assert.IsEmpty(expected);
            }
            catch (AssertionException) { }
        }

        public static void IsNotEmpty(ICollection expected)
        {
            try
            {
                Assert.IsNotEmpty(expected);
            }
            catch (AssertionException) { }
        }
        #endregion
    }
}
