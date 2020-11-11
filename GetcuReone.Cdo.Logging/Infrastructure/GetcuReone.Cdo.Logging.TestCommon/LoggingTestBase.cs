using GetcuReone.GetcuTestAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace GetcuReone.Cdo.Logging.TestCommon
{
    [TestClass]
    public abstract class LoggingTestBase : GetcuReoneTestBase
    {
        [TestInitialize]
        public virtual void Initialize()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
    }
}
