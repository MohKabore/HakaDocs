namespace API.Entities
{
    public class Order
    {
         public Order()
    {
      OrderDate = DateTime.Now;
      TotalHT = 0;
      DiscountAmount = 0;
      AmountHT = 0;
      AmountTTC = 0;
      TVA = 0;
      TVAAmount = 0;
      // isReg = false;
      // isNextReg = false;
      Validated = false;
      Expired = false;
      Cancelled = false;
      Overdue = false;
      Paid = false;
      Completed = false;
      InsertDate = DateTime.Now;
      UpdateDate = DateTime.Now;
    }

    public int Id { get; set; }
    public int OrderTypeId { get; set; }
    public OrderType OrderType { get; set; }
    public int OrderNum { get; set; }
    public string OrderLabel { get; set; }
  
    public DateTime OrderDate { get; set; }
    // public DateTime Deadline { get; set; }
    // public DateTime Validity { get; set; }
    public int? ShippingAddressId { get; set; }
    public Address ShippingAddress { get; set; }
    public int? BillingAddressId { get; set; }
    public Address BillingAddress { get; set; }
    public decimal TotalHT { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal AmountHT { get; set; }
    public decimal TVA { get; set; }
    public decimal TVAAmount { get; set; }
    public decimal AmountTTC { get; set; }
    public decimal AmountPaid { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    // public int? FatherId { get; set; }
    // public AppUser Father { get; set; }
    // public int? MotherId { get; set; }
    // public AppUser Mother { get; set; }
    public Boolean Validated { get; set; }
    public Boolean Expired { get; set; }
    public Boolean Cancelled { get; set; }
    public Boolean Overdue { get; set; }//payé plus la valeur attendue
    public Boolean Paid { get; set; }
    public Boolean FullyPaid { get; set; }
    public Boolean Delivered { get; set; }
    public Boolean Completed { get; set; }
    // public Boolean isReg { get; set; }
    // public Boolean isNextReg { get; set; }
    public DateTime InsertDate { get; set; } = DateTime.Now;
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; } = DateTime.Now;
    public int UpdateUserId { get; set; }

    public Boolean StockChecked { get; set; } 
    
    }
}