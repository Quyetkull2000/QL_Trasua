using QLTrasua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrasua
{
    public partial class fmListBill : Form
    {
        public fmListBill()
        {
            InitializeComponent();
            //LoadDateTimePickerBill();
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        //Mặc định picker chạy từ đầu đến cuối tháng
        //void LoadDateTimePickerBill()
        //{
        //    DateTime today = DateTime.Now;
        //    dateTimePicker1.Value = new DateTime(today.Year, today.Month, 1);
        //    dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
        //}
    }
}
