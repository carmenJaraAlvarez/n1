using Colors;//another namespace in Color.cs
namespace form1
{
    public partial class Form1 : Form
    {
        MyColor Rojo = new MyColor("Red", "	#FF0000");
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
    }
}