
using QuanLyQuanTrasua.DAO;
using QuanLyQuanTrasua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTrasua.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            //Lấy ra menu gồm: Tên, Giá và Tổng tiền của bàn 
            string query = "Select Food.name , BillInfo.count , Food.price, Food.price*BillInfo.count totalPrice from BillInfo, Bill, Food where BillInfo.idBill = Bill.id and BillInfo.idFood = Food.id and Bill.idTable=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
