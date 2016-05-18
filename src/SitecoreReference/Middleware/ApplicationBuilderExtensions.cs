using Microsoft.AspNet.Builder;
using Microsoft.AspNet.FileProviders;
using Microsoft.AspNet.StaticFiles;
using System.IO;

namespace Microsoft.Extensions.PlatformAbstractions
{
    static public class ApplicationBuilderExtensions
    {
        private const string NODE_MODULES_FOLDER_NAME = "node_modules";
        private const string CONTENT_FOLDER_NAME = "Content";
        private const string SCRIPTS_FOLDER_NAME = "Scripts";
        private const string IMAGES_FOLDER_NAME = "images";
        private const string FONTS_FOLDER_NAME = "fonts";

        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, IApplicationEnvironment env)
        {
            return BuildPhysicalFileProvider(app, env, NODE_MODULES_FOLDER_NAME);
        }

        public static IApplicationBuilder UseContentFolder(this IApplicationBuilder app, IApplicationEnvironment env)
        {
            return BuildPhysicalFileProvider(app, env, CONTENT_FOLDER_NAME);
        }

        public static IApplicationBuilder UseScriptsFolder(this IApplicationBuilder app, IApplicationEnvironment env)
        {
            return BuildPhysicalFileProvider(app, env, SCRIPTS_FOLDER_NAME);
        }

        public static IApplicationBuilder UseImagesFolder(this IApplicationBuilder app, IApplicationEnvironment env)
        {
            return BuildPhysicalFileProvider(app, env, IMAGES_FOLDER_NAME);
        }

        public static IApplicationBuilder UseFontsFolder(this IApplicationBuilder app, IApplicationEnvironment env)
        {
            return BuildPhysicalFileProvider(app, env, FONTS_FOLDER_NAME);
        }

        private static IApplicationBuilder BuildPhysicalFileProvider(this IApplicationBuilder app, IApplicationEnvironment env, string folderName)
        {
            var path = Path.Combine(env.ApplicationBasePath, folderName);
            var provider = new PhysicalFileProvider(path);
            var options = new StaticFileOptions();
            options.RequestPath = "/" + folderName;
            options.FileProvider = provider;
            app.UseStaticFiles(options);
            return app;
        }
    }
}
