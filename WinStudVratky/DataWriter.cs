using Students.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Students
{
  public interface IDataWriter
  {
    void Write(OutputData data, string path);
  }

  class XmlDataWriter : IDataWriter
  {
    private readonly string defaultNamespace;

    public XmlDataWriter(string defaultNamespace)
    {
      this.defaultNamespace = defaultNamespace;
    }

    public void Write(OutputData data, string path)
    {
      if (data == null)
        return;

      XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
      ns.Add("", defaultNamespace);
      XmlSerializer serializer = new XmlSerializer(typeof(OutputData), defaultNamespace);

      using (var writer = new StreamWriter(path))
      {
        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;
        settings.IndentChars = "\t\t";

        using (var xmlWriter = XmlWriter.Create(writer, settings))
        {
          xmlWriter.WriteProcessingInstruction("xml", @"version=""1.0"" encoding=""UTF-8"" standalone=""yes""");
          serializer.Serialize(xmlWriter, data, ns);
          xmlWriter.Close();
        }
        writer.Close();
      }
    }
  }
}
