using AGS.ERP.Domain.Entities.Geografia;
using AGS.ERP.Domain.Interfaces.Repository;
using AGS.ERP.Infra.Data.Context;
using System.Linq;

namespace AGS.ERP.Infra.Data.Repository
{
    public class EstadoRepository : Repository<Estado>, IEstadoRepository
    {
        public EstadoRepository(AgsErpContext context) : base(context)
        {

        }

        public virtual Estado GetByUF(string UF)
        {
            return base.GetAll().Where(e => e.UF == UF).FirstOrDefault();
        }
    }
}
