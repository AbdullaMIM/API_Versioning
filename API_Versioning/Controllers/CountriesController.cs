using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Versioning.Models.DTOs;

namespace API_Versioning.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class CountriesController : ControllerBase
    {
        [MapToApiVersion("1.0")]
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


        [MapToApiVersion("2.0")]
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
