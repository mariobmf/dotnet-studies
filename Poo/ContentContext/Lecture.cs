using Poo.ContentContext.Enums;
using Poo.SharedContext;

namespace Poo.ContentContext
{
  public class Lecture : Base
  {
    public Lecture(int order, string title, int durationInMinutes, EContentLevel level)
    {
      Order = order;
      Title = title;
      DurationInMinutes = durationInMinutes;
      Level = level;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
  }
}