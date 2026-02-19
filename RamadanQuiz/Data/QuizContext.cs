global using Microsoft.EntityFrameworkCore;
using RamadanQuiz.Models;
using RamadanQuiz.ViewModels;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CorrectAnswer>()
                .HasNoKey();
            modelBuilder.Entity<EmplyeeAnswerQuestion>().HasNoKey();
            modelBuilder.Entity<vResults>().HasNoKey();
            modelBuilder.Entity<vEmployeeResults>().HasNoKey();
        }


        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionOption> QuestionOption { get; set; }
        public DbSet<EmployeeAnswer> EmployeeAnswer { get; set; }
        public DbSet<CorrectAnswer> CorrectAnswer { get; set; }
        public DbSet<EmplyeeAnswerQuestion> EmplyeeAnswerQuestion { get; set; }
        public DbSet<vResults> vResults { get; set; }
        public DbSet<vEmployeeResults> vEmployeeResults { get; set; }
        
    }
}
