namespace Poo.ContentContext
{
  public class Career : Content
  {

    public Career(string title, string url)
      : base(title, url)
    {
      Items = [];
    }
    public IList<CareerItem> Items { get; }
    public int TotalCourses => Items.Count;

    public void AddItem(CareerItem item)
    {
      Items.Add(item);
    }
  }
}