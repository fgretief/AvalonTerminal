using NUnit.Framework;

namespace AvalonTerminal.Tests
{
    [TestFixture]
    public class TerminalTests
    {
        [Test]
        public void FirstTest()
        {
            TestContext.Out.Write("Hello World");            
        }
    }
}
