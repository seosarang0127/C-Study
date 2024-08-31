namespace 클래스_상속
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("클래스 상속");

            Player player = new Player();

            Suits parent = new SpiderMan();
            parent.Equip();
        }
    }
}