namespace CustomerEditorGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btn_delete = new Button();
            btn_edit = new Button();
            tb_phone = new TextBox();
            tb_email = new TextBox();
            tb_lastname = new TextBox();
            label2 = new Label();
            tb_firstname = new TextBox();
            menuStrip1 = new MenuStrip();
            filerToolStripMenuItem = new ToolStripMenuItem();
            opretKundeToolStripMenuItem = new ToolStripMenuItem();
            afslutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(25, 66);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(570, 711);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Repositories.Models.Customer);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btn_edit);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_phone);
            groupBox1.Controls.Add(tb_firstname);
            groupBox1.Controls.Add(tb_lastname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Location = new Point(646, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 238);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kunde Detaljer";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 116);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 4;
            label3.Text = "Email :";
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
            // btn_delete
            // 
            btn_delete.Location = new Point(134, 187);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Slet";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btndelete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(379, 187);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(112, 34);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "Rediger";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(134, 150);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(357, 31);
            tb_phone.TabIndex = 7;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(134, 113);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(357, 31);
            tb_email.TabIndex = 5;
            // 
            // tb_lastname
            // 
            tb_lastname.Location = new Point(134, 76);
            tb_lastname.Name = "tb_lastname";
            tb_lastname.Size = new Size(357, 31);
            tb_lastname.TabIndex = 3;
            tb_lastname.Text = "cddd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 79);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Efternavn :";
            // 
            // tb_firstname
            // 
            tb_firstname.Location = new Point(134, 39);
            tb_firstname.Name = "tb_firstname";
            tb_firstname.Size = new Size(357, 31);
            tb_firstname.TabIndex = 1;
            tb_firstname.Text = "didie";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1210, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // filerToolStripMenuItem
            // 
            filerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { opretKundeToolStripMenuItem, afslutToolStripMenuItem });
            filerToolStripMenuItem.Name = "filerToolStripMenuItem";
            filerToolStripMenuItem.Size = new Size(60, 29);
            filerToolStripMenuItem.Text = "Filer";
            // 
            // opretKundeToolStripMenuItem
            // 
            opretKundeToolStripMenuItem.Name = "opretKundeToolStripMenuItem";
            opretKundeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            opretKundeToolStripMenuItem.Size = new Size(306, 34);
            opretKundeToolStripMenuItem.Text = "&Opret Ny Kunde";
            opretKundeToolStripMenuItem.Click += opretKundeToolStripMenuItem_Click;
            // 
            // afslutToolStripMenuItem
            // 
            afslutToolStripMenuItem.Name = "afslutToolStripMenuItem";
            afslutToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            afslutToolStripMenuItem.Size = new Size(306, 34);
            afslutToolStripMenuItem.Text = "&Afslut";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 808);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private GroupBox groupBox1;
        private TextBox tb_phone;
        private Label label4;
        private TextBox tb_email;
        private Label label3;
        private TextBox tb_lastname;
        private Label label2;
        private TextBox tb_firstname;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filerToolStripMenuItem;
        private ToolStripMenuItem opretKundeToolStripMenuItem;
        private ToolStripMenuItem afslutToolStripMenuItem;
        private Button btn_edit;
        private Button btn_delete;
    }
}