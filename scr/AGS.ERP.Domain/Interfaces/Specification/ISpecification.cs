using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Domain.Interfaces.Specification
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T Entity);
    }
}
