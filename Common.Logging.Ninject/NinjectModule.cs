using System;

namespace Common.Logging.Ninject
{
    public class NinjectModule : global::Ninject.Modules.NinjectModule
    {
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
                    result = LogManager.GetLogger("DefaultWebsiteLogger");
                }

                return result;
            });
        }
    }
}
