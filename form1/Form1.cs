using Colors;//another namespace in Color.cs
using ConnectionBD;

namespace form1
{
    public partial class Form1 : Form
    {
        MyColor Rojo = new MyColor("Red", "	#FF0000");
        ConexionPgSQL connecting = new ConexionPgSQL();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Rojo.HexCode = "new hex";
            Rojo.ShowCode();
            
        }

        private void show_color_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void connButton_Click(object sender, EventArgs e)
        {
            
            connecting.connect();
        }

        private void disconn_Click(object sender, EventArgs e)
        {
            connecting.disconnect();
        }

        private void lookforInBD_Click(object sender, EventArgs e)
        {
            resultView.DataSource = connecting.lookfor(lookfor.Text);
        }

        private void newData_Click(object sender, EventArgs e)
        {
            connecting.insert(colorname.Text, colorcode.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void colorcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            connecting.Drop(colorname.Text);
        }

        private void update_Click(object sender, EventArgs e)
        {
            connecting.Update(colorname.Text, colorcode.Text);
        }
    }
}