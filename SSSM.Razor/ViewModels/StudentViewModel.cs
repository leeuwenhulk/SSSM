using SSSM.Common;
using SSSM.Common.Enums;
using SSSM.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static SSSM.Common.Helper;

namespace SSSM.Razor.ViewModels
{
    public class StudentViewModel
    {
        public static StudentViewModel MakeFrom(StudentModel model)
        {
            return new StudentViewModel()
            {
                model = model,
                Name = model.Name,
                Gender = model.Gender,
                IDNumber = model.IDNumber,
                InnerCode = model.InnerCode,
                BirthDate = model.BirthDate,
                EnrollmentDate = model.EnrollmentDate,
                SchoolClass = new SchoolClass { ClassIndex = model.ClassIndex, GradeIndex = model.GradeIndex },
                Courses = model.Courses
            };
        }
        public static StudentModel MakeTo(StudentViewModel vmodel, StudentModel model = null)
        {
            if (model is null)
            {
                model = new StudentModel();
            }
            model.Name = vmodel.Name;
            model.Gender = vmodel.Gender;
            model.IDNumber = vmodel.IDNumber;
            model.InnerCode = vmodel.InnerCode;
            model.BirthDate = vmodel.BirthDate;
            model.EnrollmentDate = vmodel.EnrollmentDate;
            model.ClassIndex = vmodel.SchoolClass.ClassIndex;
            model.GradeIndex = vmodel.SchoolClass.GradeIndex;
            model.Courses = vmodel.Courses;
            return model;
        }


        private StudentModel model;

        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Display(Name = "性别")]
        public Gender Gender { get; set; }

        [Display(Name = "身份证号")]
        public string IDNumber { get; set; }

        [Display(Name = "学生证号")]
        public string InnerCode { get; set; }

        [Display(Name = "出生日期")]
        public DateTime? BirthDate { get; set; } = DateTime.Today;

        [Display(Name = "入学日期")]
        public DateTime EnrollmentDate { get; set; } = DateTime.Today;

        [Display(Name = "年龄")]
        public int? Age => BirthDate == null ? null : Helper.CalcAge(BirthDate.Value);

        [Display(Name = "班级")]
        public SchoolClass SchoolClass { get; set; }

        [Display(Name = "课程")]
        public List<CourseModel> Courses { get; set; }
    }
}
