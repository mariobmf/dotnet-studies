using Poo.ContentContext;

namespace Poo;

class Program
{
    static void Main(string[] args)
    {
        var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objeto"));
        articles.Add(new Article("Artigo sobre C#", "csharp"));
        articles.Add(new Article("Artigo sobre .NET", "dotnet"));

        var courses = new List<Course>();
        var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop", 60, ContentContext.Enums.EContentLevel.Fundamental);
        var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp", 120, ContentContext.Enums.EContentLevel.Beginner);
        var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet", 180, ContentContext.Enums.EContentLevel.Intermediary);
        courses.Add(courseOOP);
        courses.Add(courseCsharp);
        courses.Add(courseAspNet);

        var careers = new List<Career>();
        var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
        // var careerItem1 = new CareerItem(1, "Comece por aqui", "", null);
        var careerItem1 = new CareerItem(1, "Comece por aqui", "", courseCsharp);
        var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
        var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
        careerDotNet.AddItem(careerItem1);
        careerDotNet.AddItem(careerItem2);
        careerDotNet.AddItem(careerItem3);
        careers.Add(careerDotNet);

        foreach (var career in careers)
        {
            Console.WriteLine($"Carreira: {career.Title}");
            Console.WriteLine("Conteúdo:");
            foreach (var item in career.Items)
            {
                Console.WriteLine($"{item.Order} - {item.Title}");
                if (item.IsInvalid)
                {
                    Console.WriteLine("    Erros:");
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"      - {notification.Property} - {notification.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"    - Curso: {item.Course?.Title}");
                    Console.WriteLine($"    - Nível: {item.Course?.Level}");
                }

            }
        }
    }
}
