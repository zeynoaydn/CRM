using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dtos
{
    public class CountriesDto : IDto
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<CountriesDto> Countrieses { get; set; }

    }
}
