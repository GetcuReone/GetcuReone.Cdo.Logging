using GetcuReone.Cdo.Configuration;
using GetcuReone.ComboPatterns.Adapter;
using NLog;
using System;
using System.ComponentModel;

namespace GetcuReone.Cdo.Logging
{
    /// <summary>
    /// Adapter for NLog.
    /// </summary>
    public class NLogAdapter : AdapterProxyBase<ILogger, string>
    {
        private static readonly string _loggerName;

        static NLogAdapter()
        {
            var value = GrConfigManager.Current.Logging[GrConfigKeys.Logging.NlogLoggerName];

            if (value != null)
                _loggerName = value.Value;
            else
                throw new InvalidOperationException($"The configuration file does not contain application setting '{GrConfigKeys.Logging.NlogLoggerName}'.");
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

        /// <summary>
        /// Writes the diagnostic message at the Error level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Error(IFormatProvider formatProvider, string message)
        {
            if (logger.IsErrorEnabled)
                logger.Error(formatProvider, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Error(string message)
        {
            if (logger.IsErrorEnabled)
                logger.Error(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Error<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (!logger.IsErrorEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;
                case double argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;
                case float argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;
                case long argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;
                case int argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;
                case string argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;
                case byte argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;
                case char argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;
                case uint argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Error(formatProvider, message, argOfType);
                    break;

                default:
                    logger.Error(formatProvider, message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Error([Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsErrorEnabled)
                return;

            logger.Error(message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Error(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsErrorEnabled)
                return;

            logger.Error(formatProvider, message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level.
        /// </summary>
        /// <param name="messageFunc">A function returning message to be written.</param>
        /// <remarks>Function is not evaluated if logging is not enabled.</remarks>
        public void Error(LogMessageGenerator messageFunc)
        {
            logger.Error(messageFunc);
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Error<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsErrorEnabled)
                logger.Error(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level using the specified parameters.
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
        public void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsErrorEnabled)
                logger.Error(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Error<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsErrorEnabled)
                logger.Error(message, argument1, argument2);
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsErrorEnabled)
                logger.Error(message, argument1, argument2);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Fatal<TArgument>(string message, TArgument argument)
        {
            if (!logger.IsFatalEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Fatal(message, argOfType);
                    break;
                case double argOfType:
                    logger.Fatal(message, argOfType);
                    break;
                case float argOfType:
                    logger.Fatal(message, argOfType);
                    break;
                case long argOfType:
                    logger.Fatal(message, argOfType);
                    break;
                case int argOfType:
                    logger.Fatal(message, argOfType);
                    break;
                case string argOfType:
                    logger.Fatal(message, argOfType);
                    break;
                case byte argOfType:
                    logger.Fatal(message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Fatal(message, argOfType);
                    break;
                case char argOfType:
                    logger.Fatal(message, argOfType);
                    break;
                case uint argOfType:
                    logger.Fatal(message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Fatal(message, argOfType);
                    break;

                default:
                    logger.Fatal(message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Fatal(IFormatProvider formatProvider, string message)
        {
            if (logger.IsFatalEnabled)
                logger.Fatal(formatProvider, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Fatal(string message)
        {
            if (logger.IsFatalEnabled)
                logger.Fatal(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Fatal<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (!logger.IsFatalEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;
                case double argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;
                case float argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;
                case long argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;
                case int argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;
                case string argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;
                case byte argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;
                case char argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;
                case uint argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Fatal(formatProvider, message, argOfType);
                    break;

                default:
                    logger.Fatal(formatProvider, message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Fatal([Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsFatalEnabled)
                return;

            logger.Fatal(message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Fatal(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsFatalEnabled)
                return;

            logger.Fatal(formatProvider, message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level.
        /// </summary>
        /// <param name="messageFunc">A function returning message to be written.</param>
        /// <remarks>Function is not evaluated if logging is not enabled.</remarks>
        public void Fatal(LogMessageGenerator messageFunc)
        {
            logger.Fatal(messageFunc);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Fatal<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsFatalEnabled)
                logger.Fatal(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level using the specified parameters.
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
        public void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsFatalEnabled)
                logger.Fatal(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Fatal<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsFatalEnabled)
                logger.Fatal(message, argument1, argument2);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsFatalEnabled)
                logger.Fatal(message, argument1, argument2);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Info<TArgument>(string message, TArgument argument)
        {
            if (!logger.IsInfoEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Info(message, argOfType);
                    break;
                case double argOfType:
                    logger.Info(message, argOfType);
                    break;
                case float argOfType:
                    logger.Info(message, argOfType);
                    break;
                case long argOfType:
                    logger.Info(message, argOfType);
                    break;
                case int argOfType:
                    logger.Info(message, argOfType);
                    break;
                case string argOfType:
                    logger.Info(message, argOfType);
                    break;
                case byte argOfType:
                    logger.Info(message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Info(message, argOfType);
                    break;
                case char argOfType:
                    logger.Info(message, argOfType);
                    break;
                case uint argOfType:
                    logger.Info(message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Info(message, argOfType);
                    break;

                default:
                    logger.Info(message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Info(IFormatProvider formatProvider, string message)
        {
            if (logger.IsInfoEnabled)
                logger.Info(formatProvider, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Info(string message)
        {
            if (logger.IsInfoEnabled)
                logger.Info(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Info<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (!logger.IsInfoEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;
                case double argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;
                case float argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;
                case long argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;
                case int argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;
                case string argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;
                case byte argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;
                case char argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;
                case uint argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Info(formatProvider, message, argOfType);
                    break;

                default:
                    logger.Info(formatProvider, message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Info([Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsInfoEnabled)
                return;

            logger.Info(message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Info(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsInfoEnabled)
                return;

            logger.Info(formatProvider, message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level.
        /// </summary>
        /// <param name="messageFunc">A function returning message to be written.</param>
        /// <remarks>Function is not evaluated if logging is not enabled.</remarks>
        public void Info(LogMessageGenerator messageFunc)
        {
            logger.Info(messageFunc);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Info<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsInfoEnabled)
                logger.Info(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level using the specified parameters.
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
        public void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsInfoEnabled)
                logger.Info(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Info<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsInfoEnabled)
                logger.Info(message, argument1, argument2);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsInfoEnabled)
                logger.Info(message, argument1, argument2);
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Trace<TArgument>(string message, TArgument argument)
        {
            if (!logger.IsTraceEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Trace(message, argOfType);
                    break;
                case double argOfType:
                    logger.Trace(message, argOfType);
                    break;
                case float argOfType:
                    logger.Trace(message, argOfType);
                    break;
                case long argOfType:
                    logger.Trace(message, argOfType);
                    break;
                case int argOfType:
                    logger.Trace(message, argOfType);
                    break;
                case string argOfType:
                    logger.Trace(message, argOfType);
                    break;
                case byte argOfType:
                    logger.Trace(message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Trace(message, argOfType);
                    break;
                case char argOfType:
                    logger.Trace(message, argOfType);
                    break;
                case uint argOfType:
                    logger.Trace(message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Trace(message, argOfType);
                    break;

                default:
                    logger.Trace(message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Trace(IFormatProvider formatProvider, string message)
        {
            if (logger.IsTraceEnabled)
                logger.Trace(formatProvider, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Trace(string message)
        {
            if (logger.IsTraceEnabled)
                logger.Trace(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Trace<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (!logger.IsTraceEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;
                case double argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;
                case float argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;
                case long argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;
                case int argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;
                case string argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;
                case byte argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;
                case char argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;
                case uint argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Trace(formatProvider, message, argOfType);
                    break;

                default:
                    logger.Trace(formatProvider, message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Trace([Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsTraceEnabled)
                return;

            logger.Trace(message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Trace(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsTraceEnabled)
                return;

            logger.Trace(formatProvider, message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level.
        /// </summary>
        /// <param name="messageFunc">A function returning message to be written.</param>
        /// <remarks>Function is not evaluated if logging is not enabled.</remarks>
        public void Trace(LogMessageGenerator messageFunc)
        {
            logger.Trace(messageFunc);
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Trace<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsTraceEnabled)
                logger.Trace(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level using the specified parameters.
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
        public void Trace<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsTraceEnabled)
                logger.Trace(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Trace<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsTraceEnabled)
                logger.Trace(message, argument1, argument2);
        }

        /// <summary>
        /// Writes the diagnostic message at the Trace level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Trace<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsTraceEnabled)
                logger.Trace(message, argument1, argument2);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Warn<TArgument>(string message, TArgument argument)
        {
            if (!logger.IsWarnEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Warn(message, argOfType);
                    break;
                case double argOfType:
                    logger.Warn(message, argOfType);
                    break;
                case float argOfType:
                    logger.Warn(message, argOfType);
                    break;
                case long argOfType:
                    logger.Warn(message, argOfType);
                    break;
                case int argOfType:
                    logger.Warn(message, argOfType);
                    break;
                case string argOfType:
                    logger.Warn(message, argOfType);
                    break;
                case byte argOfType:
                    logger.Warn(message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Warn(message, argOfType);
                    break;
                case char argOfType:
                    logger.Warn(message, argOfType);
                    break;
                case uint argOfType:
                    logger.Warn(message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Warn(message, argOfType);
                    break;

                default:
                    logger.Warn(message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Warn(IFormatProvider formatProvider, string message)
        {
            if (logger.IsWarnEnabled)
                logger.Warn(formatProvider, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Warn(string message)
        {
            if (logger.IsWarnEnabled)
                logger.Warn(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Warn<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            if (!logger.IsWarnEnabled)
                return;

            switch (argument)
            {
                case decimal argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;
                case double argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;
                case float argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;
                case long argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;
                case int argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;
                case string argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;
                case byte argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;
                case sbyte argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;
                case char argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;
                case uint argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;
                case ulong argOfType:
                    logger.Warn(formatProvider, message, argOfType);
                    break;

                default:
                    logger.Warn(formatProvider, message, argument);
                    break;
            }
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Warn([Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsWarnEnabled)
                return;

            logger.Warn(message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level using the specified value as
        /// a parameter and formatting it with the supplied format provider.
        /// </summary>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="args">Arguments to format..</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        public void Warn(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
            if (!logger.IsWarnEnabled)
                return;

            logger.Warn(formatProvider, message, args);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level.
        /// </summary>
        /// <param name="messageFunc">A function returning message to be written.</param>
        /// <remarks>Function is not evaluated if logging is not enabled.</remarks>
        public void Warn(LogMessageGenerator messageFunc)
        {
            logger.Warn(messageFunc);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Warn<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsWarnEnabled)
                logger.Warn(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level using the specified parameters.
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
        public void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            if (logger.IsWarnEnabled)
                logger.Warn(message, argument1, argument2, argument3);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Warn<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsWarnEnabled)
                logger.Warn(message, argument1, argument2);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level using the specified parameters.
        /// </summary>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A string containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [MessageTemplateFormatMethod("message")]
        public void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            if (logger.IsWarnEnabled)
                logger.Warn(message, argument1, argument2);
        }
    }
}
