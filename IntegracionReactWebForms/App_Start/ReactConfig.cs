using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using React;
//using React.TinyIoC;
//using React.Web.TinyIoC;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(IntegracionReactWebForms.ReactConfig), "Configure")]

namespace IntegracionReactWebForms
{
	public static class ReactConfig
	{
		public static void Configure()
		{
			//Initializer.Initialize(AsPerRequestSingleton);

			ReactSiteConfiguration.Configuration
				//.SetLoadBabel(false)
				.AddScript("~/Scripts/reactComponents/helloWorld.jsx");

            // If you want to use server-side rendering of React components, 
            // add all the necessary JavaScript files here. This includes 
            // your components as well as all of their dependencies.
            // See http://reactjs.net/ for more information. Example:
            //ReactSiteConfiguration.Configuration
            //	.AddScript("~/Scripts/First.jsx")
            //	.AddScript("~/Scripts/Second.jsx");

            // If you use an external build too (for example, Babel, Webpack,
            // Browserify or Gulp), you can improve performance by disabling 
            // ReactJS.NET's version of Babel and loading the pre-transpiled 
            // scripts. Example:
            //ReactSiteConfiguration.Configuration
            //	.SetLoadBabel(false)
            //	.AddScriptWithoutTransform("~/Scripts/bundle.server.js")

            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();
        }

        //private static TinyIoCContainer.RegisterOptions AsPerRequestSingleton(
        //  TinyIoCContainer.RegisterOptions registerOptions)
        //{
        //    return TinyIoCContainer.RegisterOptions.ToCustomLifetimeManager(
        //        registerOptions,
        //        new HttpContextLifetimeProvider(),
        //        "per request singleton"
        //    );
        //}

    }
}