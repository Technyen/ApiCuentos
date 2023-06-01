namespace ApiCuentos.Services
{
    public class ServiceUsers
    {
        private readonly ServiceCosmos _serviceCosmos;

        public ServiceUsers(ServiceCosmos serviceCosmos)
        {
            _serviceCosmos = serviceCosmos; 
           
        }

        public string ObtMsj()
        {
            var result =_serviceCosmos.GetMensaje();
            return result.ToString();
        }
    
    }
}
