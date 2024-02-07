namespace Kurslar;

public class CourseManager
{
    Course [] courses = new Course[3];
  public CourseManager()
  {
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

courses[0] = course1;
courses[1] = course2;
courses[2] = course3;

  }  
  public Course[] GetAll()
  {
    return courses;
  }  
}