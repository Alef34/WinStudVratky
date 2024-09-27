using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Data
{
  public class InputData
  {
    public IEnumerable<Person> People { get; set; } 
  }

  public class Person
  {
    public int Nr { get; set; }
    public string Name { get; set; }
    public string  ID { get; set; }
    public string IBAN { get; set; }
    public string SWIFT { get; set; }
    public string BIC { get; set; }
    public decimal Amount { get; set; }
    public string VS { get; set; }
  }
}
