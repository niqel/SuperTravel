using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.DTOs
{
    public record Result<TResult>
    {
        private TResult? result;
        private MyException? exception;

        public Result(TResult result, MyException exception)
        {
            this.result = result;
            this.exception = exception;
        }
    }
}
