using Core.Entities;

namespace Entities.DTOs
{
    public class UserWhoIsCustomerDto : IDto
    {
        public string email { get; set; }
        public int userId { get; set; }
        public int customerId { get; set; }
        public string CompanyName { get; set; }
        public int FindeksScore { get; set; }
    }
}
