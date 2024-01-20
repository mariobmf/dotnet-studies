using Poo.NotificationContext;

namespace Poo.SharedContext
{
  public abstract class Base : Notifiable
  {
    public Base()
    {
      Id = Guid.NewGuid();
    }
    public Guid Id { get; }

  }
}