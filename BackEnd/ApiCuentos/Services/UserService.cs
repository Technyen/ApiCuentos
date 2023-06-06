using ApiCuentos.Models;

namespace ApiCuentos.Services
{
    public class UserService
    {
        private readonly CosmosService _serviceCosmos;

        public UserService(CosmosService serviceCosmos)
        {
            _serviceCosmos = serviceCosmos; 
        }


        public  async Task<Product> CreateUser()
        {
            var result = await _serviceCosmos.CreateItemAsync();
            return result;
        }
    
    }
}
