using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalogue.Common
{
    public class OperationResult
    {
        public OperationResult(bool issucessfull, string message)
        {
            IsSuccessfull = issucessfull;
            Message = message;
        }

        public bool IsSuccessfull { get; set; }
        public string Message { get; set; }
    }

    public class OperationResult<T>
    {
        public OperationResult(bool issucessfull, string message, T value)
        {
            IsSuccessfull = issucessfull;
            Message = message;
            Value = value;
        }

        public bool IsSuccessfull { get; set; }
        public string Message { get; set; }
        public T Value { get; set; }
    }
}