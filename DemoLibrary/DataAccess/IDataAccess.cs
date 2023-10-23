using DemoLibrary.Models;

namespace DemoLibrary.DataAccess;
public interface IDataAccess
{
    public List<PersonModel> GetPeople();
    public PersonModel InsertPerson(string firstName, string lastName);

}
