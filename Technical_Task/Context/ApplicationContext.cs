using Microsoft.EntityFrameworkCore;
using Technical_Task.Models;

namespace Technical_Task.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> option) : base(option)
        {

        }
        public DbSet<Step1> Step1s { get; set; }
        public DbSet<Step2> Step2s { get; set; }
    }
}
