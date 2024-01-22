using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Restaurant_System
{
    public partial class main : Form

    {
        datas data=new datas();
        public int ammount_var=1;
        public int code = 1;
        public double itemstotal_=0;
        public double extrafees_ = 0;
        public double discount_ = 0;
        public double alltotal_ = 0;
        public string dis_code = "";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
              int nLeft,
              int nTop,
              int nRight,
              int nBottom,
              int nWidthEllipse,
              int nHeigthEll
            );
        public main()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel1.Width, flowLayoutPanel1.Height, 10, 10));
            flowLayoutPanel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel2.Width, flowLayoutPanel2.Height, 10, 10));
            flowLayoutPanel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel3.Width, flowLayoutPanel2.Height, 10, 10));
            flowLayoutPanel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel4.Width, flowLayoutPanel2.Height, 10, 10));
            flowLayoutPanel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel5.Width, flowLayoutPanel5.Height, 10, 10));
            flowLayoutPanel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel6.Width, flowLayoutPanel6.Height, 10, 10));
            flowLayoutPanel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel7.Width, flowLayoutPanel7.Height, 10, 10));
            flowLayoutPanel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel8.Width, flowLayoutPanel8.Height, 10, 10));
            flowLayoutPanel9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel9.Width, flowLayoutPanel9.Height, 10, 10));
            flowLayoutPanel10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel10.Width, flowLayoutPanel10.Height, 10, 10));
            flowLayoutPanel11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel11.Width, flowLayoutPanel11.Height, 10, 10));
            flowLayoutPanel12.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel12.Width, flowLayoutPanel12.Height, 10, 10));
            flowLayoutPanel13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel13.Width, flowLayoutPanel13.Height, 10, 10));
            flowLayoutPanel14.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel14.Width, flowLayoutPanel14.Height, 10, 10));
            flowLayoutPanel15.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel15.Width, flowLayoutPanel15.Height, 10, 10));
            flowLayoutPanel16.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel16.Width, flowLayoutPanel16.Height, 10, 10));
            flowLayoutPanel17.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel17.Width, flowLayoutPanel17.Height, 10, 10));
            flowLayoutPanel18.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel18.Width, flowLayoutPanel18.Height, 10, 10));
            flowLayoutPanel19.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel19.Width, flowLayoutPanel19.Height, 10, 10));
            flowLayoutPanel20.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel20.Width, flowLayoutPanel20.Height, 10, 10));
            flowLayoutPanel21.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel21.Width, flowLayoutPanel21.Height, 10, 10));
            flowLayoutPanel22.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel22.Width, flowLayoutPanel22.Height, 10, 10));
            flowLayoutPanel23.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel23.Width, flowLayoutPanel23.Height, 10, 10));
            flowLayoutPanel24.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel24.Width, flowLayoutPanel24.Height, 10, 10));
            flowLayoutPanel25.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel25.Width, flowLayoutPanel25.Height, 10, 10));
            flowLayoutPanel26.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel26.Width, flowLayoutPanel26.Height, 10, 10));
            flowLayoutPanel27.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel27.Width, flowLayoutPanel27.Height, 10, 10));
            flowLayoutPanel28.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel28.Width, flowLayoutPanel28.Height, 10, 10));
            flowLayoutPanel29.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel29.Width, flowLayoutPanel29.Height, 10, 10));
            flowLayoutPanel30.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel30.Width, flowLayoutPanel30.Height, 10, 10));
            flowLayoutPanel31.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel31.Width, flowLayoutPanel31.Height, 10, 10));
            flowLayoutPanel32.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel32.Width, flowLayoutPanel32.Height, 10, 10));
            flowLayoutPanel33.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel33.Width, flowLayoutPanel33.Height, 10, 10));
            flowLayoutPanel34.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel34.Width, flowLayoutPanel34.Height, 10, 10));
            flowLayoutPanel35.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel35.Width, flowLayoutPanel35.Height, 10, 10));
            flowLayoutPanel36.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel36.Width, flowLayoutPanel36.Height, 10, 10));
            flowLayoutPanel37.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel37.Width, flowLayoutPanel37.Height, 10, 10));
            flowLayoutPanel38.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel38.Width, flowLayoutPanel38.Height, 10, 10));
            flowLayoutPanel39.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel39.Width, flowLayoutPanel39.Height, 10, 10));
            flowLayoutPanel40.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel40.Width, flowLayoutPanel40.Height, 10, 10));
            flowLayoutPanel41.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel41.Width, flowLayoutPanel41.Height, 10, 10));
            flowLayoutPanel42.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel42.Width, flowLayoutPanel42.Height, 10, 10));
            flowLayoutPanel43.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel43.Width, flowLayoutPanel43.Height, 10, 10));
            flowLayoutPanel44.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel44.Width, flowLayoutPanel44.Height, 10, 10));
            flowLayoutPanel45.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel45.Width, flowLayoutPanel45.Height, 10, 10));
            flowLayoutPanel46.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel46.Width, flowLayoutPanel46.Height, 10, 10));
            flowLayoutPanel47.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel47.Width, flowLayoutPanel47.Height, 10, 10));
            flowLayoutPanel48.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel48.Width, flowLayoutPanel48.Height, 10, 10));
            flowLayoutPanel49.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel49.Width, flowLayoutPanel49.Height, 10, 10));
            flowLayoutPanel50.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel50.Width, flowLayoutPanel50.Height, 10, 10));
            flowLayoutPanel51.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel51.Width, flowLayoutPanel51.Height, 10, 10));
            flowLayoutPanel52.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel52.Width, flowLayoutPanel52.Height, 10, 10));
            flowLayoutPanel53.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel53.Width, flowLayoutPanel53.Height, 10, 10));
            flowLayoutPanel54.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel54.Width, flowLayoutPanel54.Height, 10, 10));
            flowLayoutPanel55.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel55.Width, flowLayoutPanel55.Height, 10, 10));
            flowLayoutPanel56.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel56.Width, flowLayoutPanel56.Height, 10, 10));

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void idcode_Click(object sender, EventArgs e)
        {
            
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (idcode.Text == "0")
            {
                idcode.Text = "1";
            }
            else
            {
                idcode.Text = idcode.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (idcode.Text == "0")
            {
                idcode.Text = "2";
            }
            else
            {
                idcode.Text = idcode.Text + "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (idcode.Text == "0")
            {
                idcode.Text = "3";
            }
            else
            {
                idcode.Text = idcode.Text + "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (idcode.Text == "0")
            {
                idcode.Text = "4";
            }
            else
            {
                idcode.Text = idcode.Text + "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (idcode.Text == "0")
            {
                idcode.Text = "5";
            }
            else
            {
                idcode.Text = idcode.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (idcode.Text == "0")
            {
                idcode.Text = "6";
            }
            else
            {
                idcode.Text = idcode.Text + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (idcode.Text == "0")
            {
                idcode.Text = "7";
            }
            else
            {
                idcode.Text = idcode.Text + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (idcode.Text == "0")
            {
                idcode.Text = "8";
            }
            else
            {
                idcode.Text = idcode.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (idcode.Text == "0")
            {
                idcode.Text = "9";
            }
            else
            {
                idcode.Text = idcode.Text + "9";
            }
        }

        private void add_quantity_Click(object sender, EventArgs e)
        {
            ammount_var++;
            amount_lpl.Text = "Quantity: " + ammount_var.ToString();
        }

        private void suptract_quantity_Click(object sender, EventArgs e)
        {
            if (ammount_var > 1)
            {
                ammount_var--;
                amount_lpl.Text = "Quantity: " + ammount_var.ToString();
            }
            else
            {
                ammount_var = 1;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (idcode.Text.Length>1)
            {
               idcode.Text = idcode.Text.Remove(idcode.Text.Length-1, 1);
            }
            else
            {
                idcode.Text = "0";
            }
            
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            idcode.Text = "0";
            ammount_var = 1;
            amount_lpl.Text = "Quantity: " + ammount_var.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int id =int.Parse(idcode.Text);
            string prdname= data.data_names(id, 1);
            int price= int.Parse(data.data_names(id, 2));
            string quantity_ = ammount_var.ToString();
            int total_products=price*int.Parse(quantity_);
            
            


            if (prdname == "0" && idcode.Text!="0")
            {
                MessageBox.Show("id not found");
            }
            else if (idcode.Text=="0")
            {
                
            }
            else
            {
                datas d=new datas();
                object[] data = {id,prdname,price ,ammount_var,total_products.ToString()};
                dataGridView1.Rows.Add(data);
                idcode.Text = "0";
                ammount_var = 1;
                amount_lpl.Text = "Quantity: " + ammount_var.ToString();
                itemstotal_ = itemstotal_ + total_products;
                total_items_num.Text=itemstotal_.ToString();
                extrafees_ =  (0.03 * itemstotal_);
                extrefees_num.Text = extrafees_.ToString();
                discount_ = d.discount(dis_code) * (itemstotal_ + extrafees_);
                discount_num.Text=discount_.ToString();
                alltotal_=itemstotal_+extrafees_-discount_;
                total_num.Text=alltotal_.ToString();
                
            }
           

        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (idcode.Text == "0")
            {
                idcode.Text = "0";
            }
            else
            {
                idcode.Text = idcode.Text + "0";
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[4].Value != null && itemstotal_ >= 0)
            {
                int val = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                itemstotal_= itemstotal_ - val;
                total_items_num.Text = itemstotal_.ToString();
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                total_items_num.Text = itemstotal_.ToString();
                extrafees_ = (0.03 * itemstotal_);
                extrefees_num.Text = extrafees_.ToString();
                discount_ = data.discount(dis_code) * (itemstotal_ + extrafees_);
                discount_num.Text =  discount_.ToString();
                alltotal_ = itemstotal_ + extrafees_ - discount_;
                total_num.Text = alltotal_.ToString();
            }
        }

        private void newbill_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            itemstotal_ = 0;
            extrafees_ = 0;
            discount_ = 0;
            alltotal_ = 0;
            total_items_num.Text = itemstotal_.ToString();
            extrefees_num.Text = extrafees_.ToString();
            discount_num.Text = discount_.ToString();
            total_num.Text = alltotal_.ToString();
            dis_code = "";
        }

        private void savebill_Click(object sender, EventArgs e)
        {
            int max = dataGridView1.Rows.Count - 1;
            string time = DateTime.Now.ToString();
            StreamWriter sw = new StreamWriter("data.txt", true);
            sw.WriteLine("Bill TIME : " + time);
            for (int i = 0; i < max; i++)
            {

                sw.Write("Id :" + dataGridView1.Rows[i].Cells[0].Value.ToString());
                sw.Write("||Product name :" + dataGridView1.Rows[i].Cells[1].Value.ToString());
                sw.Write("|| Price :" + dataGridView1.Rows[i].Cells[2].Value.ToString());
                sw.Write("|| Quantity :" + dataGridView1.Rows[i].Cells[3].Value.ToString());
                sw.Write("|| Total :" + dataGridView1.Rows[i].Cells[4].Value.ToString());
                sw.WriteLine();

            }
            sw.WriteLine("Total items : " + itemstotal_);
            sw.Write("Extra Fees : " + extrafees_);
            sw.Write("||Discount : "+ discount_);
            sw.WriteLine();
            sw.WriteLine("Total :"+alltotal_);
            sw.WriteLine("-------------------------------------");
            sw.Close();
            newbill_Click(sender, e);
            MessageBox.Show("Bill Saved Sucessfully");
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "1";
        }

        private void flowLayoutPanel2_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "2";
        }

        private void flowLayoutPanel3_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "3";
        }

        private void flowLayoutPanel4_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "4";
        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel5_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "5";
        }

        private void flowLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel12_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "6";
        }

        private void flowLayoutPanel13_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "7";
        }

        private void flowLayoutPanel14_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "8";
        }

        private void flowLayoutPanel15_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "9";
        }

        private void flowLayoutPanel17_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "10";
        }

        private void flowLayoutPanel18_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "11";
        }

        private void flowLayoutPanel19_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "12";
        }

        private void flowLayoutPanel20_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "13";
        }

        private void flowLayoutPanel16_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "14";
        }

        private void flowLayoutPanel21_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "15";
        }

        private void flowLayoutPanel22_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "16";
        }

        private void flowLayoutPanel23_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "17";
        }

        private void flowLayoutPanel24_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "18";
        }

        private void flowLayoutPanel25_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "19";
        }

        private void flowLayoutPanel27_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "20";
        }

        private void flowLayoutPanel28_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "21";
        }

        private void flowLayoutPanel29_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "22";
        }

        private void flowLayoutPanel26_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "23";
        }

        private void flowLayoutPanel30_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "24";
        }

        private void flowLayoutPanel31_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "25";
        }

        private void flowLayoutPanel32_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "26";
        }

        private void flowLayoutPanel33_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "27";
        }

        private void flowLayoutPanel35_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "28";
        }

        private void flowLayoutPanel34_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "29";
        }

        private void flowLayoutPanel36_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "30";
        }

        private void flowLayoutPanel37_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "31";
        }

        private void flowLayoutPanel38_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "32";
        }

        private void flowLayoutPanel39_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "33";
        }

        private void flowLayoutPanel41_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "34";
        }

        private void flowLayoutPanel42_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "35";
        }

        private void flowLayoutPanel43_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "36";
        }

        private void flowLayoutPanel40_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "37";
        }

        private void flowLayoutPanel44_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "38";
        }

        private void flowLayoutPanel45_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "39";
        }

        private void flowLayoutPanel46_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "40";
        }

        private void flowLayoutPanel47_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "41";
        }

        private void flowLayoutPanel49_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "42";
        }

        private void flowLayoutPanel57_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "43";
        }

        private void flowLayoutPanel50_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "44";
        }

        private void flowLayoutPanel51_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "45";
        }

        private void flowLayoutPanel52_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "46";
        }

        private void flowLayoutPanel53_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "47";
        }

        private void flowLayoutPanel55_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "48";
        }

        private void flowLayoutPanel56_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "49";
        }

        private void flowLayoutPanel54_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "50";
            
        }

        private void show_bill_Click(object sender, EventArgs e)
        {
            show_bill_details sh = new show_bill_details();
            datas d = new datas();
            sh.itemstotal_ = itemstotal_;
            sh.extrafees_ = extrafees_;
            sh.discount_ = discount_;
            sh.alltotal_ = alltotal_;
            sh.discountpercent_ = d.discount(dis_code)*100;
            sh.ShowDialog();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            idcode.Text = "3";
        }

        private void coupon_Click(object sender, EventArgs e)
        {
            
            
        }

        private void add_copon_btn_Click(object sender, EventArgs e)
        {
            datas d =new datas();
            string discode = copon_txt.Text;
            if (d.discount(discode)==0)
            {
                MessageBox.Show("The coupon is incorrect");
                copon_txt.Clear();
            }
            else
            {
                dis_code = discode;
                MessageBox.Show("coupon added successfully");
                copon_txt.Clear();
            }
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            checkout chk = new checkout();
            chk.totalitems_ = itemstotal_;
            chk.total_ = alltotal_ ;

            chk.ShowDialog();
        }
    }
}
