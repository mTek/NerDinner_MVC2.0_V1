﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace NerdDinner.Models
{
    [MetadataType(typeof(Dinner_Validation))]
    [Bind(Include = "Title,Description,EventDate,Address,Country,ContactPhone,Latitude,Longitude")]
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