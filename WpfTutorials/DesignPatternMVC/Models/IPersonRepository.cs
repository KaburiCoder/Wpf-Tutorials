using System.Collections.Generic;

namespace WpfTutorials.DesignPatternMVC
{
  public interface IPersonRepository
  {
    IEnumerable<Person>? GetAll();
    bool SaveOne(Person person); 
    bool DeleteOne(int id);
    bool Exist(int id);
  }
}