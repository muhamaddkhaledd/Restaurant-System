namespace Restaurant_System
{
    partial class show_bill_details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.discount_num = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.discount_perc_num = new System.Windows.Forms.Label();
            this.extrafees = new System.Windows.Forms.Label();
            this.total_items_num = new System.Windows.Forms.Label();
            this.total_items = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.total_num = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.service_num = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tax_num = new System.Windows.Forms.Label();
            this.total_exfees_num = new System.Windows.Forms.Label();
            this.total_exfeesperc_num = new System.Windows.Forms.Label();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.total_exfeesperc_num, 1, 4);
            this.tableLayoutPanel10.Controls.Add(this.total_exfees_num, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.tax_num, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.service_num, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.total_items_num, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.total_items, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label105, 0, 7);
            this.tableLayoutPanel10.Controls.Add(this.total_num, 1, 7);
            this.tableLayoutPanel10.Controls.Add(this.discount, 0, 6);
            this.tableLayoutPanel10.Controls.Add(this.discount_num, 1, 6);
            this.tableLayoutPanel10.Controls.Add(this.discount_perc_num, 1, 5);
            this.tableLayoutPanel10.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel10.Controls.Add(this.extrafees, 0, 3);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(12, 131);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 8;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50187F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50187F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(903, 424);
            this.tableLayoutPanel10.TabIndex = 11;
            this.tableLayoutPanel10.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel10_Paint);
            // 
            // discount_num
            // 
            this.discount_num.AutoSize = true;
            this.discount_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_num.Location = new System.Drawing.Point(454, 312);
            this.discount_num.Name = "discount_num";
            this.discount_num.Size = new System.Drawing.Size(39, 42);
            this.discount_num.TabIndex = 17;
            this.discount_num.Text = "0";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(3, 312);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(184, 42);
            this.discount.TabIndex = 16;
            this.discount.Text = "Discount :";
            // 
            // discount_perc_num
            // 
            this.discount_perc_num.AutoSize = true;
            this.discount_perc_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_perc_num.Location = new System.Drawing.Point(454, 260);
            this.discount_perc_num.Name = "discount_perc_num";
            this.discount_perc_num.Size = new System.Drawing.Size(39, 42);
            this.discount_perc_num.TabIndex = 13;
            this.discount_perc_num.Text = "0";
            // 
            // extrafees
            // 
            this.extrafees.AutoSize = true;
            this.extrafees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrafees.Location = new System.Drawing.Point(3, 156);
            this.extrafees.Name = "extrafees";
            this.extrafees.Size = new System.Drawing.Size(247, 36);
            this.extrafees.TabIndex = 12;
            this.extrafees.Text = "Total Extra Fees :";
            // 
            // total_items_num
            // 
            this.total_items_num.AutoSize = true;
            this.total_items_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_items_num.Location = new System.Drawing.Point(454, 0);
            this.total_items_num.Name = "total_items_num";
            this.total_items_num.Size = new System.Drawing.Size(39, 42);
            this.total_items_num.TabIndex = 11;
            this.total_items_num.Text = "0";
            // 
            // total_items
            // 
            this.total_items.AutoSize = true;
            this.total_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_items.Location = new System.Drawing.Point(3, 0);
            this.total_items.Name = "total_items";
            this.total_items.Size = new System.Drawing.Size(220, 42);
            this.total_items.TabIndex = 9;
            this.total_items.Text = "Items Total :";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label105.Location = new System.Drawing.Point(3, 365);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(121, 42);
            this.label105.TabIndex = 14;
            this.label105.Text = "Total :";
            // 
            // total_num
            // 
            this.total_num.AutoSize = true;
            this.total_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_num.Location = new System.Drawing.Point(454, 365);
            this.total_num.Name = "total_num";
            this.total_num.Size = new System.Drawing.Size(39, 42);
            this.total_num.TabIndex = 15;
            this.total_num.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Service expenses :";
            // 
            // service_num
            // 
            this.service_num.AutoSize = true;
            this.service_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_num.Location = new System.Drawing.Point(454, 52);
            this.service_num.Name = "service_num";
            this.service_num.Size = new System.Drawing.Size(39, 42);
            this.service_num.TabIndex = 12;
            this.service_num.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "discount percentage :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 42);
            this.label3.TabIndex = 12;
            this.label3.Text = "tax :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Extra Fees percentage :";
            // 
            // tax_num
            // 
            this.tax_num.AutoSize = true;
            this.tax_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax_num.Location = new System.Drawing.Point(454, 104);
            this.tax_num.Name = "tax_num";
            this.tax_num.Size = new System.Drawing.Size(39, 42);
            this.tax_num.TabIndex = 13;
            this.tax_num.Text = "0";
            // 
            // total_exfees_num
            // 
            this.total_exfees_num.AutoSize = true;
            this.total_exfees_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_exfees_num.Location = new System.Drawing.Point(454, 156);
            this.total_exfees_num.Name = "total_exfees_num";
            this.total_exfees_num.Size = new System.Drawing.Size(39, 42);
            this.total_exfees_num.TabIndex = 13;
            this.total_exfees_num.Text = "0";
            // 
            // total_exfeesperc_num
            // 
            this.total_exfeesperc_num.AutoSize = true;
            this.total_exfeesperc_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_exfeesperc_num.Location = new System.Drawing.Point(454, 208);
            this.total_exfeesperc_num.Name = "total_exfeesperc_num";
            this.total_exfeesperc_num.Size = new System.Drawing.Size(72, 42);
            this.total_exfeesperc_num.TabIndex = 13;
            this.total_exfeesperc_num.Text = "3%";
            // 
            // show_bill_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 675);
            this.Controls.Add(this.tableLayoutPanel10);
            this.Name = "show_bill_details";
            this.Text = "show_bill_details";
            this.Load += new System.EventHandler(this.show_bill_details_Load);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label service_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_items;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label total_num;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label discount_num;
        private System.Windows.Forms.Label discount_perc_num;
        private System.Windows.Forms.Label extrafees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_exfeesperc_num;
        private System.Windows.Forms.Label total_exfees_num;
        private System.Windows.Forms.Label tax_num;
        private System.Windows.Forms.Label total_items_num;
    }
}