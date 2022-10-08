using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.DTOs
{
    public record ResultContainer<TResult>
    {
        private int count;
        private List<Result<TResult>> results;

        public ResultContainer(List<Result<TResult>> results)
        {
            this.count = results.Count();
            this.results = results;
        }

        public ResultContainer()
        {
            this.results = new List<Result<TResult>>();
            this.count = results.Count();
        }
    }
}
