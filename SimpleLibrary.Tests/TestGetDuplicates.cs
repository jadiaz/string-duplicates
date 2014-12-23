using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SimpleLibrary;
using System.Diagnostics;

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

        [TestMethod]
        public void Test_GetDuplicates_Performance()
        {
            string input = "hQEMA8TOxBlJIKffAQf/SHP0RMsrkCiXwGzwfVXZXmVqCdAACz0rOtnypfu5YkT5hX1tUa1osujB6JpzPGTuByPrJwNlnPRW3VaCd+pSpHwn8naFxqsvrRIwRLgFwrBP5EG4m+lq0uVWbUmeiqq5aGUx2FAjgl59hGm2T8d3RxPRgy4BqaywBwZQbnnVPW8dP6qhOIPeLjMGwyysvn+Gtm2bFSA4PRUDnnxKcVVGQrsvmD9sElYq8AqRsAcaY9ZS7e2CQCK4nl9OBALFnO8g0fMLUVzJNfA3tdjpiNhWPwfqpvxpzI4YDwPMno+9FTjWSruIkGEG0LxXc8ca2xfW/fBTIWngwftx5d5kLRyAZdLpAQXKbPxBGFcLEOqJ0phXyN08NoD6+tAm7OojmXV2k3n+5E82pmvB0rI2h9UeV1DBWpO46mjRqdXbV2qYlpl0JKJf2x+XIzg49teKguBv4C5sJngT+GSQmYA6+DaB0yC65QHCfpKccvk0Shiu3NBappIzTcfBAkBNJgwImSu7lijw4GTH1c7463qR1IlR9Dh6ESGd/ZK3M0s1TK69tB/8F7PDxTWsseNo4QiEI04E960bAgWHJ0T8wzr5nhnbkhCzjtNiZK/eJSFBt/bBxQNnAsHCZioRApH6o7FquSUownCNJSp3/cK9b7VZ7bbMo+XDwMgQkpZWqSW2xSVZdoJHbABc4mkJM5L03pcQ9dWi6nLNTCkDdcDGYlABPRTVRBhsL3RNJA7GljIDbdoicTwp0of+B878Nukwee++i8wta4fVD50sagXmX6tdhDTh5eIyQOqE8cyFws8jtHlld9Kf0tBMBJapJzErVvSJiOh9AhHFen+y6pmYrUzyARB3gT799DDwKw2foNJPcdAmnnGBISvp83+fEL+vhCvcC8CHsYyjS1uh9HRS+X6ONfUF723cm0yxe7VqodkNsYMLFlQiMbcd0vaQYKLhKxMnVIRFP5GskxPz1nBl1bZbvZ25P6VCXG3Lyx7qtOaNn+gzXjyX5kDO9w+g1EZMH8irtWAhAwCJg2b+jEJEOcNSWm2pat8nN37Z/QXJbsnOhYVXTw3soq6ChfYAYHHtNJpStAGSD/oToDu5YouPIXPgtiCZk816V0yTnFy0k7/fLanI4mxUoWz8jqqMCg9mN2Ptt6SYzHRwIj5Vvx6DHXV75mmgEQ4OnUG7qDMTIe1ZQ33gh/msKfQjjH9zqggauCA==IW7l";
            try
            {
                string dups = _stringUtils.GetDuplicates(input);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
