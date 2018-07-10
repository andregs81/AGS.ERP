﻿
namespace AGS.ERP.Domain.ValueObjects
{
    public class ValidationError
    {
        public string Message { get; set; }
        public ValidationError(string message)
        {
            this.Message = message;
        }
    }
}
