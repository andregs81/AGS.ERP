
using AGS.ERP.Domain.ValueObjects;

namespace AGS.ERP.Domain.Interfaces.Validation
{
    public interface ISelfValidator
    {
        ValidationResult ResultadoValidacao { get; }
        bool IsValid();
    }
}
