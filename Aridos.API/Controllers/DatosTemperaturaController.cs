namespace Aridos.API.Controllers
{
    using Aridos.BL.Data;
    using Aridos.BL.DTOs;
    using Aridos.BL.Models;
    using Aridos.BL.Repositories.Implements;
    using Aridos.BL.Sevices.Implements;
    using AutoMapper;
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;

    public class DatosTemperaturaController : ApiController
    {
        private IMapper mapper;
        private readonly DatosTemperaturaService datosTemperaturaService =
            new DatosTemperaturaService(new DatosTemperaturaRepository(AridosContext.Create()));

        public DatosTemperaturaController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpPost]
        public async Task<IHttpActionResult> PostDatosTemperatura([FromBody] DatosTemperaturaDTO data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var dataTemp = mapper.Map<DatosTemperatura>(data);
                return Ok(await datosTemperaturaService.Insert(dataTemp));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
