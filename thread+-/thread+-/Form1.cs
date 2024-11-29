namespace thread__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private Label etichetta()
        {
            if (radioButton1.Checked == true)
                return label1;
            if (radioButton2.Checked == true)
                return label2;
            if (radioButton3.Checked == true)
                return label3;
            else
                return null;
        }
        
        private void Meno_Click(object sender, EventArgs e)
        {
            Label label = etichetta();
            int valore = Convert.ToInt16(label.Text);
            while (true)
            {
                Thread.Sleep(1000);
                valore--;
                label.Text = (valore).ToString();
            }
        }
        

        private void Piu_Click(object sender, EventArgs e)
        {
            Label label = etichetta();
            int valore = Convert.ToInt16(label.Text);
            while (true)
            {
                Thread.Sleep(1000);
                valore++;
                label.Text = valore.ToString();
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
            meno.Start(etichetta());
        }

        private void TPiu_Click(object sender, EventArgs e)
        {
            Thread piu = new Thread(threadPiu);
            piu.Start(etichetta());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
