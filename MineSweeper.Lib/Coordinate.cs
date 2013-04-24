
namespace MineSweeper.Lib
{
   public class Coordinate
    {
       public int Line { get; private set; }
        public int Column { get; private set; }

       public Coordinate(int line, int column)
       {
           Line = line;
           Column = column;
       }
    }
}
