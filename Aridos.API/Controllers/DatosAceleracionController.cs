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

    [RoutePrefix("api/Aceleraciones")]
    public class DatosAceleracionController : ApiController
    {
        private IMapper mapper;
        private readonly DatosAceleracionService datosAceleracionService =  
            new DatosAceleracionService( new DatosAceleracionRepository(AridosContext.Create()));

        public DatosAceleracionController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var accels = await datosAceleracionService.GetAll();
            var accelsDTO = accels.Select(x => mapper.Map<DatosAceleracionDTO>(x));

            return Ok(accelsDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var accel = await datosAceleracionService.GetById(id);

            if (accel == null)
                return NotFound();

            var accelDTO = mapper.Map<DatosAceleracionDTO>(accel);

            return Ok(accelDTO);
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
