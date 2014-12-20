using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SimpleLibrary;

namespace SimpleLibrary.Tests
{
    [TestClass]
    public class TestGetDuplicates
    {
        StringUtilities _stringUtils;

        [TestInitialize]
        public void Setup ()
        {
            _stringUtils = new StringUtilities();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Input string is missing")]
        public void Test_GetDuplicates_Shows_Error_When_String_Is_Missing()
        {
            try
            {
                _stringUtils.GetDuplicates(null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Input string is empty")]
        public void Test_GetDuplicates_Shows_Error_When_String_Is_Empty()
        {
            try
            {
                _stringUtils.GetDuplicates(string.Empty);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        [TestMethod]
        public void Test_GetDuplicates_Returns_All_Duplicates()
        {
            string input = "asdfasdf";
            try
            {
                Assert.AreEqual("asdf", _stringUtils.GetDuplicates(input));
            }
            catch (Exception)
            {
                throw;
            }
        }

        [TestMethod]
        public void Test_GetDuplicates_Returns_Only_Distinct_Characters()
        {
            string input = "aaa11122233334455666";

            try
            {
                Assert.AreEqual("a123456", _stringUtils.GetDuplicates(input));
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
