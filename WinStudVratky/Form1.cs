using Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinStudVratky
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      this.Close();

    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      try
      {
        string id;
        //do
        //{
        //  Console.WriteLine("Zadajte MsgId:");
        //  id = Console.ReadLine();
        //} while (string.IsNullOrWhiteSpace(id));

        id = txtMsgId.Text;

        //string firstPaymentIdString;
        int firstPaymentId;
        //do
        //{
        //  Console.WriteLine("Zadajte ciselne Id prvej platby:");
        //  firstPaymentIdString = Console.ReadLine();
        //} while (!int.TryParse(firstPaymentIdString, out firstPaymentId));

        int.TryParse(txtIdPrvej.Text,out firstPaymentId);

        string dueDateString;
        DateTime dueDate;
        //do
        //{
        //  Console.WriteLine("Zadajte datum splatnosti:");
        //  dueDateString = Console.ReadLine();
        //} while (!DateTime.TryParse(dueDateString, out dueDate));

        dueDate = dtpDatSplat.Value;

        var outputDataGenerator = new DataProcessor(new XslDataReader(), new XmlDataWriter("urn:iso:std:iso:20022:tech:xsd:pain.001.001.03"), new InputDataProcessor());
        var menoACestaSuboru = Constants.CestaNaUlozenieSNazvom;
        var KdeSuUdaje = Constants.CestaSUdajmi;
        outputDataGenerator.Execute(id, firstPaymentId, dueDate, 
          KdeSuUdaje, menoACestaSuboru);
        MessageBox.Show("Hotovo!!!");


      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      dtpDatSplat.Value = DateTime.Now.AddDays(1);

      txtMsgId.Text = Constants.msginfo + DateTime.Today.ToString("yyMMdd") + "-001";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var osd = new SaveFileDialog();
      osd.DefaultExt = "xml";
      osd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
      osd.InitialDirectory = "C:\\Users\\DjusoNB2\\source\repos\\Students\\Students\\bin\\Debug\\netcoreapp3.1";
      if (osd.ShowDialog() == DialogResult.OK) 
      {
        Constants.CestaNaUlozenieSNazvom =  osd.FileName;
        //Constants.MenoSuboru = Path.GetFileName (osd.FileName);
        lblCestaNaUlozenie.Text = Constants.CestaNaUlozenieSNazvom;

      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      var ofd = new OpenFileDialog();
      ofd.DefaultExt = "xls";
      ofd.Filter =
            "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
      ofd.InitialDirectory = "C:\\Users\\DjusoNB2\\source\repos\\Students\\Students\\bin\\Debug\\netcoreapp3.1";

      if (ofd.ShowDialog() == DialogResult.OK)
      {
        Constants.CestaSUdajmi =  ofd.FileName;
        //Constants.MenoSuboru = Path.GetFileName (osd.FileName);
        lblCestaSUdajmi.Text = Constants.CestaSUdajmi;

      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      var cesta = Path.GetDirectoryName(Constants.CestaNaUlozenieSNazvom);
      System.Diagnostics.Process.Start("explorer.exe", cesta);

    }
  }
}
