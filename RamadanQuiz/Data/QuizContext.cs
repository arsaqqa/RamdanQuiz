global using Microsoft.EntityFrameworkCore;
using RamadanQuiz.Models;
namespace RamadanQuiz.Data
{
    public class QuizContext:DbContext  
    
    {
        public QuizContext()
        {
        }

        public QuizContext(DbContextOptions<QuizContext> options)
            : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EmployeeAnswer >()
        //        .HasIndex(q => new { q.EmployeeId, q.q })
        //        .IsUnique();
        //}
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionOption> QuestionOption { get; set; }
        public DbSet<EmployeeAnswer> EmployeeAnswer { get; set; }
        public DbSet<CorrectAnswer> CorrectAnswer { get; set; }
        public DbSet<EmplyeeAnswerQuestion> EmplyeeAnswerQuestion { get; set; }
    }
}
