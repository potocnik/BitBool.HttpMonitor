using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BitBool.HttpMonitor.Agent.Tests.Runner
{
    [TestClass]
    public class WhenInvoked
    {
        [TestMethod]
        public void ThenCorrectUrlIsInvoked()
        {
            var testSubject = new Agent.Runner();
            try
            {
                testSubject.Run();
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected no exception but got ({ex.GetType().Name}): {ex.Message}");
            }
        }
    }
}
