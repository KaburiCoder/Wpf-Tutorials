using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace WpfTutorials.DesignPatternMVC
{
  public class PersonRepository : IPersonRepository
  {
    private List<Person> GetPeople()
    {
      IEnumerable<Person>? people = GetAll();

      List<Person> list;
      if (people == null)
      {
        list = new List<Person>();
      }
      else
      {
        list = people.ToList();
      }
      return list;
    }

    private void SaveSettings(IEnumerable<Person> people)
    {
      string jsonData = JsonSerializer.Serialize<IEnumerable<Person>>(people);

      Properties.Settings? settings = new Properties.Settings { PersonJsonData = jsonData };
      settings.Save();
    }

    public bool DeleteOne(int id)
    {
      List<Person> people = GetPeople();
      Person? person = people.Find(x => x.Id == id);

      if (person == null) return false;

      people.Remove(person);

      SaveSettings(people);
      return true;
    }

    public bool SaveOne(Person person)
    {
      List<Person> people = GetPeople();
      Person? findPerson = people.Find(p => p.Id == person.Id);
      if (findPerson != null)
      {
        findPerson.Update(person);
      }
      else
      {
        people.Add(person);
      }

      SaveSettings(people);

      return true;
    }

    public bool Exist(int id)
    {
      IEnumerable<Person>? people = GetAll();
      return people?.Any(p => p.Id == id) ?? false;
    }

    public IEnumerable<Person>? GetAll()
    {
      string json = new Properties.Settings().PersonJsonData;
      return string.IsNullOrEmpty(json)
        ? null
        : JsonSerializer.Deserialize<IEnumerable<Person>>(json);
    }
  }
}
