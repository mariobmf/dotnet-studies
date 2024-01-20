using Poo.SharedContext;

namespace Poo.SubscriptionContext
{
  public class Subscription : Base
  {
    public Subscription(Plan plan, DateTime? endTime)
    {
      Plan = plan;
      EndTime = endTime;
    }

    public Plan Plan { get; set; }
    public DateTime? EndTime { get; set; }
    public bool IsInactive => EndTime <= DateTime.Now;
  }
}