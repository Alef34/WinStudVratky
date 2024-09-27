using ExcelDataReader;
using Students.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Students
{
  public interface IDataReader
  {
    InputData Read(string path);
  }

  class XslDataReader : IDataReader
  {

    public InputData Read(string path)
    {
      var inputData = new InputData();

      Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
      using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
      {
        using (var reader = ExcelReaderFactory.CreateReader(stream))
        {
          var people = new List<Person>();
          var rowNr = 1;

          while (reader.Read())
          {
            var nr = reader.GetValue(0);
            var name = reader.GetValue(1);

            if (nr == null || string.IsNullOrWhiteSpace(nr.ToString())
              || name == null || string.IsNullOrWhiteSpace(name.ToString()))
              continue;

            try
            {
              people.Add(new Person
              {
                Nr = int.Parse(nr.ToString()),
                Name = name.ToString(),
                ID = reader.GetValue(2).ToString(),
                IBAN = reader.GetValue(3).ToString(),
                SWIFT = reader.GetValue(4).ToString(),
                BIC = reader.GetValue(5).ToString(),
                Amount = decimal.Parse(reader.GetValue(6).ToString()),
                VS= reader.GetValue(7).ToString()
              });

              Console.WriteLine($"Row {rowNr} parsed succesfully");
            }
            catch (Exception ex)
            {
              Console.WriteLine($"Invalid data on row {rowNr}, skipping...");
                            MessageBox.Show($"Invalid data on row {rowNr}, skipping...");
                        }
            rowNr++;
          }
          inputData.People = people;
        }
      }

      return inputData;
    }
  }
}
