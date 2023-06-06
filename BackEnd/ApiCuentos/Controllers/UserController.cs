using ApiCuentos.Models;
using ApiCuentos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCuentos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly UserService _serviceUsers;


        public UsersController( ILogger<UsersController> logger, UserService serviceUser)
        {
            _logger = logger;
            _serviceUsers= serviceUser;
           
        }
        

      
        [HttpPost]
        public async Task<Product>  Create(Product product)
        {

            _logger.LogInformation("ggyui");

          return await _serviceUsers.CreateUser();
        }

        
    }
}
