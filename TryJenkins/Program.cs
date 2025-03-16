namespace TryJenkins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            foreach (Person person in data.GetPeople())
            {
                person.Print();
            }
        }
    }
}
