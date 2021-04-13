using SSSM.Common.Common;
using SSSM.Common.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSSM.Common.Models
{
    public class StudentModel : BaseModel, ISoftDeleted
    {
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Display(Name = "性别")]
        public Gender Gender { get; set; }

        [Display(Name = "身份证号")]
        public string IDNumber { get; set; }

        [Display(Name = "学生证号")]
        public string InnerCode { get; set; }

        [Display(Name = "出生日期")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; } = DateTime.Today;

        [Display(Name = "入学日期")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; } = DateTime.Today;

        [Display(Name = "班级")]
        public SchoolClassModel SchoolClass { get; set; }

        [Display(Name = "专业")]
        public MajorModel Major { get; set; }

        [Display(Name = "课程")]
        public List<CourseModel> Courses { get; set; }

        [Display(Name = "年龄")]
        [NotMapped]
        public int Age => BirthDate == null ? 0 : DateTimeHelper.CalcAge(BirthDate.Value);

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
