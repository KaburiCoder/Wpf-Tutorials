using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTutorials.DesignPatternMVC
{
  public class MainController
  {
    private readonly IMainView _view;
    private readonly IPersonRepository _personRepository;

    private Person GetPerson()
    {
      return new Person
      {
        Id = _view.Id,
        Name = _view.Name,
        Age = _view.Age,
        Sex = _view.Sex,
      };
    }

    private bool IsValidSave(Person person)
    {
      if (person.Id <= 0)
      {
        return false;
      }

      if (string.IsNullOrWhiteSpace(person.Name))
      {
        return false;
      }

      return true;
    }

    private void LoadPerson(Person? person = null)
    {
      _view.Id = person?.Id ?? 0;
      _view.Name = person?.Name ?? "";
      _view.Sex = person?.Sex ?? "";
      _view.Age = person?.Age ?? 0;
    }

    public MainController(IMainView mainView, IPersonRepository personRepository)
    {
      _view = mainView;
      _personRepository = personRepository;

      _view.SetController(this);
      DisplayItemsToListView();
    }

    internal bool Save()
    {
      Person person = GetPerson();
      if (!IsValidSave(person)) return false;

      return _personRepository.SaveOne(person);
    }

    internal bool Delete()
    {
      return _personRepository.DeleteOne(_view.Id);
    }

    internal void Cancel()
    {
      LoadPerson();
    }   

    internal void DisplayItemsToListView()
    {
      _view.ItemsSource = _personRepository.GetAll()!;
    }

    internal void LoadPerson(object dataContext)
    {
      LoadPerson(dataContext as Person);      
    }
  }
}
