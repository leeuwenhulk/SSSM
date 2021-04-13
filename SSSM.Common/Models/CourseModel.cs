using SSSM.Common.Basic;
using SSSM.Common.Enums;
using System.Collections.Generic;

namespace SSSM.Common.Models
{
    public class CourseModel : BaseNameModel
    {
        public CourseType Type { get; set; }

        public MajorModel Major { get; set; }

        /// <summary>
        /// 选课学生
        /// </summary>
        public List<StudentModel> Students { get; set; }
    }
}
