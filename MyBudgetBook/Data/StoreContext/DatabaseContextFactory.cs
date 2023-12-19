using Microsoft.EntityFrameworkCore;

namespace MyBudgetBook.Data.DatabaseContext;

public class DatabaseContextFactory
{
    private readonly string _connectionString;


    public DatabaseContextFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public DatabaseContext CreateDbContext()
    {
        var options = new DbContextOptionsBuilder<DatabaseContext>();

        options.UseSqlServer(_connectionString);

        return new DatabaseContext(options.Options);
    }
}