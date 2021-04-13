using SSSM.Common.Basic;
using SSSM.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SSSM.Common.Models
{
    public class StudentModel : BaseModel, ISoftDeleted
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public string IDNumber { get; set; }

        public string InnerCode { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; } = DateTime.Today;

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; } = DateTime.Today;

        public int ClassIndex { get; set; }

        public int GradeIndex { get; set; }

        public MajorModel Major { get; set; }

        public List<CourseModel> Courses { get; set; }

        /// <summary>
        /// 照片存储路径
        /// </summary>
        public string PhotoPath { get; set; }

        /// <summary>
        /// 软删除标记
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
