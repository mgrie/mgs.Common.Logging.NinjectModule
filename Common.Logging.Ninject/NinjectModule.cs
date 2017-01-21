using System;

namespace Common.Logging.Ninject
{
    /// <summary>
    /// NinjectModule for Common.Logging.ILog Binding
    /// </summary>
    public class NinjectModule : global::Ninject.Modules.NinjectModule
    {
        /// <summary>
        /// Load Method for Common.Logging.ILog Binding
        /// </summary>
        public override void Load()
        {
            Bind<ILog>().ToMethod(ctx =>
            {
                ILog result;
                if (ctx.Request.ParentContext != null)
                {
                    Type type = ctx.Request.ParentContext.Request.Service;
                    result = LogManager.GetLogger(type);
                }
                else
                {
                    result = LogManager.GetLogger(Properties.Settings.Default.DefaultLoggerName);
                }

                return result;
            });
        }
    }
}
