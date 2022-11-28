namespace tonomat_de_vanzari
{
    public partial class Form1 : Form
    {
        int credit = 0;
        PictureBox[] rest;
        public Form1()
        {
            InitializeComponent();
        }

        private void Nickel_Click(object sender, EventArgs e)
        {
            credit += 5;
            credit_label.Text = credit.ToString();
            if(credit > 20)
                Credit_Checker(credit);
        }

        private void Dime_Click(object sender, EventArgs e)
        {
            credit += 10;
            credit_label.Text = credit.ToString();
            if (credit > 20)
                Credit_Checker(credit);
        }

        private void Quarter_Click(object sender, EventArgs e)
        {
            credit += 25;
            credit_label.Text = credit.ToString();
            if (credit > 20)
                Credit_Checker(credit);
        }

        private void Credit_Checker(int credit)
        {
            int i = 0;
            while(credit > 0)
            {
                if((credit - 20) > 0)
                {
                    credit -= 20;
                    rest[i] = new PictureBox();
                    rest[i].Image = tonomat_de_vanzari.Properties.Resources.Merchandise;
                    i++;
                }
                else if((credit - 10) > 0)
                {
                    credit -= 10;
                    rest[i] = new PictureBox();
                    rest[i].Image = tonomat_de_vanzari.Properties.Resources.Dime;
                    i++;
                }
                else if((credit - 5) > 0)
                {
                    credit -= 5;
                    rest[i] = new PictureBox();
                    rest[i].Image = tonomat_de_vanzari.Properties.Resources.Nickel;
                    i++;
                }
            }
            for(i = 0; i < rest.Length; i++)
            {
                rest[i].Parent = this;
                rest[i].Size = new Size(80, 80);
                rest[i].Location = new Point(i * 160, 100);
                rest[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }
    }
}