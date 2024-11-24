using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4 
{
    public partial class lab4 : Form 
    {
        public static lab4 formInstance;
        public ListBox PalindromeList;

        public lab4()
        {
            InitializeComponent();
            formInstance = this;
            PalindromeList = listBox1;
        }

        public static int start;
        public static int num;

        public static string ReverseString(string stringInput)
        {
            char[] charArray = stringInput.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int myvalue1;
            int myvalue2;

            if (!int.TryParse(textBox1.Text, out myvalue1) || !int.TryParse(textBox2.Text, out myvalue2) || myvalue1 <= 0 || myvalue2 <= 0)
            {
                label3.Text = "Enter positive integers within range";
                return;
            }

            start = myvalue1;
            num = myvalue2;
            label3.Text = "";

            int count = 0;
            for (int i = start; count < num; i++)
            {
                string myString = i.ToString();
                string reverse = ReverseString(myString);

                if (myString == reverse)
                {
                    listBox1.Items.Add(myString);
                    count++;
                }
            }
        }
    }
}
