namespace Entities.Concretes;

public class Course
{
    public int Id { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
    public string CourseThumbnail;
    public string CoursePrice;
    public int CategoryId;
}
