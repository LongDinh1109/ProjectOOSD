
namespace healthcheckapp
{
    partial class BuyProduct
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Items.AddRange(new object[] {
            "Paypal",
            "Cash"});
            this.cbPay.Location = new System.Drawing.Point(157, 177);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(254, 33);
            this.cbPay.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 31);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(157, 51);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(254, 31);
            this.txtPhone.TabIndex = 3;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "SMember",
            "SSMember"});
            this.cbType.Location = new System.Drawing.Point(157, 246);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(254, 33);
            this.cbType.TabIndex = 4;
            // 
            // BuyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.button1);
            this.Name = "BuyProduct";
            this.Text = "BuyProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cbType;
    }
}