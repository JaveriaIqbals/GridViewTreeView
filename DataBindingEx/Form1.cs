namespace DataBindingEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index =   dataGridView1.Rows.Add();
            this.dataGridView1.Rows[index].Cells[0].Value = this.textBox1.Text;
            this.dataGridView1.Rows[index].Cells[1].Value = this.textBox2.Text;
            this.dataGridView1.Rows[index].Cells[2].Value = this.textBox3.Text;
            this.dataGridView1.Rows[index].Cells[3].Value = this.textBox4.Text;
           

            //this.dataGridView1.Rows.Add(this.textBox1.Text, this.textBox2.Text,
               // this.textBox3.Text, this.textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if row is selected
            foreach (DataGridViewRow r in this.dataGridView1.SelectedRows)
            {
                this.dataGridView1.Rows.Remove(r);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection c =  this.dataGridView1.SelectedRows;
            DataGridViewRow row = c[0];

            row.Cells[0].Value = this.textBox1.Text;
            row.Cells[1].Value = this.textBox2.Text;
            row.Cells[2].Value = this.textBox3.Text;
            row.Cells[3].Value = this.textBox4.Text;

            /*foreach(DataGridViewRow r in this.dataGridView1.SelectedRows)
            {

            }*/

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.textBox2.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.textBox3.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.textBox4.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}