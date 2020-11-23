namespace Aridos.BL.Repositories.Implements
{
    using Aridos.BL.Data;
    using Aridos.BL.Models;
    using System;

    public class FaenaRepository : GenericRepository<Faena>
    {
        public FaenaRepository(AridosContext aridosContext) : base(aridosContext)
        {
        }
    }
}
