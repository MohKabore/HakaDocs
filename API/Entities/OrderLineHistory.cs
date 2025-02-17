namespace API.Entities
{
    public class OrderLineHistory
    {
        public OrderLineHistory()
    {
      Cashed = false;
      Rejected = false;
      InsertDate = DateTime.Now;
      InsertUserId = 1;
      UpdateDate = DateTime.Now;
      UpdateUserId = 1;
    }
    public int Id { get; set; }
    public int OrderLineId { get; set; }
    public OrderLine OrderLine { get; set; }
    public int? FinOpId { get; set; }
    public FinOp FinOp { get; set; }
    public int UserId { get; set; }
    public AppUser User { get; set; }
    public DateTime OpDate { get; set; }
    public string Action { get; set; }
    public decimal OldAmount { get; set; }
    public decimal NewAmount { get; set; }
    public decimal Delta { get; set; }
    public Boolean Cashed { get; set; }
    public Boolean Rejected { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public AppUser InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public AppUser UpdateUser { get; set; }
    }
}