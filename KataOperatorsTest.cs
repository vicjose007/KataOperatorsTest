using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Kata2Test
{
    [TestClass]
    public class TextTest
    {
        [Fact]
        public int Validate_Operators()
        {
            TestOp obj = new TestOp();

            bool value = obj.TestOperators();

            Assert.IsTrue(value);

            return 0;
        }

    }
}
