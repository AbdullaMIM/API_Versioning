namespace API_Versioning.Models.DTOs
{
    public class CountryDtoV1
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }

    public class CountryDtoV2
    {
        public int Id { get; set; }
        public string CountryName { get; set; } = default!;
    }
}
