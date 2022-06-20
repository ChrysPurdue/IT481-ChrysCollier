namespace Chrys_Collier_Unit2_IT481
{
    partial class Unit2
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
            this.btnGetCustomers = new System.Windows.Forms.Button();
            this.flpCustomers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetCustomers
            // 
            this.btnGetCustomers.AutoSize = true;
            this.btnGetCustomers.Location = new System.Drawing.Point(13, 11);
            this.btnGetCustomers.Name = "btnGetCustomers";
            this.btnGetCustomers.Size = new System.Drawing.Size(86, 23);
            this.btnGetCustomers.TabIndex = 0;
            this.btnGetCustomers.Text = "Get Customers";
            this.btnGetCustomers.UseVisualStyleBackColor = true;
            this.btnGetCustomers.Click += new System.EventHandler(this.btnGetCustomers_Click);
            // 
            // flpCustomers
            // 
            this.flpCustomers.AutoScroll = true;
            this.flpCustomers.Location = new System.Drawing.Point(13, 43);
            this.flpCustomers.Name = "flpCustomers";
            this.flpCustomers.Size = new System.Drawing.Size(414, 395);
            this.flpCustomers.TabIndex = 1;
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Location = new System.Drawing.Point(106, 16);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerCount.TabIndex = 2;
            this.lblCustomerCount.Visible = false;
            // 
            // Unit2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.lblCustomerCount);
            this.Controls.Add(this.flpCustomers);
            this.Controls.Add(this.btnGetCustomers);
            this.Name = "Unit2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCustomers;
        private System.Windows.Forms.FlowLayoutPanel flpCustomers;
        private System.Windows.Forms.Label lblCustomerCount;
    }
}

