namespace thread__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Meno_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (radioButton1.Checked == true)
                {
                    int valore = Convert.ToInt16(label1.Text);
                    Thread.Sleep(1000);
                    valore--;
                    label1.Text = valore.ToString();
                }
                if (radioButton2.Checked == true)
                {
                    int valore = Convert.ToInt16(label2.Text);
                    Thread.Sleep(1000);
                    valore--;
                    label2.Text = valore.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    int valore = Convert.ToInt16(label3.Text);
                    Thread.Sleep(1000);
                    valore--;
                    label3.Text = valore.ToString();
                }
            }
        }
        

        private void Piu_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (radioButton1.Checked == true)
                {
                    int valore = Convert.ToInt16(label1.Text);
                    Thread.Sleep(1000);
                    valore++;
                    label1.Text = valore.ToString();
                }
                if (radioButton2.Checked == true)
                {
                    int valore = Convert.ToInt16(label2.Text);
                    Thread.Sleep(1000);
                    valore++;
                    label2.Text = valore.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    int valore = Convert.ToInt16(label3.Text);
                    Thread.Sleep(1000);
                    valore++;
                    label3.Text = valore.ToString();
                }
            }
        }

        private void threadMeno(object a)
        {
            Meno_Click(a, new EventArgs());
        }

        private void threadPiu(object a)
        {
            Piu_Click(a, new EventArgs());
        }

        private void TMeno_Click(object sender, EventArgs e)
        {
            Thread meno = new Thread(threadMeno);
            if (radioButton1.Checked == true)
            {
                meno.Start(label1);
            }
            if (radioButton2.Checked == true)
            {
                meno.Start(label2);
            }
            if (radioButton3.Checked == true)
            {
                meno.Start(label3);
            }
        }

        private void TPiu_Click(object sender, EventArgs e)
        {
            Thread piu = new Thread(threadPiu);
            if (radioButton1.Checked == true)
            {
                piu.Start(label1);
            }
            if (radioButton2.Checked == true)
            {
                piu.Start(label2);
            }
            if (radioButton3.Checked == true)
            {
                piu.Start(label3);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
