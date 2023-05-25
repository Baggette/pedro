using System.Threading;
namespace pedro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pedro1.Visible = false;
            pedro2.Visible = false;
            pedro3.Visible = false;
            pedro4.Visible = false;
            pedro5.Visible = false;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
        }

        private void pedrobtn_Click(object sender, EventArgs e)
        {
            string message = "Are you ready to be pedroed?";
            string title = "Pedro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                pedrobtn.Visible = false;
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                timer5.Start();
            }
            else
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pedro1.Visible = !pedro1.Visible;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pedro2.Visible = !pedro2.Visible;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pedro3.Visible = !pedro3.Visible;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pedro4.Visible = !pedro4.Visible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pedro5.Visible = !pedro5.Visible;
        }
    }
}