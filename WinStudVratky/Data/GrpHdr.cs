using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Data
{
  public class GrpHdr
  {
    public string MsgId { get; set; }
    public string CreDtTm { get; set; }
    public int NbOfTxs { get; set; }
    public decimal CtrlSum { get; set; }
    public InitgPty InitgPty { get; set; }
  }

  public class InitgPty
  {
    public Id Id { get; set; }
  }

  public class Id
  {
    public OrgId OrgId { get; set; }
  }

  public class OrgId
  {
    public Othr Othr { get; set; }
  }

  public class Othr
  {
    public string Id { get; set; }
    public string Issr { get; set; }
  }
}
