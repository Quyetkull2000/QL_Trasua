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
    public partial class fmMenuFood : Form
    {
        public fmMenuFood()
        {
            InitializeComponent();
        }

        void LoadListFood()
        {
            dtgvFood.DataSource = FoodDAO.Instance.GetListFood();
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
    }
}
