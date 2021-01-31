using GetcuReone.GetcuTestAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GetcuReone.Cdo.LoggingTests.NLog.Env
{
    [TestClass]
    public abstract class NlogTestBase : GetcuReoneTestBase
    {
        protected string LogFolderPath { get; private set; }

        [TestInitialize]
        public virtual void Initialize()
        {
            LogFolderPath = Path.Combine(Environment.CurrentDirectory, "logs");

            if (!Directory.Exists(LogFolderPath))
                Directory.CreateDirectory(LogFolderPath);

            var factory = LogManager.LoadConfiguration("NLog/NLog.config");
            LogManager.Configuration = factory.Configuration;
            LogManager.ReconfigExistingLoggers();
        }

        [TestCleanup]
        public virtual void Cleanup()
        {
            if (Directory.Exists(LogFolderPath))
            {
                foreach (string file in Directory.GetFiles(LogFolderPath))
                    File.Delete(file);
                Directory.Delete(LogFolderPath);
            }
        }

        protected void AssertRowLog(string level, string message)
        {
            var rows = GetLogRows().Where(row => row.Level == level).ToList();

            if (rows == null || rows.Count == 0)
                Assert.Fail($"Level '{level}' row not found");
            else if (rows.All(row => row.Message != message))
                Assert.Fail($"Message '{message}' line not found");
        }

        protected List<LogRow> GetLogRows()
        {
            string file = Directory.GetFiles(LogFolderPath).Last();

            return File.ReadAllLines(file)
                .Select(row =>
                {
                    string[] parts = row.Split('|').Select(part => part.Trim()).ToArray();
                    return new LogRow
                    {
                        Level = parts[1],
                        Message = parts[2],
                    };
                })
                .ToList();
        }

        protected void LevelEnabled(LogLevel level)
        {
            var rule = LogManager.Configuration.LoggingRules[0];

            if (!rule.IsLoggingEnabledForLevel(level))
                rule.EnableLoggingForLevel(level);
        }

        protected void LevelDisabled(LogLevel level)
        {
            var rule = LogManager.Configuration.LoggingRules[0];

            if (rule.IsLoggingEnabledForLevel(level))
                rule.DisableLoggingForLevel(level);
        }
    }
}
