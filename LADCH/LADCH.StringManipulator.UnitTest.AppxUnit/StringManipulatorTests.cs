using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LADCH.StringManipulator.UnitTest.AppxUnit
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ReverseString_WhenGivenInput_ReturnsReversedString()
        {
            StringManipulator manipulator = new StringManipulator();
            string input = "Hello";


            string result = manipulator.ReverseString(input);

            Assert.Equal("olleH", result);
        }

        [Fact]
        public void RemoveSpaces_WhenGivenInput_ReturnsStringWithoutSpaces()
        {

            StringManipulator manipulator = new StringManipulator();
            string input = "Hello World";

            string result = manipulator.RemoveSpaces(input);

            Assert.Equal("HelloWorld", result);
        }
    }
}
