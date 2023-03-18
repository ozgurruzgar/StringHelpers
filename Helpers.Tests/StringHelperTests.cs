using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Must_delete_more_blanks_recieved_head_and_end_statements()
        {
            //Arrange
            var statement = "   Salih Demiroğ   ";
            var expected = "Salih Demiroğ";

            //Act
            var actual = StringHelpers.DeleteToMoreBlank(statement);

            //Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void Must_delete_more_blanks_recieved_in_statements()
        {
            //Arrange
            var statement = "Salih Demiroğ  Engin   Demiroğ     Ahmet  Sait       Duran";
            var expected = "Salih Demiroğ Engin Demiroğ Ahmet Sait Duran";

            //Act
            var actual = StringHelpers.DeleteToMoreBlank(statement);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
