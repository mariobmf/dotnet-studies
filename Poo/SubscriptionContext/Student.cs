using Poo.NotificationContext;
using Poo.SharedContext;

namespace Poo.SubscriptionContext
{
  public class Student : Base
  {
    public Student(string name, string email, User user)
    {
      Name = name;
      Email = email;
      User = user;
      Subscriptions = [];
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    public void CreateSubscription(Subscription subscription)
    {
      if (IsPremium)
      {
        AddNotification(new Notification("Premium", "O aluno já tem assinatura ativa"));
        return;
      }
      Subscriptions.Add(subscription);
    }
  }
}