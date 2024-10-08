using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice3_2
{
    public partial class Form1 : Form
    {
        string monster;
        static int i = 1000;
        List<(int, string, int, string)> item_list = new List<(int, string, int, string)>();

        private List<Button> options = new List<Button>();
        private Dictionary<string, string> acc_list = new Dictionary<string, string>();
        string user;
        public Form1()
        {
            InitializeComponent();
            options.Add(penguinBtn);
            options.Add(porkBtn);
            options.Add(shrimpBtn);
            acc_list.Add("admin", "admin");
        }

        private void button1_click(object sender, EventArgs e)
        {
            notice.Text = "歡迎光臨! 請登入!";
            button1.Hide();
            panel2.Show();
            account.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var acc in acc_list)
            {
                
                if (account.Text == acc.Key && password.Text == acc.Value)
                {
                    panel1.Show();
                    notice.Text = $"歡迎登入!，{acc.Key}";
                    user = acc.Key;
                    panel2.Hide();
                    break;
               
                }
                else
                {
                    notice.Text = "帳號或密碼錯誤";
                    continue;
                }
            }
            account.Clear();
            password.Clear();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(monster == null)
            {
                notice.Text = "請選擇商品";
                quantityField.Focus();
                return;
            }
            
   
            
            if (!int.TryParse(quantityField.Text, out var quantity))
            {
                notice.Text = "商品數量必須是正整數";
                quantityField.Focus();
                return;
            }

            notice.Text = $"新增訂單成功，訂單編號{i}";
            item_list.Add((i++, monster, quantity, user));
            penguinBtn.Text = (string)penguinBtn.Tag;
            porkBtn.Text = (string)porkBtn.Tag;
            shrimpBtn.Text = (string)shrimpBtn.Tag;
            quantityField.Focus();
            panel3.Hide();
            panel1.Show();
        }
        private void Item_Click(object sender, EventArgs e)
        {
            foreach (var btn in options){
                btn.Text = btn == sender ? $"{(string)btn.Tag}(已選擇)" : (string)btn.Tag;
                if (btn == sender)
                    monster =(string) btn.Tag;
            }
                
        }


        private void NewOrder_Click(object sender, EventArgs e)
        {
            orderListView.Clear();
            notice.Text = "輸入完數量後，點選對應的商品按鈕，並按送出";
            panel1.Hide();
            panel3.Show();
            quantityField.Clear();
        }

        private void print_list_Click(object sender, EventArgs e)
        {
            orderListView.Clear ();
            foreach (var (index, name, quantity, userl) in item_list)
            {
                orderListView.Text += $"訂單編號:{index}購買了{quantity}個{name}, 此訂單由{userl}新增\r\n";
            }
        }

        private void new_account_Click(object sender, EventArgs e)
        {
            notice.Text = "請輸入要新增的使用者帳號與名稱";
            panel1.Hide();
            panel4.Show();
           
   
        }

        private void createacc_btn_Click(object sender, EventArgs e)
        {
            if (acc_list.TryGetValue(newacc.Text, out var acc))
            {
                notice.Text = "此使用者已經存在";
                return;
            }
            acc_list.Add(newacc.Text, newpassword.Text);

            panel4.Hide();
            panel1.Show();
            notice.Text = $"歡迎登入!，{newacc.Text}";
            user = newacc.Text;
            newacc.Clear();
            newpassword.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            notice.Text = "歡迎光臨! 請登入!";

        }
    }
}
