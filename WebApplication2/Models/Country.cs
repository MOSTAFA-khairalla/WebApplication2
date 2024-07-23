// Models/Country.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Country
{
    [Key]
    public int CountryId { get; set; }

    [Required]
    [StringLength(100)]
    public string CountryName { get; set; }

    public ICollection<City> Cities { get; set; }
}


public class City
{
    [Key]
    public int CityId { get; set; }

    [Required]
    [StringLength(100)]
    public string CityName { get; set; }

    [ForeignKey("Country")]
    public int CountryId { get; set; }
    public Country Country { get; set; }
}
