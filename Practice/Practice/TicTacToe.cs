using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class TicTacToe
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw,
            Error
        }
        public static void Run(string description)
        {
            Console.WriteLine(description.Replace(" ", Environment.NewLine));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            //Console.WriteLine(CreateFromString(description));
            Console.WriteLine();
        }

        public static Mark[,] CreateFromString(string str)
        {
            var field = str.Split(' ');
            var ans = new Mark[3, 3];
            for (int x = 0; x < field.Length; x++)
            for (var y = 0; y < field.Length; y++)
                ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
            return ans;
        }

        //bool HasWinSequence(Mark[,] field, Mark mark)
        //{
        //    //определяющий есть ли выигрышная последовательность у mark.
        //    //Он позволит не дублировать логику для крестиков и ноликов.
        //}


        public static GameResult GetGameResult(Mark[,] field) //Mark[3,3]
        {
            for (int i = 0; i < field.GetLength(0); i++)
                for (int j = 0; j < field.GetLength(1); j++)
                    if (field[i, j] == Mark.Circle)
                        return GameResult.CircleWin;
                    else if (field[i, j] == Mark.Cross)
                        return GameResult.CrossWin;
                    else if (field[i, j] == Mark.Empty)
                        return GameResult.Draw;

            for (int k = 0; k < field.GetLength(1); k++)
                for (int l = 0; l < field.GetLength(0); l++)
                    if (field[k, l] == Mark.Circle)
                        return GameResult.CircleWin;
                    else if (field[k, l] == Mark.Cross)
                        return GameResult.CrossWin;
                    else if (field[k, l] == Mark.Empty)
                        return GameResult.Draw;

            return GameResult.Draw;
        }
        /*
         *  TicTacToe.Run("XXX OO. ..."); //CrossWin-CrossWin
            TicTacToe.Run("OXO XO. .XO"); //CircleWin-CircleWin
            TicTacToe.Run("OXO XOX OX."); //CircleWin-CircleWin
            TicTacToe.Run("XOX OXO OXO");       //CrossWin-Draw
            TicTacToe.Run("... ... ..."); //Draw-Draw
            TicTacToe.Run("XXX OOO ...");       //CrossWin-Draw
            TicTacToe.Run("XOO XOO XX."); //CrossWin-CrossWin
            TicTacToe.Run(".O. XO. XOX");       //Draw-CircleWin
         */
    }
}
