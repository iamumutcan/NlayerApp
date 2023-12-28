namespace Nlayer.Core.Model
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int ParentID { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
