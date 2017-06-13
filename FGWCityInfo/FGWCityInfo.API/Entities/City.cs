using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FGWCityInfo.API.Entities
{
    public class City
    {
        public City()
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
		[MaxLength(200)]
		public string Description
		{
			get;
			set;
		}

		public ICollection<PointOfInterest> PointOfInterest { get; set; }
		= new List<PointOfInterest>();
    }
}
