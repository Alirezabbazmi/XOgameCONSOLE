using System;
using System.IO;

namespace xo
{
    class Game
    {
        private string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\DataBaseOfGame";
        private string textfile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\DataBaseOfGame\database.txt";
        private string turnOF = " ";
        private string content = " ";
        private string winner;
        private bool human, cp;
        private enum Stat
        {
            _,
            X,
            O
        }
        private string stato = "" + Stat.O + "";
        private string statx = "" + Stat.X + "";
        private static string[] board = new string[]
        {   ""+Stat._+"",""+Stat._+"",""+Stat._+"",
            ""+Stat._+"",""+Stat._+"",""+Stat._+"",
            ""+Stat._+"",""+Stat._+"",""+Stat._+""
        };
        private bool[] board_valid = new bool[]
        {
            false,false,false,false,false,false,false,false,false
        };


        private void DatabaseCreate()
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            if (!File.Exists(dir))
            {
                using (StreamWriter sw = File.CreateText(textfile))
                {
                    sw.WriteLine(" ");
                }
            }


        }
        private void DatabaseSetter()
        {
            if (File.Exists(textfile) == false)
            {
                DatabaseCreate();
            }
            if (File.Exists(textfile) == true)
            {
                Winer();
                if (tie() == true)
                {
                    try
                    {

                        using (StreamWriter wr = File.AppendText(textfile))
                        {
                            wr.WriteLine("* game tie *");

                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
                else if (cp == true || human == true)
                {
                    try
                    {

                        using (StreamWriter wr = File.AppendText(textfile))
                        {
                            wr.WriteLine("* winner is :" + winner+" *");
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
                else
                {

                   
                    try
                    {

                        using (StreamWriter wr = File.AppendText(textfile))
                        {
                            wr.WriteLine("turn of : " + turnOF);
                            wr.WriteLine(content);
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message) ;
                    }
                }
            }
        }
        private void DataBaseNewGameSetter()
        {
            if (File.Exists(textfile) == true)
            {
                try
            {

                using (StreamWriter wr = File.AppendText(textfile))
                {
                    wr.WriteLine("* new game *");

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            }
        }
        private void Table()
        {
            Console.WriteLine("" + board[6] + "" + "|" + "" + board[7] + "" + "|" + "" + board[8] + "");
            Console.WriteLine("" + board[3] + "" + "|" + "" + board[4] + "" + "|" + "" + board[5] + "");
            Console.WriteLine("" + board[0] + "" + "|" + "" + board[1] + "" + "|" + "" + board[2] + "");
        }
        private void tiemaker()
        {
            for (int i = 0; i < 9; i++)
            {
                board_valid[i] = false;
                board[i] = "" + Stat._ + "";
            }
            cp = false;
            human = false;
        }
        private bool tie()
        {
            bool flag1 = false, flag2 = false, flag3 = false, fin;
            if (board_valid[6] == true && board_valid[7] == true && board_valid[8] == true)
            {
                flag3 = true;
            }
            if (board_valid[3] == true && board_valid[4] == true && board_valid[5] == true)
            {
                flag2 = true;
            }
            if (board_valid[0] == true && board_valid[1] == true && board_valid[2] == true)
            {
                flag1 = true;
            }
            if (flag1 && flag2 && flag3 == true)
            {
                fin = true;
            }
            else
            {
                fin = false;
            }
            return fin;
        }
        private void Winer()
        {
            #region human
            if (board[0] == statx && board[1] == statx && board[2] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[3] == statx && board[4] == statx && board[5] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[6] == statx && board[7] == statx && board[8] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[6] == statx && board[3] == statx && board[0] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[7] == statx && board[4] == statx && board[1] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[8] == statx && board[5] == statx && board[2] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[6] == statx && board[4] == statx && board[2] == statx)
            {
                winner = "human";
                human = true;
            }
            if (board[8] == statx && board[4] == statx && board[0] == statx)
            {
                winner = "human";
                human = true;
            }
            #endregion
            #region cpu
            if (board[0] == stato && board[1] == stato && board[2] == stato)
            {
                winner = "cpu";
                cp = true;
            }
            if (board[3] == stato && board[4] == stato && board[5] == stato)
            {
                winner = "cpu";
                cp = true;
            }
            if (board[6] == stato && board[7] == stato && board[8] == stato)
            {
                winner = "cpu";
                cp = true;
            }
            if (board[6] == stato && board[3] == stato && board[0] == stato)
            {
                winner = "cpu";
                cp = true;
            }
            if (board[7] == stato && board[4] == stato && board[1] == stato)
            {
                winner = "cpu";
                cp = true;
            }
            if (board[8] == stato && board[5] == stato && board[2] == stato)
            {
                winner = "cpu";
                cp = true;
            }
            if (board[6] == stato && board[4] == stato && board[2] == stato)
            {
                winner = "cpu";
                cp = true;
            }
            if (board[8] == stato && board[4] == stato && board[0] == stato)
            {
                winner = "cpu";
                cp = true;
            }
            #endregion
        }
        private void HumPick()
        {
            while (true)
            {
                int Hpick = int.Parse(Console.ReadKey(true).KeyChar.ToString()) - 1;
                if (board_valid[Hpick] == false)
                {
                    board[Hpick] = statx;
                    board_valid[Hpick] = true;
                    turnOF = "human";
                    content = "board[" + Hpick + "]";
                    DatabaseSetter();
                    break;
                }
            }
        }
        private void Hum()
        {
            HumPick();
        }
        private int loseCheck()
        {
            int loseC = 9;
            if (board[0] == statx && board[1] == statx)
            {
                if (board_valid[2] == false)
                {
                    loseC = 2;
                }
            }
            else if (board[0] == statx && board[2] == statx)
            {
                if (board_valid[1] == false)
                {
                    loseC = 1;

                }
            }
            else if (board[1] == statx && board[2] == statx)
            {
                if (board_valid[0] == false)
                {
                    loseC = 0;
                }
            }
            if (board[3] == statx && board[4] == statx)
            {
                if (board_valid[5] == false)
                {
                    loseC = 5;
                }
            }
            else if (board[3] == statx && board[5] == statx)
            {
                if (board_valid[4] == false)
                {
                    loseC = 4;
                }

            }
            else if (board[4] == statx && board[5] == statx)
            {
                if (board_valid[3] == false)
                {
                    loseC = 3;
                }
            }
            if (board[6] == statx && board[7] == statx)
            {
                if (board_valid[8] == false)
                {
                    loseC = 8;
                }
            }
            else if (board[6] == statx && board[8] == statx)
            {
                if (board_valid[7] == false)
                {
                    loseC = 7;
                }
            }
            else if (board[7] == statx && board[8] == statx)
            {
                if (board_valid[6] == false)
                {
                    loseC = 6;
                }
            }
            if (board[6] == statx && board[3] == statx)
            {
                if (board_valid[0] == false)
                {
                    loseC = 0;
                }
            }
            else if (board[6] == statx && board[0] == statx)
            {
                if (board_valid[3] == false)
                {
                    loseC = 3;
                }
            }
            else if (board[3] == statx && board[0] == statx)
            {
                if (board_valid[6] == false)
                {
                    loseC = 6;
                }
            }
            if (board[7] == statx && board[4] == statx)
            {
                if (board_valid[1] == false)
                {
                    loseC = 1;
                }
            }
            else if (board[7] == statx && board[1] == statx)
            {
                if (board_valid[4] == false)
                {
                    loseC = 4;
                }
            }
            else if (board[1] == statx && board[4] == statx)
            {
                if (board_valid[7] == false)
                {
                    loseC = 7;
                }
            }
            if (board[8] == statx && board[5] == statx)
            {
                if (board_valid[2] == false)
                {
                    loseC = 2;
                }
            }
            else if (board[8] == statx && board[2] == statx)
            {
                if (board_valid[5] == false)
                {
                    loseC = 5;
                }
            }
            else if (board[5] == statx && board[2] == statx)
            {
                if (board_valid[8] == false)
                {
                    loseC = 8;
                }
            }
            if (board[6] == statx && board[4] == statx)
            {
                if (board_valid[2] == false)
                {
                    loseC = 2;
                }
            }
            else if (board[6] == statx && board[2] == statx)
            {
                if (board_valid[4] == false)
                {
                    loseC = 4;
                }
            }
            else if (board[4] == statx && board[2] == statx)
            {
                if (board_valid[6] == false)
                {
                    loseC = 6;
                }
            }
            if (board[8] == statx && board[4] == statx)
            {
                if (board_valid[0] == false)
                {
                    loseC = 0;
                }
            }
            else if (board[0] == statx && board[4] == statx)
            {
                if (board_valid[8] == false)
                {
                    loseC = 8;
                }
            }
            else if (board[0] == statx && board[8] == statx)
            {
                if (board_valid[4] == false)
                {
                    loseC = 4;
                }
            }
            return loseC;
        }
        private int winCheck()
        {
            int winC = 9 ;
            if (board[0] == stato && board[1] == stato)
            {
                if (board_valid[2] == false)
                {
                    winC = 2;
                }
            }
            else if (board[0] == stato && board[2] == stato)
            {
                if (board_valid[1] == false)
                {
                    winC = 1;
                }
            }
            else if (board[1] == stato && board[2] == stato)
            {
                if (board_valid[0] == false)
                {
                    winC = 0;
                }
            }
            if (board[3] == stato && board[4] == stato)
            {
                if (board_valid[5] == false)
                {
                    winC = 5;
                }
            }
            else if (board[3] == stato && board[5] == stato)
            {
                if (board_valid[4] == false)
                {
                    winC = 4;
                }
            }
            else if (board[4] == stato && board[5] == stato)
            {
                if (board_valid[3] == false)
                {
                    winC = 3;
                }
            }
            if (board[6] == stato && board[7] == stato)
            {
                if (board_valid[8] == false)
                {
                    winC = 8;
                }
            }
            else if (board[6] == stato && board[8] == stato)
            {
                if (board_valid[7] == false)
                {
                    winC = 7;
                }
            }
            else if (board[7] == stato && board[8] == stato)
            {
                if (board_valid[6] == false)
                {
                    winC = 6;
                }
            }
            if (board[6] == stato && board[3] == stato)
            {
                if (board_valid[0] == false)
                {
                    winC = 0;
                }
            }
            else if (board[6] == stato && board[0] == stato)
            {
                if (board_valid[3] == false)
                {
                    winC = 3;
                }
            }
            else if (board[3] == stato && board[0] == stato)
            {
                if (board_valid[6] == false)
                {
                    winC = 6;
                }
            }
            if (board[7] == stato && board[4] == stato)
            {
                if (board_valid[1] == false)
                {
                    winC = 1;
                }
            }
            else if (board[7] == stato && board[1] == stato)
            {
                if (board_valid[4] == false)
                {
                    winC = 4;
                }
            }
            else if (board[1] == stato && board[4] == stato)
            {
                if (board_valid[7] == false)
                {
                    winC = 7;
                }
            }
            if (board[8] == stato && board[5] == stato)
            {
                if (board_valid[2] == false)
                {
                    winC = 2;
                }
            }
            else if (board[8] == stato && board[2] == stato)
            {
                if (board_valid[5] == false)
                {
                    winC = 5;
                }
            }
            else if (board[5] == stato && board[2] == stato)
            {
                if (board_valid[8] == false)
                {
                    winC = 8;
                }
            }
            if (board[6] == stato && board[4] == stato)
            {
                if (board_valid[2] == false)
                {
                    winC = 2;
                }
            }
            else if (board[6] == stato && board[2] == stato)
            {
                if (board_valid[4] == false)
                {
                    winC = 4;
                }
            }
            else if (board[4] == stato && board[2] == stato)
            {
                if (board_valid[6] == false)
                {
                    winC = 6;
                }
            }
            if (board[8] == stato && board[4] == stato)
            {
                if (board_valid[0] == false)
                {
                    winC = 0;
                }
            }
            else if (board[0] == stato && board[4] == stato)
            {
                if (board_valid[8] == false)
                {
                    winC = 8;
                }
            }
            else if (board[0] == stato && board[8] == stato)
            {
                if (board_valid[4] == false)
                {
                    winC = 4;
                }
            }
            return winC;
        }
        private void cpuPicker()
        {
            while (true)
            {
                var ran = new Random();
                var firstpick = ran.Next(1, 9) -1;
                if (board_valid[firstpick] == false)
                {

                    board[firstpick] = stato;
                    board_valid[firstpick] = true;
                    turnOF = "cpu";
                    content = "board[" + firstpick + "]";
                    DatabaseSetter();
                    break;
                }
            }
        }
        private void intel()
        {
            if (winCheck() < 9)
            {
                board[winCheck()] = stato;
                board_valid[winCheck() - 1] = true;
                turnOF = "cpu";
                content = "board[" + winCheck() + "]";
                DatabaseSetter();
            }
            else if (loseCheck() < 9)
            {

                board[loseCheck()] = stato;
                board_valid[loseCheck()] = true;
                turnOF = "cpu";
                content = "board[" + loseCheck() + "]";
                DatabaseSetter();
            }
            else
            {
                cpuPicker();
            }
        }
        private void Cpu()
        {
            intel();
        }
        public void Start()
        {
            while (cp == false && human == false)
            {
                while (true)
                {

                    Cpu();
                    Winer();
                    if (cp == true)
                    {
                        Console.Clear();
                        Table();
                        Console.WriteLine("winner is  |* " + winner + " *|  do u want continue ?");
                        string chuos = Console.ReadKey(true).KeyChar.ToString();
                        if (chuos == "y")
                        {
                            tiemaker();
                            Console.Clear();
                            cp = false;
                            DataBaseNewGameSetter();

                        }
                        else
                        {
                            break;
                        }
                        break;
                    }
                    if (tie() == true)
                    {
                        tiemaker();
                        break;
                    }
                    Table();
                    Hum();
                    Winer();
                    if (human == true)
                    {
                        Console.Clear();
                        Table();
                        Console.WriteLine("winner is  |* " + winner + " *|  do u want continue ?");
                        string chuos = Console.ReadKey(true).KeyChar.ToString();
                        if (chuos == "y")
                        {
                            tiemaker();
                            Console.Clear();
                            human = false;
                            DataBaseNewGameSetter();
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (tie() == true)
                    {
                        tiemaker();
                        break;
                    }
                    Console.Clear();
                }
            }
        }
    }
}
