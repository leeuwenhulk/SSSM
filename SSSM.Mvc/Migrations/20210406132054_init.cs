using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSSM.Common.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentId = table.Column<long>(type: "INTEGER", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Majors_Majors_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Majors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "schoolGrades",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schoolGrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    MajorId = table.Column<long>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Majors_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Majors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "schoolClasses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SchoolGradeId = table.Column<long>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schoolClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_schoolClasses_schoolGrades_SchoolGradeId",
                        column: x => x.SchoolGradeId,
                        principalTable: "schoolGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    IDNumber = table.Column<string>(type: "TEXT", nullable: true),
                    InnerCode = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SchoolClassId = table.Column<long>(type: "INTEGER", nullable: true),
                    MajorId = table.Column<long>(type: "INTEGER", nullable: true),
                    PhotoPath = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Majors_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Majors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_schoolClasses_SchoolClassId",
                        column: x => x.SchoolClassId,
                        principalTable: "schoolClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseModelStudentModel",
                columns: table => new
                {
                    CoursesId = table.Column<long>(type: "INTEGER", nullable: false),
                    StudentsId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseModelStudentModel", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseModelStudentModel_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseModelStudentModel_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourseMaps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentId = table.Column<long>(type: "INTEGER", nullable: true),
                    CourseId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseMaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentCourseMaps_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourseMaps_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseModelStudentModel_StudentsId",
                table: "CourseModelStudentModel",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_MajorId",
                table: "Courses",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_Majors_ParentId",
                table: "Majors",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_schoolClasses_SchoolGradeId",
                table: "schoolClasses",
                column: "SchoolGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseMaps_CourseId",
                table: "StudentCourseMaps",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseMaps_StudentId",
                table: "StudentCourseMaps",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_MajorId",
                table: "Students",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolClassId",
                table: "Students",
                column: "SchoolClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseModelStudentModel");

            migrationBuilder.DropTable(
                name: "StudentCourseMaps");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Majors");

            migrationBuilder.DropTable(
                name: "schoolClasses");

            migrationBuilder.DropTable(
                name: "schoolGrades");
        }
    }
}
