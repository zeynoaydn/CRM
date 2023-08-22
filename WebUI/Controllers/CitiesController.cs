using AutoMapper;
using Business.Abstract;
using Business.Dtos;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebUI.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ILogger<CitiesController> _logger;
        private readonly ICitiesService _citiesService;
        private readonly IMapper _mapper;
        private readonly ICitiesDal _citiesDal;

        public CitiesController(ILogger<CitiesController> logger, ICitiesService citiesService, IMapper mapper,ICitiesDal citiesDal)
        {
            _logger = logger;
            _citiesService = citiesService;
            _mapper = mapper;
            _citiesDal = citiesDal;
        }
        public IActionResult Index()
        {
            var result=_citiesService.GetAll();
            var citiesDtos = _mapper.Map<List<CitiesDto>>(result.Data);
            return View(citiesDtos);
        }

        [HttpPost]
        public List<CitiesDto> GetCities()
        {
            var result = _citiesService.GetAll();
            var citiesDtos = _mapper.Map<List<CitiesDto>>(result.Data);
            return citiesDtos;
        }

        [HttpPost]
        public IDataResult<CitiesDto> GetById(int cityId)
        {
            var result = _citiesService.GetById(cityId);
            var cityDtos = _mapper.Map<CitiesDto>(result.Data);
            if (cityDtos != null)
            {
                return new SuccessDataResult<CitiesDto>(cityDtos);
            }
            return new ErrorDataResult<CitiesDto>(cityDtos, "Veri Bulunamadı!");
        }

        [HttpPost]
        public IDataResult<CitiesDto> Add(CitiesDto citiesDto)
        {
            CitiesDto addCity = new CitiesDto()
            {
                CountryId = citiesDto.CountryId,
                CityName = citiesDto.CityName,
                CreatedDate = DateTime.Now,
                CreatedUserId = 1,
                IsActive = true,
                IsDeleted = false,
            };
            var citiesDtos = _mapper.Map<Cities>(addCity);

            var result = _citiesService.Add(citiesDtos);
            if (result.Success)
            {
                return new SuccessDataResult<CitiesDto>(result.Message);
            }
            return new ErrorDataResult<CitiesDto>(result.Message);
        }

        [HttpPost]
        public IDataResult<CitiesDto> Delete(Cities cities)
        {
            var result = _citiesService.Delete(cities);
            if (result.Success)
            {
                return new SuccessDataResult<CitiesDto>(result.Message);
            }
            return new ErrorDataResult<CitiesDto>(result.Message);

        }

        [HttpPost]
        public IDataResult<CitiesDto> Update(CitiesDto citiesDto)
        {
            var result = new Cities()
            {
                Id= citiesDto.Id,
                CountryId = citiesDto.CountryId,
                CityName = citiesDto.CityName,
                CreatedDate = DateTime.Now,
                CreatedUserId = 1,
                IsActive = true,
                IsDeleted = false,
            };

            var deneme = _citiesService.Update(result);
            if (deneme.Success)
            {
                return new SuccessDataResult<CitiesDto>(deneme.Message);
            }
            return new ErrorDataResult<CitiesDto>(deneme.Message);
        }

    }
}
