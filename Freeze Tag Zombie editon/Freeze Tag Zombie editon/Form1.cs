namespace Freeze_Tag_Zombie_editon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void play_click(object sender, MouseEventArgs e)
        {
            PLAY.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            next_backdrop.Visible = true;
            name.Visible = false;
            grass.Visible = true;
            await Task.Delay(2 * 1000);
            zombie.Location = new Point(zombie.Location.X + -50, zombie.Location.Y);
            await Task.Delay(2 * 1000);
            zombie.Location = new Point(zombie.Location.X + -50, zombie.Location.Y);
            await Task.Delay(2 * 1000);
            zombie.Location = new Point(zombie.Location.X + -50, zombie.Location.Y);
            await Task.Delay(2 * 1000);
            zombie.Location = new Point(zombie.Location.X + -50, zombie.Location.Y);
            await Task.Delay(2 * 1000);
            zombie.Location = new Point(zombie.Location.X + -50, zombie.Location.Y);
            await Task.Delay(2 * 1000);
            zombie.Location = new Point(zombie.Location.X + -50, zombie.Location.Y);
            await Task.Delay(2 * 1000);
            zombie.Location = new Point(zombie.Location.X + -50, zombie.Location.Y);
            misson_failed.Visible = true;
            if (zombie.Visible == false)
            {
                misson_failed.Visible = false;
            }
            await Task.Delay(2 * 2000);
            PLAY.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            name.Visible = true;
            grass.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            zombie.Location = new Point(zombie.Location.X + 50, zombie.Location.Y);
            zombie.Location = new Point(zombie.Location.X + 50, zombie.Location.Y);
            zombie.Location = new Point(zombie.Location.X + 50, zombie.Location.Y);
            zombie.Location = new Point(zombie.Location.X + 50, zombie.Location.Y);
            zombie.Location = new Point(zombie.Location.X + 50, zombie.Location.Y);
            zombie.Location = new Point(zombie.Location.X + 50, zombie.Location.Y);
            zombie.Location = new Point(zombie.Location.X + 50, zombie.Location.Y);
            misson_failed.Visible = false;
            p_backdrop.Visible = false;
            next_backdrop.Visible = false;
            house.Visible = false;
            wolfy.Location = new Point(128, 795);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grass_Click(object sender, EventArgs e)
        {

        }

        private void b_click(object sender, EventArgs e)
        {
            wolfy.Location = new Point(wolfy.Location.X + -50, wolfy.Location.Y);
        }

        private void f_click(object sender, EventArgs e)
        {
            wolfy.Location = new Point(wolfy.Location.X + 50, wolfy.Location.Y);
        }

        private void zombie_click(object sender, EventArgs e)
        {
            zombie.Visible = false;
        }

        private void nextbackdrop(object sender, EventArgs e)
        {
            zombie.Visible = false;
            house.Visible = true;
            p_backdrop.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void p_click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            next_backdrop.Visible = true;
            house.Visible = false;
            zombie.Visible = true;
        }
    }
}