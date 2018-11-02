namespace TicketPurchase
{
    partial class TicketPurchaseUI
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
            this.totalPriceButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfTicketTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // totalPriceButton
            // 
            this.totalPriceButton.Location = new System.Drawing.Point(128, 195);
            this.totalPriceButton.Name = "totalPriceButton";
            this.totalPriceButton.Size = new System.Drawing.Size(82, 40);
            this.totalPriceButton.TabIndex = 1;
            this.totalPriceButton.Text = "Total Price";
            this.totalPriceButton.UseVisualStyleBackColor = true;
            this.totalPriceButton.Click += new System.EventHandler(this.totalPriceButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(256, 195);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(78, 40);
            this.detailsButton.TabIndex = 2;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(212, 51);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(218, 20);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // numberOfTicketTextBox
            // 
            this.numberOfTicketTextBox.Location = new System.Drawing.Point(212, 99);
            this.numberOfTicketTextBox.Name = "numberOfTicketTextBox";
            this.numberOfTicketTextBox.Size = new System.Drawing.Size(206, 20);
            this.numberOfTicketTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Tickets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "One Ticket price 100 Taka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer and Ticket information";
            // 
            // TicketPurchaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 299);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberOfTicketTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.totalPriceButton);
            this.Controls.Add(this.label1);
            this.Name = "TicketPurchaseUI";
            this.Text = " Purchasing Ticket System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button totalPriceButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox numberOfTicketTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

