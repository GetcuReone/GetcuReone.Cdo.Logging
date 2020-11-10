using GetcuReone.ComboPatterns.Adapter;
using NLog;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Linq;

namespace GetcuReone.Cdo.Logging
{
    /// <summary>
    /// Adapter for NLog.
    /// </summary>
    public class NLogAdapter : AdapterProxyBase<ILogger, string>
    {
        /// <summary>
        /// Name of the setting key in the configuration file that stores the name of the logger.
        /// </summary>
        public const string AppLoggerNameKey = "GetcuReone_Logging_NLog_LoggerName";

        private static readonly string _loggerName;

        static NLogAdapter()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationElement value = config.AppSettings.Settings[AppLoggerNameKey];

            if (value == null)
                throw new InvalidOperationException($"The configuration file does not contain application setting '{AppLoggerNameKey}'.");

            _loggerName = value.Value;
        }

        private ILogger logger => _logger ?? (_logger = CreateProxy(_loggerName));
        private ILogger _logger;

        /// <summary>
        /// Constructor.
        /// </summary>
        public NLogAdapter() : base(LogManager.GetLogger)
        {
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Debug<TArgument>(string message, TArgument argument)
        {
            if (!logger.IsDebugEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Debug(message, argOfType);
                    break;
                case double argOfType:
                    logger.Debug(message, argOfType);
                    break;
                case float argOfType:
                    logger.Debug(message, argOfType);
                    break;
                case long argOfType:
                    logger.Debug(message, argOfType);
                    break;
                case int argOfType:
                    logger.Debug(message, argOfType);
                    break;
                case string argOfType:
                    logger.Debug(message, argOfType);
                    break;
                case byte argOfType:
                    logger.Debug(message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Debug(message, argOfType);
                    break;
                case char argOfType:
                    logger.Debug(message, argOfType);
                    break;
                case uint argOfType:
                    logger.Debug(message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Debug(message, argOfType);
                    break;

                default:
                    logger.Debug(message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Debug(IFormatProvider formatProvider, string message)
        {
            if (logger.IsDebugEnabled)
                logger.Debug(formatProvider, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Debug(string message)
        {
            if (logger.IsDebugEnabled)
                logger.Debug(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Debug<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (!logger.IsDebugEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;
                case double argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;
                case float argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;
                case long argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;
                case int argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;
                case string argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;
                case byte argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;
                case char argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;
                case uint argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Debug(formatProvider, message, argOfType);
                    break;

                default:
                    logger.Debug(formatProvider, message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Debug([Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsDebugEnabled)
                return;

            logger.Debug(message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Debug(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsDebugEnabled)
                return;

            logger.Debug(formatProvider, message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level.
        /// </summary>
        /// <param name="messageFunc">A function returning message to be written.</param>
        /// <remarks>Function is not evaluated if logging is not enabled.</remarks>
        public void Debug(LogMessageGenerator messageFunc)
        {
            logger.Debug(messageFunc);
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Debug<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsDebugEnabled)
                logger.Debug(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsDebugEnabled)
                logger.Debug(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Debug<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsDebugEnabled)
                logger.Debug(message, argument1, argument2);
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsDebugEnabled)
                logger.Debug(message, argument1, argument2);
        }

        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Error(string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Error(string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Error(string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        //
        //   arg3:
        //     Third argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, object arg1, object arg2, object arg3);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, object arg1, object arg2);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Error(IFormatProvider formatProvider, object value);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level.
        //
        // Parameters:
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Error<T>(T value);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Error<T>(IFormatProvider formatProvider, T value);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level.
        //
        // Parameters:
        //   messageFunc:
        //     A function returning message to be written. Function is not evaluated if logging
        //     is not enabled.
        void Error(LogMessageGenerator messageFunc);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Error level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        void Error(Exception exception, [Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Error level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Error(Exception exception, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Error level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Error(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified parameters
        //     and formatting them with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level.
        //
        // Parameters:
        //   message:
        //     Log message.
        void Error([Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Error<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Error([Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified parameter
        //     and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Error<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Error<TArgument>([Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Error<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(IFormatProvider formatProvider, string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Error level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Error(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
        void Error([Localizable(false)] string message, Exception exception);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level.
        //
        // Parameters:
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Error(object value);
        //
        // Summary:
        //     Writes the diagnostic message at the Error level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Error(string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Error level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Error(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
        void ErrorException([Localizable(false)] string message, Exception exception);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Fatal(string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level.
        //
        // Parameters:
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Fatal(object value);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Fatal(IFormatProvider formatProvider, object value);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, object arg1, object arg2);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        //
        //   arg3:
        //     Third argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, object arg1, object arg2, object arg3);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified parameter
        //     and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Fatal<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level.
        //
        // Parameters:
        //   messageFunc:
        //     A function returning message to be written. Function is not evaluated if logging
        //     is not enabled.
        void Fatal(LogMessageGenerator messageFunc);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Fatal<T>(IFormatProvider formatProvider, T value);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level.
        //
        // Parameters:
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Fatal<T>(T value);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Fatal level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Fatal(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified parameters
        //     and formatting them with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level.
        //
        // Parameters:
        //   message:
        //     Log message.
        void Fatal([Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Fatal([Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Fatal level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
        void Fatal([Localizable(false)] string message, Exception exception);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Fatal level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Fatal(Exception exception, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Fatal level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        void Fatal(Exception exception, [Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Fatal<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Fatal<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the Fatal level using the specified parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Fatal<TArgument>([Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Fatal level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
        void FatalException([Localizable(false)] string message, Exception exception);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Info level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Info(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Info level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Info(Exception exception, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Info level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        void Info(Exception exception, [Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level.
        //
        // Parameters:
        //   messageFunc:
        //     A function returning message to be written. Function is not evaluated if logging
        //     is not enabled.
        void Info(LogMessageGenerator messageFunc);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified parameters
        //     and formatting them with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Info level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Info(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
        void Info([Localizable(false)] string message, Exception exception);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Info<TArgument>([Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Info<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        //
        //   arg3:
        //     Third argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, object arg1, object arg2, object arg3);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, object arg1, object arg2);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Info(IFormatProvider formatProvider, object value);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level.
        //
        // Parameters:
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Info(object value);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Info([Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level.
        //
        // Parameters:
        //   message:
        //     Log message.
        void Info([Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Info<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified parameter
        //     and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Info<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level.
        //
        // Parameters:
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Info<T>(T value);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Info<T>(IFormatProvider formatProvider, T value);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Info level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Info(IFormatProvider formatProvider, string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Info level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Info(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
        void InfoException([Localizable(false)] string message, Exception exception);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        //
        //   arg3:
        //     Third argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, object arg1, object arg2, object arg3);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, object arg1, object arg2);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Trace(IFormatProvider formatProvider, object value);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Trace<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level.
        //
        // Parameters:
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Trace(object value);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level.
        //
        // Parameters:
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Trace<T>(T value);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Trace<T>(IFormatProvider formatProvider, T value);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level.
        //
        // Parameters:
        //   messageFunc:
        //     A function returning message to be written. Function is not evaluated if logging
        //     is not enabled.
        void Trace(LogMessageGenerator messageFunc);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Trace level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        void Trace(Exception exception, [Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Trace level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Trace(Exception exception, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified parameters
        //     and formatting them with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level.
        //
        // Parameters:
        //   message:
        //     Log message.
        void Trace([Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Trace([Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Trace level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
        void Trace([Localizable(false)] string message, Exception exception);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified parameter
        //     and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Trace<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Trace level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Trace(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Trace<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Trace<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Trace<TArgument>([Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Trace<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Trace level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Trace(string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Trace level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
        void TraceException([Localizable(false)] string message, Exception exception);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level.
        //
        // Parameters:
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Warn(object value);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level.
        //
        // Parameters:
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Warn<T>(T value);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Warn<T>(IFormatProvider formatProvider, T value);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level.
        //
        // Parameters:
        //   messageFunc:
        //     A function returning message to be written. Function is not evaluated if logging
        //     is not enabled.
        void Warn(LogMessageGenerator messageFunc);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Warn level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        void Warn(Exception exception, [Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Warn level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Warn(Exception exception, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Warn level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Warn(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified parameters
        //     and formatting them with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level.
        //
        // Parameters:
        //   message:
        //     Log message.
        void Warn([Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Warn([Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified parameter
        //     and formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Warn<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Warn<TArgument>([Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Warn<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Warn<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level.
        //
        // Parameters:
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Warn(IFormatProvider formatProvider, object value);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, object arg1, object arg2);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified parameters.
        //
        // Parameters:
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        //
        //   arg3:
        //     Third argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, object arg1, object arg2, object arg3);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Warn level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
        void Warn([Localizable(false)] string message, Exception exception);
        //
        // Summary:
        //     Writes the diagnostic message at the Warn level using the specified value as
        //     a parameter.
        //
        // Parameters:
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Warn(string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the Warn level.
        //
        // Parameters:
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
        void WarnException([Localizable(false)] string message, Exception exception);
    }
}
