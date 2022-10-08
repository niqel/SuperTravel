using SuperTravel.Core.IRepositories;
using SuperTravel.Infrastructure.EFcoreSqlServer.DataConfiguration;

namespace SuperTravel.Infrastructure.UnityOfWork
{
    public class Unity : IUnityOfWork
    {
        private readonly SuperTravelDbContext superTravelDbContext;
        private readonly ICountryRepository countryRepository;
        private readonly IUserRepository userRepository;

        public SuperTravelDbContext SuperTravelDbContext { get => superTravelDbContext; }
        public ICountryRepository CountryRepository { get => countryRepository; }
        public IUserRepository UserRepository { get => userRepository; }

        public Unity(SuperTravelDbContext superTravelDbContext, ICountryRepository countryRepository, IUserRepository userRepository)
        {
            this.superTravelDbContext = superTravelDbContext;
            this.countryRepository = countryRepository;
            this.userRepository = userRepository;
        }

        public void SaveChange()
        {
            this.superTravelDbContext.SaveChanges();
        }
    }
}