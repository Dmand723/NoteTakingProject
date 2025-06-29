using System.Data;
using System.Web;

namespace NoteTakingProject
{//Continue from part 1 in the assiment
    public partial class Form1 : Form
    {
        DataTable? table;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 188;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (table != null)
            {
                table.Rows.Add(txtTitle.Text, txtMessage.Text);
                txtTitle.Clear();
                txtMessage.Clear();
            }
            else
            {
                Console.WriteLine("Error with table");
            }

        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index > -1)
                {

                    string title = table.Rows[index].ItemArray[0].ToString();
                    string text = table.Rows[index].ItemArray[1].ToString();
                    Form2 secondForm = new Form2(title, text); secondForm.Show();
                }
    
            }
            catch (NullReferenceException)
            {
                errorProvider1.SetError(dataGridView1, "No Message To Read");
            }
            

           
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
            txtTitle.Clear();
            txtMessage.Clear();
        }



        

       
    }
}
