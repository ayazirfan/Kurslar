
using Kurslar;

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8....";
course1.Price = 10;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Python";
course2.Description = "Python 3.21....";
course2.Price = 20;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "JAVA";
course3.Description = "JAVA 7..";
course3.Price = 30;

Course[] courses = {course1,course2,course3};

for (int i = 0; i < courses.Length; i++)
{
    System.Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    System.Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}



System.Console.WriteLine("Kod bitti...");
