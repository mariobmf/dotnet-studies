using Poo.SharedContext;

namespace Poo.SubscriptionContext
{
  public class User : Base
  {

    public User(string username, string password)
    {
      Username = username;
      Password = password;
    }

    public string Username { get; }
    public string Password { get; set; }
  }
}