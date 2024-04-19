using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RetizaCoopPrelim.Entities;

public partial class ClientInfo
{
    public int Id { get; set; }

    [Required(ErrorMessage = "User Type is required")]
    public int? UserType { get; set; }

    [Required(ErrorMessage = "First Name is required")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "MiddleName is required")]
    public string MiddleName { get; set; }

     [Required(ErrorMessage = "Last Name is required")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Zipcode is required")]
     [Range(1000, 9999, ErrorMessage = "Zipcode must be a 4-digit number")]
    public int ZipCode { get; set; }

    [Required(ErrorMessage = "Birthdate is required")]
    public DateTime Birthdate { get; set; }

    [Required(ErrorMessage ="Age is required")]
    public int Age { get; set; }


    [Required(ErrorMessage = "Name of Father is required")]
    public string NameofFather { get; set; }
    
    [Required(ErrorMessage = "Name of Mother is required")]
    public string NameofMother { get; set; }

    public string Civilstatus { get; set; }

    [Required(ErrorMessage = "Religion is required")]
    public string Religion { get; set; }

    [Required(ErrorMessage = "Occupation is required")]
    public string Occupation { get; set; }
}
