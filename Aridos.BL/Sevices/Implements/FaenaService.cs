namespace Aridos.BL.Sevices.Implements
{
    using Aridos.BL.Models;
    using Aridos.BL.Repositories;
    using Aridos.BL.Services.Implements;

    public class FaenaService : GenericService<Faena>
    {
        public FaenaService(IFaenaRepository faenaRepository) : base(faenaRepository)
        {
        }
    }
}
