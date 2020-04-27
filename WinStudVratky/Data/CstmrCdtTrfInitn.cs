using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Students.Data
{
  public class CstmrCdtTrfInitn
  {
    public GrpHdr GrpHdr { get; set; }

    [XmlElement(ElementName = "PmtInf")]
    public List<PaymentInformation> PaymentInformations { get; set; }
  }
}
