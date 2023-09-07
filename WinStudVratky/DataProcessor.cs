using Students.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Students
{
  class DataProcessor 
  {
    private readonly IDataReader reader;
    private readonly IDataWriter writer;
    private readonly IInputDataProcessor inputDataProcessor;

    public DataProcessor(IDataReader reader, IDataWriter writer, IInputDataProcessor inputDataProcessor)
    {
      this.reader = reader;
      this.writer = writer;
      this.inputDataProcessor = inputDataProcessor;
    }

    public void Execute(string id, int firstPaymentId, DateTime dueDate,string IBAN_UKF, string inputPath, string outputPath)
    {
      var inputData = reader.Read(inputPath);
      var outputData = inputDataProcessor.GetOutputData(id, firstPaymentId, dueDate,IBAN_UKF, inputData);
      writer.Write(outputData, outputPath);
    }
  }
}
