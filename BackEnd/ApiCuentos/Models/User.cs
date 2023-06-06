using System.ComponentModel.DataAnnotations;

namespace ApiCuentos.Models
{
    public record User(
        string id,
        string name,
        string email,
        string password);
    
}
