using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.Models.Configuration
{
    public class StudentExamCofiguration : IEntityTypeConfiguration<StudentExam>
    {
        public void Configure(EntityTypeBuilder<StudentExam> builder)
        {
            builder.HasKey(e => e.ID);

            builder.ToTable("Student_Exam");

            builder.HasIndex(e => e.StudentID);

            builder.HasIndex(e => e.ExamID);

           builder.HasOne(d => d.Students)
                .WithMany(p => p.StudentExams)
                .HasForeignKey(d => d.StudentID)
                .HasConstraintName("FK_Student_Exam_Student")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(d => d.Exams)
                .WithMany(p => p.StudentExams)
                .HasForeignKey(d => d.ExamID)
                .HasConstraintName("FK_Student_Exam_Exam")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
