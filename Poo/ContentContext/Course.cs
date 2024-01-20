using Poo.ContentContext.Enums;

namespace Poo.ContentContext
{
  public class Course : Content
  {

    public Course(string title, string url, int durationInMinutes, EContentLevel level)
      : base(title, url)
    {
      Modules = [];
      DurationInMinutes = durationInMinutes;
      Level = level;
    }
    public IList<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
  }
}