namespace Крестики_нолики
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X turn; false = O turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
            UpdateTurnIndicator();
        }

        private void UpdateTurnIndicator()
        {
            if (turn)
                label1.Text = "Ходит X";
            else
                label1.Text = "Ходит O";
        }

        private void CheckForWinner()
        {
            bool there_is_a_winner = false;

            // Горизонтальная проверка
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                there_is_a_winner = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                there_is_a_winner = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                there_is_a_winner = true;

            // Вертикальная проверка
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                there_is_a_winner = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                there_is_a_winner = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                there_is_a_winner = true;

            // Диагональная проверка
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                there_is_a_winner = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                DisableButtons();

                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Wins!", "Yay!");
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw!", "Bummer!");
            }
        }

        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null && b.Name != "button10") // Предполагая, что button10 - это ваша кнопка рестарта
                    b.Enabled = false;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            UpdateTurnIndicator();
            CheckForWinner();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = true;
                    b.Text = "";
                }
            }

            UpdateTurnIndicator();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            UpdateTurnIndicator();
            CheckForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            UpdateTurnIndicator();
            CheckForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            UpdateTurnIndicator();
            CheckForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            UpdateTurnIndicator();
            CheckForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            UpdateTurnIndicator();
            CheckForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            UpdateTurnIndicator();
            CheckForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            UpdateTurnIndicator();
            CheckForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            UpdateTurnIndicator();
            CheckForWinner();
        }
    }
}