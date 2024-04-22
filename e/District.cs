namespace Normirovanie
{
    public class District
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public District()
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }
}