using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.DTOs
{
    public class MyException
    {
        private ExceptionType? exceptionType;
        private Exception? exception;

        public ExceptionType? ExceptionType { get; set; }
        public Exception? Exception { get; set; }
    }

    public enum ExceptionType
    {
        Critical, Warning, Error
    }
}
