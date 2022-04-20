using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void ConstraintCTDateTestPassesCorrectly()
        {
            var ctDate = DateTime.Now.AddDays(-59);
            var actual = new CTDateConstraint().ConstraintCTDate(ctDate).ResultType;
            var expected = ResultType.PASSED;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ConstraintCTDateTestFailCorrectly()
        {
            var ctDate = DateTime.Now.AddDays(-61);
            var actual = new CTDateConstraint().ConstraintCTDate(ctDate).ResultType;
            var expected = ResultType.ACTION_LEVEL_3;
            Assert.AreEqual(expected, actual);
        }
    }
}