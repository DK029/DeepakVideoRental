using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeepakVideoRental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepakVideoRental.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            // Assert.Fail();
            Form1 obj = new Form1();
        }


        [TestMethod()]
        public void VideoTest()
        {
            // Assert.Fail();
            videoData obj = new videoData();
        }


        [TestMethod()]
        public void CustomerTest()
        {
            // Assert.Fail();
            Customer obj = new Customer();
        }



    }
}