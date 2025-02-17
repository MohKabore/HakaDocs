

namespace API.Entities
{
    public class Customer : BaseEntity
    {
        public HaKaDocClient HaKaDocClient { get; set; }
        public int HaKaDocClientId { get; set; }
        public string IdNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public int UserTypeId { get; set; }
        // public UserType UserType { get; set; }
        public byte? Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string CountryCode { get; set; }
        public string CustomerCode { get; set; }
        public string SecondPhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime Created { get; set; } =DateTime.Now;
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        public int? DistrictId { get; set; }
        public District District { get; set; }
        public int? BirthCountryId { get; set; }
        public Country BirthCountry { get; set; }
        public int? BirthCityId { get; set; }
        public City BirthCity { get; set; }
        public int? BirthDistrictId { get; set; }
        public District BirthDistrict { get; set; }
        public int? MaritalStatusId { get; set; }
        public MaritalStatus MaritalSatus { get; set; }
        public byte TempData { get; set; }
        public Boolean Validated { get; set; }
        public string ToBeValidatedEmail { get; set; }
        public Boolean AccountDataValidated { get; set; } =false;    
        public string PostalBox { get; set; }
        public string NationalIDNum { get; set; }
        public int InsertUserId { get; set; }
         public string Cni { get; set; }
        public string Passport { get; set; }
        public string Iddoc { get; set; }
        public string Email { get; set; }
        public AppUser InsertUser { get; set; }
        public ICollection<Photo> Photos { get; set; }

    }
}