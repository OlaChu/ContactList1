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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали Редактировать");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           DataAccess da = new DataAccess();
            Contact currentItem = (Contact)listContact.SelectedItem;
            if (currentItem != null)
            {
                da.DeleteContact(currentItem.ID);
            }
            else
            {
                MessageBox.Show("Не определн объект удаления");
            }
        }

        private void listContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали на выбранный элемент");
        }

        private void listContact_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Вы нажали двойной клик");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            DataAccess da = new DataAccess();

            listContact.DataSource = da.GetContact();
            listContact.DisplayMember = "FullInfo";
        }
    }
}
