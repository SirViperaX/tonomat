namespace tonomat_de_vanzari
{
    public partial class Form1 : Form
    {
        int credit = 0;
        PictureBox[] result = new PictureBox[5];
        public Form1()
        {
            InitializeComponent();
            InitializePictureBoxes(result);
        }

        private PictureBox[] InitializePictureBoxes(PictureBox[] pictureBoxes)
        {
            for(int i =0; i < 5; i++)
            {
                pictureBoxes[i] = new PictureBox();
            }
            return pictureBoxes;
        }

        private void Nickel_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(this);
            credit += 5;
            if(credit >= 20)
                credit = Credit_Checker(credit);
            credit_label.Text = credit.ToString();

        }

        private void Dime_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(this);
            credit += 10;
            if (credit >= 20)
                credit = Credit_Checker(credit);
            credit_label.Text = credit.ToString();

        }

        private void Quarter_Click(object sender, EventArgs e)
        {
            ClearPictureBoxes(this);
            credit += 25;
            if (credit >= 20)
                credit = Credit_Checker(credit);
            credit_label.Text = credit.ToString();
        }

        private int Credit_Checker(int credit)
        {
            ClearPictureBoxes(this);
            int i = 0, a = 0, b = 0, c = 0;
            while(credit > 0 && c == 0)
            {
                if((credit - 20) >= 0 && a == 0)
                {
                    credit -= 20;
                    result[i].Parent = this;
                    result[i].Size = new Size(80, 80);
                    result[i].Location = new Point(0, 100);
                    result[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    result[i].Image = tonomat_de_vanzari.Properties.Resources.Merchandise;
                    this.Controls.Add(result[i]);
                    i++;
                    a++;
                }
                else if((credit - 10) >= 0 && b == 0)
                {
                    credit -= 10;
                    result[i].Image = tonomat_de_vanzari.Properties.Resources.Dime;
                    result[i].Visible = true;
                    result[i].Parent = this;
                    result[i].Size = new Size(80, 80);
                    result[i].Location = new Point(i*80, 100);
                    result[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(result[i]);
                    i++;
                    b++;
                }
                else if((credit - 5) >= 0 && c == 0)
                {
                    credit -= 5;
                    result[i].Image = tonomat_de_vanzari.Properties.Resources.Nickel;
                    result[i].Visible = true;
                    result[i].Parent = this;
                    result[i].Size = new Size(80, 80);
                    result[i].Location = new Point(i*80, 100);
                    result[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(result[i]);
                    i++;
                    c++;
                }
            }
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = $"Merchandise {a}, Dime {b}, Nickel {c}";
            return credit;
        }
        private void ClearPictureBoxes(Control parent)
        {
          for(int i =0; i <5; i++)
            {
                result[i].Image = tonomat_de_vanzari.Properties.Resources.Empty;
            }

        }
    }
}