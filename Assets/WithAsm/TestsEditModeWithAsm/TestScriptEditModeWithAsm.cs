using NUnit.Framework;

namespace Tests
{
    public class TestScriptEditModeWithAsm
    {
        [Test]
        public void MyClassTest1()
        {
            var x = new MyClassWithAsm();
            Assert.IsEmpty(x.GetName());
            x.SetName("Alice");
            Assert.AreEqual("Alice", x.GetName());
        }

        [Test]
        public void MyClassTest2()
        {
            var x = new MyClassWithAsm("Bob");
            Assert.AreEqual("Bob", x.GetName());
        }
    }
}