using Poo.SharedContext;

namespace Poo.ContentContext
{
  public class Module : Base
  {
    public Module(int order, string title)
    {
      Lectures = [];
      Order = order;
      Title = title;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public IList<Lecture> Lectures { get; set; }
  }
}