namespace WebAPI.Entities
{
    public class ApplicationUser : BaseEntity
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
    }
}
