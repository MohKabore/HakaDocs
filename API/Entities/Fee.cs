namespace API.Entities
{
    public class Fee
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public double amount { get; set; }
         public HaKaDocClient HaKaDocClient { get; set; }
        public int HaKaDocClientId { get; set; }
    }
}