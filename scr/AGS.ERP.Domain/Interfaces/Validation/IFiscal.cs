using AGS.ERP.Domain.ValueObjects;

namespace AGS.ERP.Domain.Interfaces.Validation
{
    public interface IFiscal<in TEntity>
    {
        ValidationResult Validar(TEntity entity);
    }
}
