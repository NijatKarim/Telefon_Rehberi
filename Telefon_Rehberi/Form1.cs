using System.ComponentModel;

namespace Telefon_Rehberi
{
    public partial class Form1 : Form
    {
        private Book selectedContact = null;
        public Form1()
        {
            InitializeComponent();
            Refresh();

        }



        public void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = DataStore.books;
            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtname.Text))
            {

                var addedContact = new Book();


                addedContact.Description = txtname.Text;



                var lastContact = DataStore.books[DataStore.books.Count - 1];
                addedContact.Id = lastContact.Id + 1;

                DataStore.books.Add(addedContact);

                Refresh();

                txtname.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedContact = (Book)listBox1.SelectedItem;
                txtname.Text = selectedContact.Description;

            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            DataStore.books.Remove(selectedContact);
            selectedContact = null;
            txtname.Text = string.Empty;
            Refresh();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtname.Text))
            {
                selectedContact.Description = txtname.Text;
                Refresh();
            }
        }
    }
}