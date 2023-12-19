using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.ObjectPool;

namespace MyBudgetBook.Data.DatabaseContext;
public class DatabaseContext : DbContext
{
 
    public DatabaseContext(DbContextOptions options) : base(options) { }
  

    public virtual DbSet<Person> Persons { get; set; }


 



}
