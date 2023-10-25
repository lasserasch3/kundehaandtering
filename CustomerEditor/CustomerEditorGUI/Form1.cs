using Abstractions.Interfaces.Models;
using CustomerEditorGUI.Helpers;
using System.ComponentModel;


namespace CustomerEditorGUI
{
    public partial class Form1 : Form
    {
        private readonly Abstractions.Interfaces.Services.ICustomerService _customerService;
        private readonly FrmCustomerEdit _frmCustomerEdit;

        public Form1(Abstractions.Interfaces.Services.ICustomerService customerService, FrmCustomerEdit frmCustomerEdit)
        {
            InitializeComponent();
            _customerService = customerService;
            _frmCustomerEdit = frmCustomerEdit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
           
            dataGridView1.DesignUCLDataGridView();
        }

        private void LoadCustomerList()
        {
            BindingList<Abstractions.Interfaces.Models.ICustomer> bindingSource =
                new BindingList<ICustomer>(_customerService.GetAllCustomers());

            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ShowCustomerdetails((ICustomer)dataGridView1.SelectedRows[0].DataBoundItem);
            }
        }

        private void ShowCustomerdetails(ICustomer customer)
        {
            tb_email.Text = customer.Email;
            tb_firstname.Text = customer.FirstName;
            tb_lastname.Text = customer.LastName;
            tb_phone.Text = customer.Phonenumber;
        }

        private void opretKundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmCustomerEdit._customer = null;
            _frmCustomerEdit.ShowDialog();
            LoadCustomerList();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _frmCustomerEdit._customer = (ICustomer)dataGridView1.SelectedRows[0].DataBoundItem;
                _frmCustomerEdit.ShowDialog();
                LoadCustomerList();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var customerToDelete = (ICustomer)dataGridView1.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"Er du sikker på at du vil slette '{customerToDelete.FirstName} {customerToDelete.LastName}'", "Er du sikker?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_customerService.DeleteCustomer(customerToDelete.Id))
                    {
                        LoadCustomerList();
                    }
                }
            }
        }
    }
}