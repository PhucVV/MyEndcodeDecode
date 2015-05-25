using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEndcodeDecode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_decode_MouseClick(object sender, MouseEventArgs e)
        {
            TB_out.Text =decode(TB_in.Text);
        }

        private void BT_endcode_Click(object sender, EventArgs e)
        {
            TB_out.Text = endcode(TB_in.Text);
        }

        private string RandomString(int size)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[size];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            int mod4 = base64EncodedData.Length % 4;
            if (mod4 > 0)
            {
                base64EncodedData += new string('=', 4 - mod4);
            }
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private string endcode(string _s)
        {
            string s = _s;
            s = Base64Encode(s);
            s=s.Replace("=", "");
            s += RandomString(2);
            s = Base64Encode(s);
            s = s.Replace("=", "");
            s += RandomString(3);
            s = Base64Encode(s);
            s = s.Replace("=", "");
            s += RandomString(9);
            return s;
        }

        private string decode(string _s)
        {
            string s = _s;
            s = s.Substring(0, s.Length - 9);
            s = Base64Decode(s);
            s = s.Substring(0, s.Length - 3);
            s = Base64Decode(s);
            s = s.Substring(0, s.Length - 2);
            s = Base64Decode(s);
            return s;
        }
    }
}
