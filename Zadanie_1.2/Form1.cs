using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_1._2
{
    public partial class Form1 :Form
    {
        Shop myshop = new Shop();
        public Form1 ()
        {
            InitializeComponent();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            if(NameBox.Text =="" || priceNum.Value == 0 || countNum.Value == 0)
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string name;
            int price, count;
            name = NameBox.Text;
            price =(int)priceNum.Value;
            count = (int) countNum.Value;
            Product ToSell = myshop.FindByName(name);
            if (ToSell == null)
            {
                myshop.CreateProduct(name, price, count);
                MessageBox.Show("Товар добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameBox.Text = "";
                priceNum.Value = 0;
                countNum.Value = 0;

            }
            else
            {
                MessageBox.Show("Такой товар уже есть", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void tabControl1_Selected (object sender, TabControlEventArgs e)
        {
            listProduct.Items.Clear();
            cellBox.Items.Clear();
            List<string> list = new List<string>();
            List<string> namelist = new List<string>();
            myshop.WriteOnlyProductsName(namelist);
            myshop.WriteAllProducts(list);
            foreach(string listitem in list)
            {
                listProduct.Items.Add(listitem);
            }
            foreach (string listitem in namelist)
            {
                cellBox.Items.Add(listitem);
            }
            label7.Text = $"{myshop.Profit.ToString()} руб.";
        }

        private void Cellbutton_Click (object sender, EventArgs e)
        {
            if (cellBox.Text == "")
            {
                MessageBox.Show("Пустое поле ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cellpr = cellBox.Text;
            MessageBox.Show($"{myshop.Sell(cellpr)}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
