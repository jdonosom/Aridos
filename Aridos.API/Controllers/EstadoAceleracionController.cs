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

    public class EstadoAceleracionController : ApiController
    {
        private IMapper mapper;
        private readonly EstadoAceleracionService estadoAceleracionService = 
            new EstadoAceleracionService(new EstadoAceleracionRepository(AridosContext.Create()));

        public EstadoAceleracionController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {

            var statusAccel = await estadoAceleracionService.GetAll();
            var statusAccelDTO = statusAccel.Select(x => mapper.Map<EstadoAceleracionDTO>(x));

            return Ok(statusAccelDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var StAccel = await estadoAceleracionService.GetById(id);

            if (StAccel == null)
                return NotFound();

            return Ok( mapper.Map<EstadoAceleracionDTO>(StAccel) );
        }

        [HttpPost]
        public async Task<IHttpActionResult> PostEstadoAceleracion([FromBody] EstadoAceleracionDTO AccelDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var Accel = mapper.Map<EstadoAceleracion>(AccelDTO);
                return Ok( await estadoAceleracionService.Insert(Accel) );
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
