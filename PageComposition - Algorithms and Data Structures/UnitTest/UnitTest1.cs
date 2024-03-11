using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PageInput pageIn = new PageInput(Format.Fill, 5, 0, 0, new List<String>(new String[] { "abc", "abc" }));
            Page page = pageIn.Compose();
            String actual = page.ToString();
            Assert.AreEqual("abc\nabc\n", actual);
        }
    }
    //[TestClass]
    //public class MyTestClass
    //{
    //    [TestMethod]
    //    public void MyTestMethod()
    //    {
    //        if (str.Length > 3)
    //        {
    //            if (CountVowel(str) < 2)
    //            {
    //                return false;
    //            }
    //        }
    //        else if (CountVowel(str) < 1)// check if string length > 3 skips this
    //        {
    //            return false;
    //        }
    //    }
    //}
}
