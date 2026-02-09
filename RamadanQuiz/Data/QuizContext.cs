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
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionOption> QuestionOption { get; set; }
        public DbSet<EmployeeAnswer> EmployeeAnswer { get; set; }
      

    }
}
