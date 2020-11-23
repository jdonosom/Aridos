using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Aridos.BL.Data;

namespace Aridos.API
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configurar el DBContext para ser usado solo por una instacia por solicitud
            //
            app.CreatePerOwinContext( AridosContext.Create );

        }
    }
}
