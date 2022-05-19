namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {

        bool playerTurn = false;

        string[,] gameBoard =
        {
            {" ", " ", " "},
            {" ", " ", " "},
            {" ", " ", " "}
        };

        public Form1()
        {
            InitializeComponent();

            lbl00.Text = gameBoard[0, 0];
            lbl01.Text = gameBoard[0, 1];
            lbl02.Text = gameBoard[0, 2];
            lbl10.Text = gameBoard[1, 0];
            lbl11.Text = gameBoard[1, 1];
            lbl12.Text = gameBoard[1, 2];
            lbl20.Text = gameBoard[2, 0];
            lbl21.Text = gameBoard[2, 1];
            lbl22.Text = gameBoard[2, 2];

        }

        private void lbl00_Click(object sender, EventArgs e)
        {
            if (gameBoard[0, 0] == "X" || gameBoard[0, 0] == "O")
            {

            }
            else
            {
                if (playerTurn == false)
                {
                    lbl00.Text = "X";
                    playerTurn = true;
                    gameBoard[0, 0] = "X";
                }
                else
                {
                    lbl00.Text = "O";
                    playerTurn = false;
                    gameBoard[0, 0] = "O";
                }
            }

            winner();
        }

        private void lbl01_Click(object sender, EventArgs e)
        {
            if (gameBoard[0, 1] == "X" || gameBoard[0, 1] == "O")
            {

            }
            else
            {
                if (playerTurn == false)
                {
                    lbl01.Text = "X";
                    playerTurn = true;
                    gameBoard[0, 1] = "X";
                }
                else
                {
                    lbl01.Text = "O";
                    playerTurn = false;
                    gameBoard[0, 1] = "O";
                }
            }

            winner();
        }

        private void lbl02_Click(object sender, EventArgs e)
        {
            if (gameBoard[0, 2] == "X" || gameBoard[0, 2] == "O")
            {

            }
            else
            {
                if (playerTurn == false)
                {
                    lbl02.Text = "X";
                    playerTurn = true;
                    gameBoard[0, 2] = "X";
                }
                else
                {
                    lbl02.Text = "O";
                    playerTurn = false;
                    gameBoard[0, 2] = "O";
                }
            }

            winner();
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            if (gameBoard[1, 0] == "X" || gameBoard[1, 0] == "O")
            {

            }
            else
            {
                if (playerTurn == false)
                {
                    lbl10.Text = "X";
                    playerTurn = true;
                    gameBoard[1, 0] = "X";
                }
                else
                {
                    lbl10.Text = "O";
                    playerTurn = false;
                    gameBoard[1, 0] = "O";
                }
            }

            winner();
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            if (gameBoard[1, 1] == "X" || gameBoard[1, 1] == "O")
            {

            }
            else
            {
                if (playerTurn == false)
                {
                    lbl11.Text = "X";
                    playerTurn = true;
                    gameBoard[1, 1] = "X";
                }
                else
                {
                    lbl11.Text = "O";
                    playerTurn = false;
                    gameBoard[1, 1] = "O";
                }
            }

            winner();
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            if (gameBoard[1, 2] == "X" || gameBoard[1, 2] == "O")
            {

            }
            else
            {
                if (playerTurn == false)
                {
                    lbl12.Text = "X";
                    playerTurn = true;
                    gameBoard[1, 2] = "X";
                }
                else
                {
                    lbl12.Text = "O";
                    playerTurn = false;
                    gameBoard[1, 2] = "O";
                }
            }

            winner();
        }

        private void lbl20_Click(object sender, EventArgs e)
        {
            if (gameBoard[2, 0] == "X" || gameBoard[2, 0] == "O")
            {

            }
            else
            {
                if (playerTurn == false)
                {
                    lbl20.Text = "X";
                    playerTurn = true;
                    gameBoard[2, 0] = "X";
                }
                else
                {
                    lbl20.Text = "O";
                    playerTurn = false;
                    gameBoard[2, 0] = "O";
                }
            }

            winner();
        }

        private void lbl21_Click(object sender, EventArgs e)
        {
            if (gameBoard[2, 1] == "X" || gameBoard[2, 1] == "O")
            {

            }
            else
            {
                if (playerTurn == false)
                {
                    lbl21.Text = "X";
                    playerTurn = true;
                    gameBoard[2, 1] = "X";
                }
                else
                {
                    lbl21.Text = "O";
                    playerTurn = false;
                    gameBoard[2, 1] = "O";
                }
            }

            winner();
        }

        private void lbl22_Click(object sender, EventArgs e)
        {
            if (gameBoard[2, 2] == "X" || gameBoard[2, 2] == "O")
            {

            }
            else
            {
                if (playerTurn == false)
                {
                    lbl22.Text = "X";
                    playerTurn = true;
                    gameBoard[2, 2] = "X";
                }
                else
                {
                    lbl22.Text = "O";
                    playerTurn = false;
                    gameBoard[2, 2] = "O";
                }
            }

            winner();
        }

        private void winner()
        {

            bool xWins = false;
            bool oWins = false;

            // ********************************************************
            //                       X is winner
            // ********************************************************

            if (gameBoard[0, 0] == "X" && gameBoard[0, 1] == "X" && gameBoard[0, 2] == "X")
            {
                lblWinner.Text = "Player X wins!!!";
                xWins = true;
            }
            else if (gameBoard[0, 0] == "X" && gameBoard[1, 0] == "X" && gameBoard[2, 0] == "X")
            {
                lblWinner.Text = "Player X wins!!!";
                xWins = true;
            }
            else if (gameBoard[0, 1] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 1] == "X")
            {
                lblWinner.Text = "Player X wins!!!";
                xWins = true;
            }
            else if (gameBoard[0, 2] == "X" && gameBoard[1, 2] == "X" && gameBoard[2, 2] == "X")
            {
                lblWinner.Text = "Player X wins!!!";
                xWins = true;
            }
            else if (gameBoard[0, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 2] == "X")
            {
                lblWinner.Text = "Player X wins!!!";
                xWins = true;
            }
            else if (gameBoard[0, 2] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 0] == "X")
            {
                lblWinner.Text = "Player X wins!!!";
                xWins = true;
            }
            else if (gameBoard[1, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[1, 2] == "X")
            {
                lblWinner.Text = "Player X wins!!!";
                oWins = true;
            }

            // ********************************************************
            //                       O is winner
            // ********************************************************

            if (gameBoard[0, 0] == "O" && gameBoard[0, 1] == "O" && gameBoard[0, 2] == "O")
            {
                lblWinner.Text = "Player O wins!!!";
                oWins = true;
            }
            else if (gameBoard[0, 0] == "O" && gameBoard[1, 0] == "O" && gameBoard[2, 0] == "O")
            {
                lblWinner.Text = "Player O wins!!!";
                oWins = true;
            }
            else if (gameBoard[0, 1] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 1] == "O")
            {
                lblWinner.Text = "Player O wins!!!";
                oWins = true;
            }
            else if (gameBoard[0, 2] == "O" && gameBoard[1, 2] == "O" && gameBoard[2, 2] == "O")
            {
                lblWinner.Text = "Player O wins!!!";
                oWins = true;
            }
            else if (gameBoard[0, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 2] == "O")
            {
                lblWinner.Text = "Player O wins!!!";
                oWins = true;
            }
            else if (gameBoard[0, 2] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 0] == "O")
            {
                lblWinner.Text = "Player O wins!!!";
                oWins = true;
            }
            else if (gameBoard[1, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[1, 2] == "O")
            {
                lblWinner.Text = "Player O wins!!!";
                oWins = true;
            }
        }
    }
}