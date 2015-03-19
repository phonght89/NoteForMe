namespace Note.Data.Model
{
    public class PasswordModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte State { get; set; }
        public byte? Type { get; set; }
        public long IdUser { get; set; }
        public string Description { get; set; }
    }
}
