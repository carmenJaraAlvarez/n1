using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
    public class MyColor
    {      
        private string colorname;
        private string hexCode;
        public MyColor()
        {
            colorname = "";
            hexCode = "";
        }
        public MyColor(string cname, string hCode)
        {
            colorname = cname;
            hexCode = hCode;
        }

        public string getName()
        {
            return colorname;
        }
        public void ShowName()
        {
            System.Windows.Forms.MessageBox.Show(getName());
        }

        public void ShowColor()
        {

        }
    }
}
