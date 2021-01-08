using QLTrasua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrasua.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTable = " + id + " AND status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

        public void CheckOut(int id, float totalPrice)
        {
            String query = "Update Bill set status = 1 , dateCheckOut= GETDATE() , totalPrice= " + totalPrice + " where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE TableFood SET status = N'Có người' WHERE id = " + id);
            DataProvider.Instance.ExecuteNonQuery("exec sp_InsertBill @idTable", new object[] { id });
        }


        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {

            return DataProvider.Instance.ExecuteQuery("exec sp_GetListTable  @DateCheckIn , @DateCheckOut ", new object[] { checkIn, checkOut });
        }



        public int GetNumBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }


        public int GetAllInvoice(DateTime checkIn, DateTime checkOut)
        {
            string qr = "SET DATEFORMAT DMY " +
                    "SELECT COUNT(*) FROM BILL " +
                    "WHERE DateCheckIn >= '" + checkIn.ToShortDateString() + " 00:00:01' AND DateCheckOut <= '" + checkOut.ToShortDateString() + " 23:59:59' AND status = 1";
            return (int)DataProvider.Instance.ExecuteScalar(qr);
        }
        public string GetMostValueInvoice(DateTime checkIn, DateTime checkOut)
        {
            string qr = "SET DATEFORMAT DMY " +
                "SELECT FORMAT(MAX(totalPrice), '#,### VNĐ') FROM BILL " +
                "WHERE DateCheckIn >= '" + checkIn.ToShortDateString() + " 00:00:01' AND DateCheckOut <= '" + checkOut.ToShortDateString() + " 23:59:59' AND status = 1";
            return DataProvider.Instance.ExecuteScalar(qr).ToString();
        }
        public string GetLeastValueInvoice(DateTime checkIn, DateTime checkOut)
        {
            string qr = "SET DATEFORMAT DMY " +
                "SELECT FORMAT(MIN(totalPrice), '#,### VNĐ') FROM BILL " +
                "WHERE DateCheckIn >= '" + checkIn.ToShortDateString() + " 00:00:01' AND DateCheckOut <= '" + checkOut.ToShortDateString() + " 23:59:59' AND status = 1";
            return DataProvider.Instance.ExecuteScalar(qr).ToString();
        }
        public int GetBigInvoice(DateTime checkIn, DateTime checkOut)
        {
            string qr = "SET DATEFORMAT DMY " +
                "SELECT COUNT(*) FROM BILL " +
                "WHERE totalPrice >= 200000 AND DateCheckIn >= '" + checkIn.ToShortDateString() + " 00:00:01' AND DateCheckOut <= '" + checkOut.ToShortDateString() + " 23:59:59' AND status = 1";
            return (int)DataProvider.Instance.ExecuteScalar(qr);
        }
        public string GetRevenue(DateTime checkIn, DateTime checkOut)
        {
            string qr = "SET DATEFORMAT DMY " +
                "SELECT FORMAT(SUM(totalPrice), '#,### VNĐ') FROM BILL " +
                "WHERE DateCheckIn >= '" + checkIn.ToShortDateString() + " 00:00:01' AND DateCheckOut <= '" + checkOut.ToShortDateString() + " 23:59:59' AND status = 1";
            return DataProvider.Instance.ExecuteScalar(qr).ToString();
        }

    }
}
