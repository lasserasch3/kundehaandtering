using Abstractions.Interfaces.Models;
using Abstractions.Interfaces.Services;

namespace CustomerEditorGUI
{
    public partial class FrmCustomerEdit : Form
    {
        private readonly ICustomerService _customerService;
        internal ICustomer _customer;
        public FrmCustomerEdit(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_email.Text.Length > 0 && tb_firstname.Text.Length > 0 && tb_lastname.Text.Length > 0)
            {
                SaveCustomer();
            }

        }

        private void SaveCustomer()
        {
            if (_customer != null)
            {
                _customerService.UpdateCustomer(tb_firstname.Text, tb_lastname.Text, tb_phone.Text, tb_email.Text, _customer.Id);
            }
            else
            {
                _customerService.CreateCustomer(tb_firstname.Text, tb_lastname.Text, tb_phone.Text, tb_email.Text);
            }
            this.Close();
        }

        private void SetupForm()
        {
            if (_customer != null)
            {
                tb_email.Text = _customer.Email;
                tb_firstname.Text = _customer.FirstName;
                tb_lastname.Text = _customer.LastName;
                tb_phone.Text = _customer.Phonenumber;
            }
            else
            {
                tb_email.Text = string.Empty;
                tb_firstname.Text = string.Empty;
                tb_lastname.Text = string.Empty;
                tb_phone.Text = string.Empty;
            }
        }

        private void FrmCreateCustomer_Load(object sender, EventArgs e)
        {
            SetupForm();
        }
    }
}
