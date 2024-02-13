class Program
{
    public class GenericsDemo<T>
    {
        public bool compare(T firstValue,T secondValue)
        {
            if(firstValue.Equals(secondValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public static void Main(string[] args)
    {
        GenericsDemo<int> genericsDemo = new GenericsDemo<int>();
        bool result = genericsDemo.compare(5,10);
        Console.WriteLine(result);   
    }
}