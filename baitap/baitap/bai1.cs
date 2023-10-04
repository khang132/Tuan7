using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Form1 : Form
    {
        List<string> ListName;
        List<Product> productList;
        public Form1()
        {
            InitializeComponent();
            ListName = new List<string>();
            productList = new List<Product>();
            productList.Add(new Product("banh bao", 1, 10000));
            productList.Add(new Product("Banh nhan dau xanh", 2, 15000));
            productList.Add(new Product("que cay", 3, 5000));
            productList.Add(new Product("banh beo", 4, 2000));
            productList.Add(new Product("Banh dau", 5, 15000));
        }
        private void Timkiem(object sender, EventArgs e)
        {
            foreach (Product ele in productList)
            {
                bool logic = Convert.ToInt16(txtTimKiem.Text) == ele.getCode();
                if (logic)
                {
                    txtKetQua.Text = ele.getName() + "\t" + ele.getGia();
                }

            }
        }
        private void ADD(object sender, EventArgs e)
        {
            ListName.Add(txtTimKiem.Text);
            txtTimKiem.Text = Convert.ToString(ListName.Count);


        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
        private void Ketqua(object sender, EventArgs e)
        {

        }

        private void Thanhtoan(object sender, EventArgs e)
        {

        }




    }
}
