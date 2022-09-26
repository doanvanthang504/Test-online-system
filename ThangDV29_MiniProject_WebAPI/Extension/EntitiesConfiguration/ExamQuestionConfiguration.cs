using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ThangDV29_MiniProject_WebAPI.Models.Configuration
{
    public class ExamQuestionConfiguration : IEntityTypeConfiguration<ExamQuestion>
    {
        public void Configure(EntityTypeBuilder<ExamQuestion> builder)
        {
            builder.ToTable("Exam.Question");
            builder.HasKey(k => k.ID);

            builder.HasOne(e => e.Questions)
                   .WithMany(e => e.QuestionExams)
                   .HasForeignKey(e => e.QuestionID)
                   .HasConstraintName("FK_Exam.Question_Question")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Exams)
                   .WithMany(e => e.ExamQuestions)
                   .HasForeignKey(e => e.ExamID)
                   .HasConstraintName("FK_Exam.Question_Exam  ")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Teacher)
                   .WithMany(e => e.ExamQuestions)
                   .HasForeignKey(e => e.TeacherID)
                   .HasConstraintName("FK_Exam.Question_Teacher")
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
