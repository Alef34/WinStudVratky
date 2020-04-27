using System.Xml.Serialization;

namespace Students.Data
{
  public class PaymentInformation
  {
    public string PmtInfId { get; set; }
    public string PmtMtd { get; set; }
    public PmtTpInf PmtTpInf { get; set; }
    public string ReqdExctnDt { get; set; }
    public Dbtr Dbtr { get; set; }
    public DbtrAcct DbtrAcct { get; set; }
    public DbtrAgt DbtrAgt { get; set; }
    public string ChrgBr { get; set; }
    public CdtTrfTxInf CdtTrfTxInf { get; set; }
  }

  public class CdtTrfTxInf
  {
    public PmtId PmtId { get; set; }
    public Amt Amt { get; set; }
    public CdtrAgt CdtrAgt { get; set; }
    public Cdtr Cdtr { get; set; }
    public CdtrAcct CdtrAcct { get; set; }
  }

  public class CdtrAcct
  {
    public CdtrAcctId Id { get; set; }
  }

  public class CdtrAcctId
  {
    public string IBAN { get; set; }
  }

  public class Cdtr
  {
    public string Nm { get; set; }
  }

  public class CdtrAgt
  {
    public FinInstnId FinInstnId { get; set; }
  }

  public class Amt
  {
    public InstdAmt InstdAmt { get; set; }
  }

  public class InstdAmt
  {
    [XmlAttribute]
    public string Ccy { get; set; }
    [XmlText]
    public string Value { get; set; }
  }

  public class PmtId
  {
    public string EndToEndId { get; set; }
  }

  public class DbtrAgt
  {
    public FinInstnId FinInstnId { get; set; }
  }

  public class FinInstnId
  {
    public string BIC { get; set; }
  }

  public class DbtrAcct
  {
    public DbtrAcctId Id { get; set; }
  }

  public class DbtrAcctId
  {
    public string IBAN { get; set; }
  }

  public class PmtTpInf
  {
    public SvcLvl SvcLvl { get; set; }
  }

  public class SvcLvl
  {
    public string Cd { get; set; }
  }
  public class Dbtr
  {
    public string Nm { get; set; }
  }
}