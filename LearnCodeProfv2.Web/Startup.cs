using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(LearnCodeProfv2.Web.Startup))]

namespace LearnCodeProfv2.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                //Rota (endereço, url)
                LoginPath= new PathString("/Autenticacao/Login")
            });                        
        
        }
    }
}
