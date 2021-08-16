using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Поле Имя обязательно для заполнения");
                return;
            }
            DataAccess da = new DataAccess();

            da.AddContact(tbName.Text, tbLastName.Text, dtpBirthday.Value);

            Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }
}
