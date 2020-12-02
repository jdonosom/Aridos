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

    public class DatosActualizacionEstadosController : ApiController
    {
        IMapper mapper;
        private readonly DatosActualizacionEstadosService datosActualizacionEstadosService =
            new DatosActualizacionEstadosService(new DatosActualizacionEstadosRepository(AridosContext.Create()));

        public DatosActualizacionEstadosController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var data = await datosActualizacionEstadosService.GetAll();
            var dataDTO = data.Select(x => mapper.Map<DatosActualizacionEstadosDTO>(x));

            return Ok(dataDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById (int id)
        {
            var data = await datosActualizacionEstadosService.GetById(id);

            if (data == null)
                return NotFound();

            var dataDTO = mapper.Map<DatosActualizacionEstadosDTO>(data);

            return Ok(dataDTO);
        }

        [HttpPost]
        public async Task<IHttpActionResult> PostDatosActualizacionEstados( [FromBody] DatosActualizacionEstadosDTO data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var datatmp = mapper.Map<DatosActualizacionEstados>(data);
                return Ok(await datosActualizacionEstadosService.Insert(datatmp) );
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


    }


}
