using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTutorials.DesignPatternMVC
{
  public interface IMainView
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Sex { get; set; }
    public int Age { get; set; }
    public IEnumerable ItemsSource { get; set; }
    void SetController(MainController controller);
  }
}
