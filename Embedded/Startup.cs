using Owin;
using Microsoft.Owin;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Owin.StaticFiles;
using Microsoft.Owin.FileSystems;

namespace Embedded
{
    public class Startup
    {
        // Invoked once at startup to configure your application.
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();

            FileServerOptions options = new FileServerOptions();
            options.StaticFileOptions.ServeUnknownFileTypes = true;
            options.EnableDirectoryBrowsing = true;

            app.UseFileServer(options);
        }
    }
}
