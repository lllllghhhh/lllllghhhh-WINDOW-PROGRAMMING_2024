using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice3_1
{
    public partial class Form1 : Form
    {
        string monster;
        static int i = 1000;
        List<(int, string, int)> item_list = new List<(int, string, int)>();

        private List<Button> options = new List<Button>();

        public Form1() {
            InitializeComponent();
            options.Add(penguinBtn);
            options.Add(porkBtn);
            options.Add(shrimpBtn);
        }

        private void button1_click(object sender, EventArgs e)
        {
            notice.Text = "歡迎光臨! 請登入!";
            button1.Hide();
            panel2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (account.Text == "admin" && password.Text == "admin")
            {
                panel1.Show();
                notice.Text = "歡迎登入!，admin";
                panel2.Hide();
            }
            else
            {
                notice.Text = "帳號或密碼錯誤";
                account.Text = "";
                password.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(quantityField.Text, out var quantity))
            {
                notice.Text = "商品數量必須是正整數";
                quantityField.Focus();
                return;
            }
            notice.Text = $"新增訂單成功，訂單編號{i}";
            item_list.Add((i++, monster, quantity));
            panel3.Hide();
            panel1.Show();
        }
        private void Item_Click(object sender, EventArgs e)
        {
            foreach (var btn in options) {
                if (btn == sender)
                    monster = (string)btn.Tag;
            }

        }


        private void NewOrder_Click(object sender, EventArgs e)
        {
            notice.Text = "輸入完數量後，點選對應的商品按鈕，並按送出";
            orderListView.Clear();
            panel1.Hide();
            panel3.Show();
            quantityField.Clear();
        }

        private void print_list_Click(object sender, EventArgs e)
        {
            orderListView.Clear();
            foreach (var (index, name, quantity) in item_list)
            {
                orderListView.Text += $"訂單編號:{index}購買了{quantity}個{name}\r\n";
            }
        }
    }
}
