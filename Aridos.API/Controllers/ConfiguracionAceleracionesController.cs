namespace Aridos.API.Controllers
{
    using Aridos.BL.Data;
    using Aridos.BL.DTOs;
    using Aridos.BL.Models;
    using Aridos.BL.Repositories.Implements;
    using Aridos.BL.Sevices.Implements;
    using AutoMapper;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Http;

    public class ConfiguracionAceleracionesController : ApiController
    {
        private IMapper mapper;
        private readonly DatosConfiguracionAceleracionesService datosConfiguracionAceleraciones =
            new DatosConfiguracionAceleracionesService(new DatosConfiguracionAceleracionesRepository(AridosContext.Create()));

        public ConfiguracionAceleracionesController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpPost]
        public async Task<IHttpActionResult> PostConfiguracionAceleraciones( [FromBody] DatosConfiguracionAceleracionesDTO data )
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var config = mapper.Map<DatosConfiguracionAceleraciones>(data);
                return Ok(await datosConfiguracionAceleraciones.Insert(config));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }


    }
}
