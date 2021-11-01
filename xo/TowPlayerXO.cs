using System;
using System.Collections.Generic;
using System.Text;

namespace xo
{
    class TowPlayerXO
    {
        private enum Stat
        {
            _,
            X,
            O
        }
        private static string[,] board = new string[,]
        {   {""+Stat._+"",""+Stat._+"",""+Stat._+""},
            {""+Stat._+"",""+Stat._+"",""+Stat._+""},
            {""+Stat._+"",""+Stat._+"",""+Stat._+""}
        };
        private bool[,] board_valid = new bool[,]
        {   {false,false,false},
            {false,false,false},
            {false,false,false}
        };

        private string winner;
        private string pick;
        private bool human, human2;
        private int xh, yh;
        private string stato = "" + Stat.O + "";
        private string statx = "" + Stat.X + "";

        private void Table()
        {
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(board[i, 0] + "|" + board[i, 1] + "|" + board[i, 2]);

            }
        }
        //lose stratoge checker
       
        private void Winer()
        {

            #region human
            //human 
            if (board[2, 0] == statx && board[2, 1] == statx && board[2, 2] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[1, 0] == statx && board[1, 1] == statx && board[1, 2] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[0, 0] == statx && board[0, 1] == statx && board[0, 2] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[0, 0] == statx && board[1, 0] == statx && board[2, 0] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[0, 1] == statx && board[1, 1] == statx && board[2, 1] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[0, 2] == statx && board[1, 2] == statx && board[2, 2] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[0, 0] == statx && board[1, 1] == statx && board[2, 2] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[0, 2] == statx && board[1, 1] == statx && board[2, 0] == statx)
            {
                winner = "human";
                human = true;
            }
            #endregion
            #region cpu
            //cpu
            if (board[2, 0] == stato && board[2, 1] == stato && board[2, 2] == stato)
            {
                winner = "human2";
                human2 = true;
            }
            if (board[1, 0] == stato && board[1, 1] == stato && board[1, 2] == stato)
            {
                winner = "human2";
                human2 = true;
            }
            if (board[0, 0] == stato && board[0, 1] == stato && board[0, 2] == stato)
            {
                winner = "human2";
                human2 = true;
            }
            if (board[0, 0] == stato && board[1, 0] == stato && board[2, 0] == stato)
            {
                winner = "human2";
                human2 = true;
            }
            if (board[0, 1] == stato && board[1, 1] == stato && board[2, 1] == stato)
            {
                winner = "human2";
                human2 = true;
            }
            if (board[0, 2] == stato && board[1, 2] == stato && board[2, 2] == stato)
            {
                winner = "human2";
                human2 = true;
            }
            if (board[0, 0] == stato && board[1, 1] == stato && board[2, 2] == stato)
            {
                winner = "human2";
                human2 = true;
            }
            if (board[0, 2] == stato && board[1, 1] == stato && board[2, 0] == stato)
            {
                winner = "human2";
                human2 = true;
            }
            #endregion
        }
        private void HumPick()
        {
            while (true)
            {
                pick = Console.ReadKey(true).KeyChar.ToString();
                if (pick == "1")
                {
                    xh = 0;
                    yh = 2;
                    break;
                }
                if (pick == "2")
                {
                    xh = 1;
                    yh = 2;
                    break;
                }
                if (pick == "3")
                {
                    xh = 2;
                    yh = 2;
                    break;
                }
                if (pick == "4")
                {
                    xh = 0;
                    yh = 1;
                    break;
                }
                if (pick == "5")
                {
                    xh = 1;
                    yh = 1;
                    break;
                }
                if (pick == "6")
                {
                    xh = 2;
                    yh = 1;
                    break;
                }
                if (pick == "7")
                {
                    xh = 0;
                    yh = 0;
                    break;
                }
                if (pick == "8")
                {
                    xh = 1;
                    yh = 0;
                    break;
                }
                if (pick == "9")
                {
                    xh = 2;
                    yh = 0;
                    break;
                }
                if (pick == "1" || pick == "2" || pick == "3" || pick == "4" || pick == "5" || pick == "6" || pick == "7" || pick == "8" || pick == "9")
                {
                    Console.WriteLine("u piked out of range :::::::::::::::");
                }
            }

            board[yh, xh] = "" + Stat.X + "";
            board_valid[yh, xh] = true;
            Winer();
        }
        private void HumPick2()
        {
            while (true)
            {
                pick = Console.ReadKey(true).KeyChar.ToString();
                if (pick == "1")
                {
                    xh = 0;
                    yh = 2;
                    break;
                }
                if (pick == "2")
                {
                    xh = 1;
                    yh = 2;
                    break;
                }
                if (pick == "3")
                {
                    xh = 2;
                    yh = 2;
                    break;
                }
                if (pick == "4")
                {
                    xh = 0;
                    yh = 1;
                    break;
                }
                if (pick == "5")
                {
                    xh = 1;
                    yh = 1;
                    break;
                }
                if (pick == "6")
                {
                    xh = 2;
                    yh = 1;
                    break;
                }
                if (pick == "7")
                {
                    xh = 0;
                    yh = 0;
                    break;
                }
                if (pick == "8")
                {
                    xh = 1;
                    yh = 0;
                    break;
                }
                if (pick == "9")
                {
                    xh = 2;
                    yh = 0;
                    break;
                }
                if (pick == "1" || pick == "2" || pick == "3" || pick == "4" || pick == "5" || pick == "6" || pick == "7" || pick == "8" || pick == "9")
                {
                    Console.WriteLine("u piked out of range :::::::::::::::");
                }
            }

            board[yh, xh] = "" + Stat.O + "";
            board_valid[yh, xh] = true;
            Winer();
        }
        private void Hum()
        {
            HumPick();
            Winer();
        }
        private void Hum2()
        {
            HumPick2();
            Winer();
        }
        private void tiemaker()
        {
            for (int i = 0; i < 3; i++)
            {

                board_valid[i, 0] = false;
                board_valid[i, 1] = false;
                board_valid[i, 2] = false;
                board[i, 0] = "" + Stat._ + "";
                board[i, 1] = "" + Stat._ + "";
                board[i, 2] = "" + Stat._ + "";
            }

        }
        private bool tie()
        {
            bool flag1 = false, flag2 = false, flag3 = false, fin;
            if (board_valid[2, 0] == true && board_valid[2, 1] == true && board_valid[2, 2] == true)
            {
                flag1 = true;
            }
            if (board_valid[1, 0] == true && board_valid[1, 1] == true && board_valid[1, 2] == true)
            {
                flag2 = true;
            }
            if (board_valid[0, 0] == true && board_valid[0, 1] == true && board_valid[0, 2] == true)
            {
                flag3 = true;
            }
            if (flag1 && flag2 && flag3 == true)
            {
                fin = true;
                tiemaker();
            }
            else
            {
                fin = false;
            }
            return fin;
        }
        public void Start()
        {
            while (true)
            {
                if (human == true)
                {
                    Console.Clear();
                    Table();
                    Console.WriteLine("winner is " + winner + "do u want continue ?");
                    string chuos = Console.ReadKey(true).KeyChar.ToString();
                    if (chuos == "y")
                    {
                        tiemaker();
                        Console.Clear();
                        human = false;
                    }
                    else
                    {
                        break;
                    }
                }
                if (human2 == true)
                {
                    Console.Clear();
                    Table();
                    Console.WriteLine("winner is " + winner + "do u want continue ?");
                    string chuos = Console.ReadKey(true).KeyChar.ToString();
                    if (chuos == "y")
                    {
                        tiemaker();
                        Console.Clear();
                        human2 = false;

                    }
                    else
                    {
                        break;
                    }

                }
                while (true)
                {
                    
                    Table();
                    Winer();

                    Hum2();
                    Winer();
                    if (human2 == true)
                    {

                        break;
                    }
                    if (tie() == true)
                    {
                        Console.Clear();
                        break;
                    }
                    Console.Clear();
                    Table();
                    Hum();
                    if (human == true)
                    {

                        break;
                    }
                    if (tie() == true)
                    {
                        Console.Clear();
                        break;
                    }
                    Console.Clear();
                }
            }
        }
    }
}
