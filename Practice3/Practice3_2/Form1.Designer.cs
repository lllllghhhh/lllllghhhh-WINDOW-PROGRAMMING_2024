﻿namespace practice3_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.notice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.new_account = new System.Windows.Forms.Button();
            this.orderListView = new System.Windows.Forms.TextBox();
            this.print_list = new System.Windows.Forms.Button();
            this.add_list = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.submitOrderBtn = new System.Windows.Forms.Button();
            this.shrimpBtn = new System.Windows.Forms.Button();
            this.porkBtn = new System.Windows.Forms.Button();
            this.penguinBtn = new System.Windows.Forms.Button();
            this.quantityField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.createacc_btn = new System.Windows.Forms.Button();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.newacc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // notice
            // 
            this.notice.BackColor = System.Drawing.SystemColors.Window;
            this.notice.Location = new System.Drawing.Point(162, 26);
            this.notice.Name = "notice";
            this.notice.ReadOnly = true;
            this.notice.Size = new System.Drawing.Size(475, 29);
            this.notice.TabIndex = 1;
            this.notice.Text = "歡迎來到角落生物商店";
            this.notice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(474, 249);
            this.button1.TabIndex = 0;
            this.button1.Text = "開店";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "密碼";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(110, 36);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(415, 29);
            this.account.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(110, 106);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(415, 29);
            this.password.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.account);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(41, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 185);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 81);
            this.button2.TabIndex = 6;
            this.button2.Text = "登入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.new_account);
            this.panel1.Controls.Add(this.orderListView);
            this.panel1.Controls.Add(this.print_list);
            this.panel1.Controls.Add(this.add_list);
            this.panel1.Location = new System.Drawing.Point(27, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 343);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 69);
            this.button4.TabIndex = 4;
            this.button4.Text = "登出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // new_account
            // 
            this.new_account.Location = new System.Drawing.Point(24, 192);
            this.new_account.Name = "new_account";
            this.new_account.Size = new System.Drawing.Size(108, 69);
            this.new_account.TabIndex = 3;
            this.new_account.Text = "新增帳號";
            this.new_account.UseVisualStyleBackColor = true;
            this.new_account.Click += new System.EventHandler(this.new_account_Click);
            // 
            // orderListView
            // 
            this.orderListView.Location = new System.Drawing.Point(163, 42);
            this.orderListView.Multiline = true;
            this.orderListView.Name = "orderListView";
            this.orderListView.ReadOnly = true;
            this.orderListView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.orderListView.Size = new System.Drawing.Size(481, 275);
            this.orderListView.TabIndex = 2;
            // 
            // print_list
            // 
            this.print_list.Location = new System.Drawing.Point(24, 111);
            this.print_list.Name = "print_list";
            this.print_list.Size = new System.Drawing.Size(108, 69);
            this.print_list.TabIndex = 1;
            this.print_list.Text = "列出所有訂單";
            this.print_list.UseVisualStyleBackColor = true;
            this.print_list.Click += new System.EventHandler(this.print_list_Click);
            // 
            // add_list
            // 
            this.add_list.Location = new System.Drawing.Point(22, 31);
            this.add_list.Name = "add_list";
            this.add_list.Size = new System.Drawing.Size(110, 66);
            this.add_list.TabIndex = 0;
            this.add_list.Text = "新增訂單";
            this.add_list.UseVisualStyleBackColor = true;
            this.add_list.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.submitOrderBtn);
            this.panel3.Controls.Add(this.shrimpBtn);
            this.panel3.Controls.Add(this.porkBtn);
            this.panel3.Controls.Add(this.penguinBtn);
            this.panel3.Controls.Add(this.quantityField);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(75, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 320);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // submitOrderBtn
            // 
            this.submitOrderBtn.Location = new System.Drawing.Point(238, 194);
            this.submitOrderBtn.Name = "submitOrderBtn";
            this.submitOrderBtn.Size = new System.Drawing.Size(127, 55);
            this.submitOrderBtn.TabIndex = 5;
            this.submitOrderBtn.Text = "送出訂單";
            this.submitOrderBtn.UseVisualStyleBackColor = true;
            this.submitOrderBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // shrimpBtn
            // 
            this.shrimpBtn.Location = new System.Drawing.Point(455, 113);
            this.shrimpBtn.Name = "shrimpBtn";
            this.shrimpBtn.Size = new System.Drawing.Size(123, 56);
            this.shrimpBtn.TabIndex = 4;
            this.shrimpBtn.Tag = "炸蝦";
            this.shrimpBtn.Text = "炸蝦";
            this.shrimpBtn.UseVisualStyleBackColor = true;
            this.shrimpBtn.Click += new System.EventHandler(this.Item_Click);
            // 
            // porkBtn
            // 
            this.porkBtn.Location = new System.Drawing.Point(255, 110);
            this.porkBtn.Name = "porkBtn";
            this.porkBtn.Size = new System.Drawing.Size(121, 59);
            this.porkBtn.TabIndex = 3;
            this.porkBtn.Tag = "炸豬排";
            this.porkBtn.Text = "炸豬排";
            this.porkBtn.UseVisualStyleBackColor = true;
            this.porkBtn.Click += new System.EventHandler(this.Item_Click);
            // 
            // penguinBtn
            // 
            this.penguinBtn.Location = new System.Drawing.Point(68, 110);
            this.penguinBtn.Name = "penguinBtn";
            this.penguinBtn.Size = new System.Drawing.Size(123, 59);
            this.penguinBtn.TabIndex = 2;
            this.penguinBtn.Tag = "企鵝";
            this.penguinBtn.Text = "企鵝";
            this.penguinBtn.UseVisualStyleBackColor = true;
            this.penguinBtn.Click += new System.EventHandler(this.Item_Click);
            // 
            // quantityField
            // 
            this.quantityField.Location = new System.Drawing.Point(145, 34);
            this.quantityField.Name = "quantityField";
            this.quantityField.Size = new System.Drawing.Size(325, 29);
            this.quantityField.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "請輸入數量";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.createacc_btn);
            this.panel4.Controls.Add(this.newpassword);
            this.panel4.Controls.Add(this.newacc);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(61, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(676, 185);
            this.panel4.TabIndex = 8;
            this.panel4.Visible = false;
            // 
            // createacc_btn
            // 
            this.createacc_btn.Location = new System.Drawing.Point(546, 45);
            this.createacc_btn.Name = "createacc_btn";
            this.createacc_btn.Size = new System.Drawing.Size(115, 81);
            this.createacc_btn.TabIndex = 6;
            this.createacc_btn.Text = "新增帳號";
            this.createacc_btn.UseVisualStyleBackColor = true;
            this.createacc_btn.Click += new System.EventHandler(this.createacc_btn_Click);
            // 
            // newpassword
            // 
            this.newpassword.Location = new System.Drawing.Point(110, 106);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(415, 29);
            this.newpassword.TabIndex = 5;
            // 
            // newacc
            // 
            this.newacc.Location = new System.Drawing.Point(110, 36);
            this.newacc.Name = "newacc";
            this.newacc.Size = new System.Drawing.Size(415, 29);
            this.newacc.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "密碼";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "帳號";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox orderListView;
        private System.Windows.Forms.Button print_list;
        private System.Windows.Forms.Button add_list;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button submitOrderBtn;
        private System.Windows.Forms.Button shrimpBtn;
        private System.Windows.Forms.Button porkBtn;
        private System.Windows.Forms.Button penguinBtn;
        private System.Windows.Forms.TextBox quantityField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button new_account;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button createacc_btn;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.TextBox newacc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

