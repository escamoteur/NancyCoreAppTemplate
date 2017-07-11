using Nancy;
using Nancy.TinyIoc;

namespace NancyCoreApp
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        private readonly IAppConfiguration appConfig;

        public Bootstrapper()
        {
        }
        
        public Bootstrapper(IAppConfiguration appConfig)
        {
            this.appConfig = appConfig;
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<IAppConfiguration>(appConfig);
        }
    }   
}