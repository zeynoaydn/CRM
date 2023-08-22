using AutoMapper;
using Business.Abstract;
using Business.Dtos;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace WebUI.Controllers
{
    public class CountriesController:Controller
    {
        private readonly ILogger<CountriesController> _logger;
        private readonly ICountriesService _countriesService;
        private readonly IMapper _mapper;

        public CountriesController(ILogger<CountriesController> logger, ICountriesService countriesService,IMapper mapper)
        {
            _logger = logger;
            _countriesService = countriesService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var result=_countriesService.GetAll();
            var countriesDtos = _mapper.Map<List<CountriesDto>>(result.Data);
            return View(countriesDtos);
        }

        [HttpPost]
        public List<CountriesDto> GetCountries()
        {
            var result = _countriesService.GetAll();
            var countriesDtos = _mapper.Map<List<CountriesDto>>(result.Data);
            return countriesDtos;
        }

        [HttpPost]
        public IDataResult<CountriesDto> GetById(int countryId)
        {
            var result = _countriesService.GetById(countryId);
            var countryDtos = _mapper.Map<CountriesDto>(result.Data);
            if (countryDtos != null)
            {
                return new SuccessDataResult<CountriesDto>(countryDtos);
            }
            return new ErrorDataResult<CountriesDto>(countryDtos, "Veri Bulunamadı!");
        }

        [HttpPost]
        public IDataResult<CountriesDto> Add(CountriesDto countriesDto)
        {
            CountriesDto addCountries = new CountriesDto()
            {
                CountryName = countriesDto.CountryName,
                CreatedDate = DateTime.Now,
                CreatedUserId = 1,
                IsActive = true,
                IsDeleted = false,
            };
            var countriesDtos = _mapper.Map<Countries>(addCountries);

            var result = _countriesService.Add(countriesDtos);
            if (result.Success)
            {
                return new SuccessDataResult<CountriesDto>(result.Message);
            }
            return new ErrorDataResult<CountriesDto>(result.Message);
        }

        [HttpPost]
        public IDataResult<CountriesDto> Delete(Countries countries)
        {
            var result = _countriesService.Delete(countries);
            if (result.Success)
            {
                return new SuccessDataResult<CountriesDto>(result.Message);
            }
            return new ErrorDataResult<CountriesDto>(result.Message);

        }

        [HttpPost]
        public IDataResult<CountriesDto> Update(CountriesDto countriesDto)
        {
            var result = new Countries()
            {
                Id = countriesDto.Id,
                CountryName = countriesDto.CountryName,
                CreatedDate = DateTime.Now,
                CreatedUserId = 1,
                IsActive = true,
                IsDeleted = false,
            };

            var deneme = _countriesService.Update(result);
            if (deneme.Success)
            {
                return new SuccessDataResult<CountriesDto>(deneme.Message);
            }
            return new ErrorDataResult<CountriesDto>(deneme.Message);
        }

    }
}
