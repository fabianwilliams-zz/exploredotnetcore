using System;
using System.ComponentModel.DataAnnotations;

namespace FGWCityInfo.API.Models
{
    public class PointOfInterestDto
    {
        public PointOfInterestDto()
        {
        }

        public int Id
        {
            get;
            set;
        }
        [Required(ErrorMessage = "You need to provide a valid Name value in your call")]
        [MaxLength(50)]
        public string Name
        {
            get;
            set;
        }

        [MaxLength(200)]
        public string Description
        {
            get;
            set;
        }
    }
}
