namespace WerkenMetData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  MyDbContent context = new MyDbContent();
            using (var context = new MyDbContent())
            {
               // if(context.Klanten.Any())
                context.InitiateDatabase();
            }
        }
    }
}