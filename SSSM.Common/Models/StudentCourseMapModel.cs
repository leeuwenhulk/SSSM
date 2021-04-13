using SSSM.Common.Basic;

namespace SSSM.Common.Models
{
    public class StudentCourseMapModel : BaseModel
    {
        public StudentModel Student { get; set; }

        public CourseModel Course { get; set; }
    }
}
