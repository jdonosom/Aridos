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

    public class DatosAceleracionController : ApiController
    {
        private IMapper mapper;
        private readonly DatosAceleracionService datosAceleracionService =  
            new DatosAceleracionService( new DatosAceleracionRepository(AridosContext.Create()));

        public DatosAceleracionController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpPost]
        public async Task<IHttpActionResult> PostDatosAceleracion( [FromBody] DatosAceleracionDTO data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var dataAccel = mapper.Map<DatosAceleracion>(data);
                return Ok(await datosAceleracionService.Insert(dataAccel));

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
