using Students.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
  public interface IInputDataProcessor
  {
    OutputData GetOutputData(string id, int firstPaymentId, DateTime dueDate,string IBAN_UKF, InputData inputData);
  }

  public class FakeInputDataProcessor : IInputDataProcessor
  {
    public OutputData GetOutputData(string id, int firstPaymentId, DateTime dueDate, string IBAN_UKF, InputData inputData)
    {
      return new OutputData
      {
        CstmrCdtTrfInitn = new CstmrCdtTrfInitn
        {
          GrpHdr = new GrpHdr
          {
            MsgId = "DB-AP-V1-2882-200207-FFzah022020"
          },
          PaymentInformations = new List<PaymentInformation>()
          {
            new PaymentInformation
            {
              PmtInfId = "N-223505"
            },
            new PaymentInformation
            {
              PmtInfId = "N-22350ascdascchjb"
            },
            new PaymentInformation
            {
              PmtInfId = "N-22350123"
            },
            new PaymentInformation
            {
              PmtInfId = "N-2235asxasx05"
            }
          }
        }
      };
    }
  }

  public class InputDataProcessor : IInputDataProcessor
  {
    public OutputData GetOutputData(string id, int firstPaymentId, DateTime dueDate,string IBAN_UKF, InputData inputData)
    {
      if (inputData == null || inputData.People == null || inputData.People.Count() == 0)
        return null;

      var dateTime = DateTime.Now;

      var outputData = new OutputData
      {
        CstmrCdtTrfInitn = new CstmrCdtTrfInitn
        {
          GrpHdr = ParseHeader(id, inputData.People),
          PaymentInformations = new List<PaymentInformation>()
        }
      };

      foreach (var person in inputData.People.Where(p => p != null))
      {
        var paymentInformations = outputData.CstmrCdtTrfInitn.PaymentInformations;
        ParsePaymentData(firstPaymentId++, paymentInformations, dueDate, IBAN_UKF, person);
      }

      return outputData;
    }
    //YYYY-MM-DDThh:mm:ss
    private GrpHdr ParseHeader(string id, IEnumerable<Person> peopleData)
    {
      return new GrpHdr
      {
        MsgId = id,
        //CreDtTm = dateTime.ToString(),
        CreDtTm = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss"),
        NbOfTxs = peopleData.Count(),
        CtrlSum = peopleData.Sum(p => p.Amount),
        InitgPty = new InitgPty
        {
          Id = new Id
          {
            OrgId = new OrgId
            {
              Othr = new Othr
              {
                Id = Constants.UniversityID,
                Issr = Constants.StateBank
              }
            }
          }
        }
      };
    }

    private void ParsePaymentData(int firstPaymentNr, List<PaymentInformation> paymentInformations, DateTime dueDate,string IBAN_UKF, Person person)
    {
      paymentInformations.Add(new PaymentInformation
      {
        PmtInfId = $"N-{firstPaymentNr++}",
        PmtMtd = Constants.PaymentMethod,
        PmtTpInf = new PmtTpInf
        {
          SvcLvl = new SvcLvl
          {
            Cd = Constants.PaymentMethodInfo
          }
        },
        ReqdExctnDt = dueDate.ToString("yyyy-MM-dd"),
        Dbtr = new Dbtr
        {
          Nm = Constants.PaymentDescription
        },
        DbtrAcct = new DbtrAcct
        {
          Id = new DbtrAcctId
          {
            IBAN = IBAN_UKF
          }
        },
        DbtrAgt = new DbtrAgt
        {
          FinInstnId = new FinInstnId
          {
            BIC = Constants.UniversityBIC
          }
        },
        ChrgBr = Constants.Discount,
        CdtTrfTxInf = ParseCdtTrfTxInf(person)
      });
    }

    private CdtTrfTxInf ParseCdtTrfTxInf(Person person)
    {
      return new CdtTrfTxInf
      {
        PmtId = new PmtId
        {
          EndToEndId = "/VS"+person.VS.Trim()+"/SS/KS"//Constants.VariableSymbol
        },
        Amt = new Amt
        {
          InstdAmt = new InstdAmt
          {
            Ccy = Constants.Currency,
            Value = person.Amount.ToString()
          }
        },
        CdtrAgt = new CdtrAgt
        {
          FinInstnId = new FinInstnId
          {
            BIC = person.SWIFT
          }
        },
        Cdtr = new Cdtr
        {
          Nm = person.Name
        },
        CdtrAcct = new CdtrAcct
        {
          Id = new CdtrAcctId
          {
            IBAN = person.IBAN
          }
        }
      };
    }
  }
}
