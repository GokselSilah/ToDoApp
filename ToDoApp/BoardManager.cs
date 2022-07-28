using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class BoardManager
    {
        static List<Board> boards = new List<Board>() 
        {
            new Board() { BoardId=1, BoardType="TODO Line" },
            new Board() { BoardId=2, BoardType="IN PROGRESS Line" },
            new Board() { BoardId=3, BoardType="DONE Line" }
        };




    }
}
