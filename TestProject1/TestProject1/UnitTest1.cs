using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var challenge = "  Text processing in C# is really great!   ";
            challenge.Trim().Substring(24, challenge.Trim().Length -25).ToUpper().Trim()

        }
    }
}
