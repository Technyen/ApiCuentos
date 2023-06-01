using ApiCuentos.Models;
using ApiCuentos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCuentos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly ServiceUsers _serviceUsers;
        private readonly ServiceCosmos _serviceCosmos;


        public UsersController( ILogger<UsersController> logger, ServiceUsers serviceUser)
        {
            _logger = logger;
            _serviceUsers= serviceUser;
           
        }
        

      
        [HttpPost]
        public  string PostUser(User user)
        {

            _logger.LogInformation("ggyui");

            return _serviceUsers.ObtMsj();
        }

        
    }
}
