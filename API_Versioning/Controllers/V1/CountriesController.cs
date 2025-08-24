using API_Versioning.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCountriesV1()
        {
            var countriesDomainModel = CountriesData.Get();

            //Map Domain Model to DTO
            var countryDtos = new List<CountryDtoV1>();
            foreach (var countryDomainModel in countriesDomainModel)
            {
                countryDtos.Add(new CountryDtoV1
                {
                    Id = countryDomainModel.Id,
                    Name = countryDomainModel.Name
                });
            }

            return Ok(countryDtos);
        }
    }
}
