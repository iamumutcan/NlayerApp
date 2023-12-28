
namespace Nlayer.Core.Model
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public string TCKN { get; set; }
        public string WalletAddress { get; set; }
        public bool IsActive { get; set; }
        public virtual IEnumerable<UserAddress> UserAddress { get; set; }

    }
}
