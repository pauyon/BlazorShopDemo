namespace BlazorShopDemo.BlazorServer.Authentication
{
    public class UserSession
    {
        public string UserName { get; set; }
        public string Email { get; set; } = "test@test.com";
        public string Role { get; set; }
    }
}