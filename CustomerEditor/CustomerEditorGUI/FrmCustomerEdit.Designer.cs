namespace CustomerEditorGUI
{
    partial class FrmCustomerEdit
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            tb_phone = new TextBox();
            label4 = new Label();
            tb_email = new TextBox();
            label3 = new Label();
            tb_lastname = new TextBox();
            label2 = new Label();
            tb_firstname = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(349, 263);
            button1.Name = "button1";
            button1.Size = new Size(174, 52);
            button1.TabIndex = 0;
            button1.Text = "Gem && Luk";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_phone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_lastname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_firstname);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 209);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kunde Detaljer";
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(136, 150);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(357, 31);
            tb_phone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 153);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 6;
            label4.Text = "Tlf :";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(136, 113);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(357, 31);
            tb_email.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 116);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 4;
            label3.Text = "Email :";
            // 
            // tb_lastname
            // 
            tb_lastname.Location = new Point(136, 76);
            tb_lastname.Name = "tb_lastname";
            tb_lastname.Size = new Size(357, 31);
            tb_lastname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Efternavn :";
            // 
            // tb_firstname
            // 
            tb_firstname.Location = new Point(136, 39);
            tb_firstname.Name = "tb_firstname";
            tb_firstname.Size = new Size(357, 31);
            tb_firstname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 42);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Fornavn :";
            // 
            // FrmCustomerEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 339);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCustomerEdit";
            Text = "Kunde Detaljer";
            Load += FrmCreateCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private TextBox tb_phone;
        private Label label4;
        private TextBox tb_email;
        private Label label3;
        private TextBox tb_lastname;
        private Label label2;
        private TextBox tb_firstname;
        private Label label1;
    }
}