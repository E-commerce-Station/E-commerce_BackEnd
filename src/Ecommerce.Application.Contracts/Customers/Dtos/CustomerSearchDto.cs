namespace Ecommerce.Customers.Dtos
{
    public class CustomerSearchDto
    {
        public string Filter { get; set; }

        public int SkipCount { get; set; }

        public int MaxResultCount { get; set; }

        public string Sorting { get; set; }
    }
}
