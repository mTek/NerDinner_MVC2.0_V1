using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace NerdDinner.Models
{
    [MetadataType(typeof(Dinner_Validation))]
    public partial class Dinner
    {
    }
    public class Dinner_Validation
    {
        [Required(ErrorMessage="Title is required.")]
        [StringLength(50,ErrorMessage="Only 50 characters allowed in Title")]
        public string Title{get; set;}
    }
}