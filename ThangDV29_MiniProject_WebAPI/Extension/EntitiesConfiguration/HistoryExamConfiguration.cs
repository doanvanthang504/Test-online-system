using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ThangDV29_MiniProject_WebAPI.Models.Configuration
{
    public class HistoryExamConfiguration : IEntityTypeConfiguration<HistoryExam>
    {
        public void Configure(EntityTypeBuilder<HistoryExam> builder)
        {
            builder.ToTable("History.Exam");
            builder.HasKey(k => k.ID);

            builder.HasOne(e => e.Accounts)
                   .WithMany(e => e.HistoryExams)
                   .HasForeignKey(e => e.AccountID)
                   .HasConstraintName("FK_History.Exam_Account")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Answers)
                   .WithMany(e => e.HistoryExams)
                   .HasForeignKey(e => e.AnswerID)
                   .HasConstraintName("FK_History.Exam_Answer")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Questions)
                   .WithMany(e => e.HistoryExams)
                   .HasForeignKey(e => e.QuestionID)
                   .HasConstraintName("FK_History.Exam_Question")
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
