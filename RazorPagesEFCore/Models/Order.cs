using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace assignment4.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public string? CustomerId { get; set; }

    public int? EmployeeId { get; set; }

    [Display(Name = "Ordered")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? OrderDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    [Display(Name = "Shipped")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? ShippedDate { get; set; }

    public int? ShipVia { get; set; }

    public decimal? Freight { get; set; }

    [Display(Name = "Ship Name")]
    public string? ShipName { get; set; }

    public string? ShipAddress { get; set; }

    public string? ShipCity { get; set; }

    [Display(Name = "Region")]
    public string? ShipRegion { get; set; }

    public string? ShipPostalCode { get; set; }

    [Display(Name = "Country")]
    public string? ShipCountry { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Shipper? ShipViaNavigation { get; set; }
}
