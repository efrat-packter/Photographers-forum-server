namespace Repository.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
        public string? ProfileImagePath { get; set; }
        public virtual ICollection<Image> Images { get; set; }

    }
}
