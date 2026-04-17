using System.Reflection;
using System.Threading;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static int global_count = 0;
        static int globalmsg1_count = 0;
        static int globalmsg2_count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void CustomShowMessage(string text, int delay)
        {
            main_label.Text = $"loading message...({text})";
            Thread.Sleep(delay);
            main_label.Text = text;
        }
        void CustomGlobalCount()
        {
            global_count++;
            globalLabelCount.Text = global_count.ToString();
        }

        void CustomMsg1Count()
        {
            globalmsg1_count++;
            msg1label.Text = globalmsg1_count.ToString();
        }
        void CustomMsg2Count()
        {
            globalmsg2_count++;
            msg2label.Text = globalmsg2_count.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new(CustomGlobalCount);
            thread1.Start();
            Thread thread2 = new(() => CustomShowMessage("Message 1", 5000));
            thread2.Start();
            Thread thread3 = new(CustomMsg1Count);
            thread3.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread1 = new(CustomGlobalCount);
            thread1.Start();
            Thread thread2 = new(() => CustomShowMessage("Message 2", 5000));
            thread2.Start();
            Thread thread3 = new(CustomMsg2Count);
            thread3.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void msg1count_click(object sender, EventArgs e)
        {

        }

        private void msg2count_click(object sender, EventArgs e)
        {

        }
    }
}
