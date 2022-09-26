using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThangDV29_MiniProject_WebAPI.Models.Table;

namespace ThangDV29_MiniProject_WebAPI.Models.Configuration
{
    public class QuestionAnswerConfiguration : IEntityTypeConfiguration<QuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<QuestionAnswer> builder)
        {
            builder.HasKey(e => e.ID);
            builder.ToTable("Question.Answer");

            builder.HasOne(e => e.Questions)
                  .WithMany(e => e.QuestionAnswers)
                  .HasForeignKey(e => e.QuestionID)
                  .HasConstraintName("FK_Questions.Answer_Question")
                  .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Answers)
                   .WithMany(e => e.QuestionAnswers)
                   .HasForeignKey(e => e.AnswerID)
                   .HasConstraintName("FK_Questions.Answer_Answer  ")
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
