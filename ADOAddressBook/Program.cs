namespace ADOAddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose option ");
            Console.WriteLine("1.insert contact");
            Console.WriteLine("2.Update contact");
            Console.WriteLine("3.Delete Contact");
            Console.WriteLine("4.Retriew contact");
            int option = Convert.ToInt32(Console.ReadLine());
            BookData data = new BookData();
            DeleteContactPersonName delete = new DeleteContactPersonName();
            
            UpdateContactName update = new UpdateContactName();
            RetriveContactCityAndState retrive = new RetriveContactCityAndState();
          


        }
    }
}