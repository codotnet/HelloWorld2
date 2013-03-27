using NUnit.Framework;
using HelloWorld2;

namespace NUnitTest1
{
    [TestFixture]
    public class TestFixture1
    {
        [Test]
        public void TestTrue()
        {
           HelloWorld2.Program.Go("sss");
        }

        // This test fail for example, replace result or delete this test to see all tests pass
        [Test]
        public void TestFault()
        {
            HelloWorld2.Program.Go(null);
        }
    }
}
