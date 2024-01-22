using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class show_bill_details : Form
    {
        public double itemstotal_ = 0;
        public double extrafees_ = 0;
        public double discount_ = 0;
        public double discount_perc = 0;
        public double alltotal_ = 0;
        public double extratax_=0;
        public double extraservices_=0;
        public double extrafeespercent_ = 0;
        public double discountpercent_ = 0;
        public show_bill_details()
        {
            InitializeComponent();
            
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void show_bill_details_Load(object sender, EventArgs e)
        {
            total_items_num.Text =itemstotal_.ToString();
            total_exfees_num.Text=extrafees_.ToString();
            discount_num.Text=discount_.ToString();
            total_num.Text=alltotal_.ToString();
            extratax_ = 0.01 * itemstotal_;
            extraservices_ = 0.02 * itemstotal_;
            service_num.Text=extraservices_.ToString();
            tax_num.Text=extratax_.ToString();
            discount_perc_num.Text = discountpercent_.ToString()+"%";
        }
    }
}
