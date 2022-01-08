using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using form1;

namespace Colors
{
    public class MyColor
    {      
        private string colorname;
        private string hexCode;
        public MyColor()
        {
            colorname = "";
            HexCode = "";
        }
        public MyColor(string cname, string hCode)
        {
            colorname = cname;
            HexCode = hCode;
        }
        //side atr crtl+.
        public string HexCode { get => hexCode; set => hexCode = value; }
        //the same:   public string HexCode { get; set;}
        public string GetName()
        {
            return colorname;
        }
        
        public void ShowCode()
        {
            System.Windows.Forms.MessageBox.Show(this.HexCode);

        }

   
    }
}
