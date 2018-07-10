using AGS.ERP.Application.Interfaces;
using AGS.ERP.Application.Validation;
using AGS.ERP.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.ERP.Application.Services
{
    public class AppServiceBase : IAppServiceBase
    {
        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        protected ValidationAppResult DomainToApplicationResult(ValidationResult result)
        {
            var validationAppResult = new ValidationAppResult();

            foreach (var validationError in result.Erros)
            {
                validationAppResult.Erros.Add(new ValidationAppError(validationError.Message));
            }
            validationAppResult.IsValid = result.IsValid;

            return validationAppResult;
        }
    }
}
