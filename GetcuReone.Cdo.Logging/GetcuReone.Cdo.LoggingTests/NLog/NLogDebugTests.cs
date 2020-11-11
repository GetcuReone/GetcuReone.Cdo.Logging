using GetcuReone.Cdo.Logging;
using GetcuReone.Cdo.LoggingTests.NLog.Env;
using GetcuReone.GetcuTestAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace GetcuReone.Cdo.LoggingTests.NLog
{
    [TestClass]
    public sealed class NLogDebugTests : NlogTestBase
    {
        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();
            LevelEnabled(LogLevel.Debug);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Write info.")]
        [Timeout(Timeouts.Second.One)]
        public void WriteInfoTestCase()
        {
            const string message = "Hey!";

            GivenEmpty()
                .When("Write info.", () => 
                    GetAdapter<NLogAdapter>().Info(message))
                .Then("Check log.", () => 
                    AssertRowLog(Levels.Info, message))
                .Run();
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Write debug.")]
        [Timeout(Timeouts.Second.One)]
        public void WriteDebugTestCase()
        {
            const string message = "Hey!";

            GivenEmpty()
                .When("Write debug.", () => 
                    GetAdapter<NLogAdapter>().Debug(message))
                .Then("Check log.", () => 
                    AssertRowLog(Levels.Debug, message))
                .Run();
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Write error.")]
        [Timeout(Timeouts.Second.One)]
        public void WriteErrorTestCase()
        {
            const string message = "Hey!";

            GivenEmpty()
                .When("Write debug.", () =>
                    GetAdapter<NLogAdapter>().Error(message))
                .Then("Check log.", () =>
                    AssertRowLog(Levels.Error, message))
                .Run();
        }
    }
}
