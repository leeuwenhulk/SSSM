using SSSM.Common.Models.Common;
using System.Collections.Generic;

namespace SSSM.Common.Models
{
    public class MajorModel : BaseNameModel, ISoftDeleted
    {
        /// <summary>
        /// 上级学科
        /// </summary>
        public virtual MajorModel Parent { get; set; }

        /// <summary>
        /// 子学科
        /// </summary>
        public List<MajorModel> Childs { get; set; }

        public List<CourseModel> Courses { get; set; }

        public bool IsDeleted { get; set; }
    }
}
