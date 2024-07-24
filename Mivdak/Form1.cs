using Mivdak.Models;
using System.Windows.Forms;
using static Mivdak.Service.KetubahService;

namespace Mivdak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CriateXSMLifNotExists();
            YearCB.DataSource = ListDates.Years;

        }

        private void SendBU_Click(object sender, EventArgs e)
        {
            string day = DayWeekCB.Text;
            int mday = int.Parse( DayMonthCB.Text);
            string year = YearCB.Text;
            string month = MonthCB.Text;
            DAteKetubah DM= new DAteKetubah(day, mday, month, year);

            ResLa.Text = insertandGatRes(DM);
        }
    }
}
