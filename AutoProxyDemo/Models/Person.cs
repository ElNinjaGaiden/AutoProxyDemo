namespace AutoProxyDemo.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        public string Name { get; set; }

        public Sex Sex { get; set; }

        public string Comment { get; set; }
    }

    public enum Sex
    {
        Male = 1,
        Female = 2
    }
}