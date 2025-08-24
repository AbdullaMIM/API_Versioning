using API_Versioning.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.V2.Controllers
{
    [Route("api/v2/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCountriesV2()
        {
            var countriesDomainModel = CountriesData.Get();

            //Map Domain Model to DTO
            var countryDtos = new List<CountryDtoV2>();
            foreach (var countryDomainModel in countriesDomainModel)
            {
                countryDtos.Add(new CountryDtoV2
                {
                    Id = countryDomainModel.Id,
                    CountryName = countryDomainModel.Name
                });
            }

            return Ok(countryDtos);
        }
    }
}
