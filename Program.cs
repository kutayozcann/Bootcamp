namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rahmi Kutay Ozcan");
            Console.WriteLine("Patika'nin katılımcılarına sagladigi genis kapsamlı egitim programi ile universitede aldigim yazilim muhendisligi bilgilerimi harmanlayip sektore guclu bir giris yapmak.");
        
            string input = "42.5";
            double result = 0;

            double.TryParse(input, out result);

            Console.WriteLine(result);
        
        
        }
    }
}
