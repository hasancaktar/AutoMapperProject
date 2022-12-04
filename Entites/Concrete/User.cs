using Core.Entity;

namespace Entites.Concrete
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Status { get; set; }
        
    }
   
}