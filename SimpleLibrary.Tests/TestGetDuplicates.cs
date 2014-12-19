using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SimpleLibrary;

namespace SimpleLibrary.Tests
{
    [TestClass]
    public class TestGetDuplicates
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Input string is missing")]
        public void Test_GetDuplicates_Shows_Error_When_String_Is_Missing()
        {
            Assert.Inconclusive("test pending");
        }

        [TestMethod]
        public void Test_GetDuplicates_Returns_All_Duplicates()
        {
            Assert.Inconclusive("test pending");
        }
    }
}
