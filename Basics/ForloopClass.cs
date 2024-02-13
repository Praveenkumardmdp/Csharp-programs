namespace CSHARP
{
    public class ForloopClass
    {
        public void MatrixPrint(int Rows,int Columns)
        {
            int row;
            int column;
            for(row=1;row<=Rows;row++)
            {
                for(column=1;column<=Columns;column++)
                {
                    Console.Write(column+" ");
                }
                Console.Write("\n");
            }
        }
    }
}