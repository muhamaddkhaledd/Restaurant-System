using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Restaurant_System
{
    public partial class checkout : Form
    {
        public double sum_all_items = 3845;
        public double remainder_all_items = 0;
        public double totalitems_ = 0;
        public double total_ = 0;
        public double amount_paid_ = 0;
        public double remainder_ = 0;
        public checkout()
        {
            InitializeComponent();
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            total_items_num.Text = totalitems_.ToString();
            total.Text = total_.ToString();
            remainder_all_items = sum_all_items - totalitems_;
            sum_items_remain.Text = remainder_all_items.ToString();
        }

        private void print_ptn_Click(object sender, EventArgs e)
        {
            StreamWriter cl = new StreamWriter("Calculations.txt", true);
            string time = DateTime.Now.ToString();
            cl.WriteLine("Bill TIME : " + time);
            cl.WriteLine("sum of all items :"+ sum_all_items);
            cl.WriteLine("remainder all items :"+remainder_all_items);
            cl.WriteLine("total items : " + totalitems_);
            cl.WriteLine("total : " + total_);
            cl.WriteLine("amount paid : " + amount_paid.Text);
            cl.WriteLine("remainder : " + remainder_num.Text);
            cl.WriteLine("------------------------");
            cl.Close();
            MessageBox.Show("Data Printed Sucessfully");
            this.Close();
        }

        private void add_copon_btn_Click(object sender, EventArgs e)
        {
            double paid = double.Parse(amount_paid.Text);
            if (paid<total_)
            {
                MessageBox.Show("The amount paid is less than the amount to be paid");
            }
            else
            {
                double rem = paid-total_;
                remainder_num.Text = rem.ToString();
                
            }
        }
    }
}
