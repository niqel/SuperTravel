using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.IRepositories
{
    public interface IUnityOfWork
    {
        public ICountryRepository CountryRepository { get; }
        public IUserRepository UserRepository { get; }
        public void SaveChange();
    }
}
