using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FGWCityInfo.API.Entities
{
    public class PointOfInterest
    {
        public PointOfInterest()
        {
        }

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [ForeignKey("CityId")]
        public City City
        {
            get;
            set;
        }

        public int CityId
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
