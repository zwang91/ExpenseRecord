using Microsoft.EntityFrameworkCore;
using ExpenseRecord.Item;
using System.Data.Entity;

namespace WebApplication2
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)  // options: 告诉程序连的数据库
        {

        }

        public DbSet<RecordItem> RecordItem { get; set; }
    }
}
