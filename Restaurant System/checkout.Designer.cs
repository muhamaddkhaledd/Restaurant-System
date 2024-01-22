namespace Restaurant_System
{
    partial class checkout
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
            this.label1 = new System.Windows.Forms.Label();
            this.total_items_num = new System.Windows.Forms.Label();
            this.all_av_items = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sum_items_remain = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.add_copon_btn = new System.Windows.Forms.Button();
            this.amount_paid = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.remainder_num = new System.Windows.Forms.Label();
            this.print_ptn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Items :";
            // 
            // total_items_num
            // 
            this.total_items_num.AutoSize = true;
            this.total_items_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_items_num.Location = new System.Drawing.Point(297, 178);
            this.total_items_num.Name = "total_items_num";
            this.total_items_num.Size = new System.Drawing.Size(26, 29);
            this.total_items_num.TabIndex = 1;
            this.total_items_num.Text = "0";
            // 
            // all_av_items
            // 
            this.all_av_items.AutoSize = true;
            this.all_av_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_av_items.Location = new System.Drawing.Point(297, 89);
            this.all_av_items.Name = "all_av_items";
            this.all_av_items.Size = new System.Drawing.Size(65, 29);
            this.all_av_items.TabIndex = 3;
            this.all_av_items.Text = "3845";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "The sum of all items available :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "The remainder of all items :";
            // 
            // sum_items_remain
            // 
            this.sum_items_remain.AutoSize = true;
            this.sum_items_remain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_items_remain.Location = new System.Drawing.Point(297, 132);
            this.sum_items_remain.Name = "sum_items_remain";
            this.sum_items_remain.Size = new System.Drawing.Size(26, 29);
            this.sum_items_remain.TabIndex = 5;
            this.sum_items_remain.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total :";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(297, 236);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(26, 29);
            this.total.TabIndex = 7;
            this.total.Text = "0";
            // 
            // add_copon_btn
            // 
            this.add_copon_btn.Location = new System.Drawing.Point(274, 350);
            this.add_copon_btn.Name = "add_copon_btn";
            this.add_copon_btn.Size = new System.Drawing.Size(75, 23);
            this.add_copon_btn.TabIndex = 19;
            this.add_copon_btn.Text = "ok";
            this.add_copon_btn.UseVisualStyleBackColor = true;
            this.add_copon_btn.Click += new System.EventHandler(this.add_copon_btn_Click);
            // 
            // amount_paid
            // 
            this.amount_paid.Location = new System.Drawing.Point(262, 302);
            this.amount_paid.Name = "amount_paid";
            this.amount_paid.Size = new System.Drawing.Size(100, 22);
            this.amount_paid.TabIndex = 18;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(11, 298);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(170, 25);
            this.label103.TabIndex = 17;
            this.label103.Text = "The amount paid :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "The remainder";
            // 
            // remainder_num
            // 
            this.remainder_num.AutoSize = true;
            this.remainder_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainder_num.Location = new System.Drawing.Point(191, 472);
            this.remainder_num.Name = "remainder_num";
            this.remainder_num.Size = new System.Drawing.Size(26, 29);
            this.remainder_num.TabIndex = 21;
            this.remainder_num.Text = "0";
            // 
            // print_ptn
            // 
            this.print_ptn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_ptn.Location = new System.Drawing.Point(115, 538);
            this.print_ptn.Name = "print_ptn";
            this.print_ptn.Size = new System.Drawing.Size(208, 37);
            this.print_ptn.TabIndex = 22;
            this.print_ptn.Text = "Print";
            this.print_ptn.UseVisualStyleBackColor = true;
            this.print_ptn.Click += new System.EventHandler(this.print_ptn_Click);
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 626);
            this.Controls.Add(this.print_ptn);
            this.Controls.Add(this.remainder_num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_copon_btn);
            this.Controls.Add(this.amount_paid);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sum_items_remain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.all_av_items);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total_items_num);
            this.Controls.Add(this.label1);
            this.Name = "checkout";
            this.Text = "checkout";
            this.Load += new System.EventHandler(this.checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_items_num;
        private System.Windows.Forms.Label all_av_items;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sum_items_remain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button add_copon_btn;
        private System.Windows.Forms.TextBox amount_paid;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label remainder_num;
        private System.Windows.Forms.Button print_ptn;
    }
}