using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Students.Data
{
  [XmlRoot(ElementName = "Document")]
  public class OutputData
  {
    public CstmrCdtTrfInitn CstmrCdtTrfInitn { get; set; }
  }
}
