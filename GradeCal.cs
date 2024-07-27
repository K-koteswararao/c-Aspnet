using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student2;

namespace StdTest.nUnitTests
{
    public class GradeCal
    {
        private StdTest st { get; set; } = null;
        [SetUp]
        public void SetUp()
        {
            st=new Std()
        }
        [Test]
        public void GetPercentage_Test1()
        {
            //Assign
            var percentage = 98;
            //Act
            var grade = st.GetPercentage(percentage);
            //Assertion
            Assert.AreEqual("A+", grade);
        }
    }
}
