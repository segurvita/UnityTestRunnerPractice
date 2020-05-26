using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestScriptEditModeWithoutAsm
    {
        [Test]
        public void MyClassTest1()
        {
            var x = new MyClassWithoutAsm();
            Assert.IsEmpty(x.GetName());
            x.SetName("Alice");
            Assert.AreEqual("Alice", x.GetName());
        }

        [Test]
        public void MyClassTest2()
        {
            var x = new MyClassWithoutAsm("Bob");
            Assert.AreEqual("Bob", x.GetName());
        }
    }
}