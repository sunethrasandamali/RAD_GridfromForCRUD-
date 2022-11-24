using System.Data;

namespace RAD_JGridfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable("table");
        int index;
        String selected;

        //public object DateTimePickerBday { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //add the fields of a table
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Gender");
            table.Columns.Add("Birthday");
            dataGridView1.DataSource= table;
        }

        //radio button conditions
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selected = "Male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            selected = "Female";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //insert a data rows
        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text,selected, dateTimePicker1.Text );

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //update valuew in a row
        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = dataGridView1.Rows[index];
            newData.Cells[0].Value = textBox1.Text;
            newData.Cells[1].Value = textBox2.Text;
            newData.Cells[2].Value = selected;
            newData.Cells[3].Value = dateTimePicker1.Text;



        }

        //select a row
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            selected = "";
            bday.Text = row.Cells[2].Value.ToString();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            selected = String.Empty;
            dateTimePicker1.Text = String.Empty;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void bday_Click(object sender, EventArgs e)
        {

        }
    }
}