using SSSM.Common.Basic;

namespace SSSM.Common.Models
{
    public class TeacherCourseMapModel : BaseModel
    {
        public TeacherModel Student { get; set; }

        public CourseModel Course { get; set; }
    }
}
