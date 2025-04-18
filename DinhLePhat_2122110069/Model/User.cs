namespace DinhLePhat_2122110069.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } // "admin" hoặc "user"
    }
}
