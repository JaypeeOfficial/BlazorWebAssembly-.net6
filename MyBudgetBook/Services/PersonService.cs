using MyBudgetBook.Data;
using MyBudgetBook.Data.DatabaseContext;

namespace MyBudgetBook.Services;

public class PersonService : IPersonService
{
    private readonly DatabaseContext _context;
    public PersonService(DatabaseContext context)
    {
        _context = context;
    }
    public bool AddUpdate(Person person)
    {
        try
        {
            if (person.Id == 0)
                _context.Persons.Add(person);
            else
                _context.Persons.Update(person);

            _context.SaveChanges();
            return true;
        }
        catch(Exception ex)
        {
            return false;
        }
    }

    public bool Delete(int id)
    {
        try
        {
            var person = FindById(id);

            if (person == null)
                return false; 

            _context.Persons.Remove(person);
            _context.SaveChanges();

            return true;
        }
        catch (Exception ex) 
        { 
            return false;
        }
    }

    public Person FindById(int id)
    {
        return _context.Persons.Find(id);
    }

    public List<Person> GetAll()
    {
        return _context.Persons.ToList();
    }
}

