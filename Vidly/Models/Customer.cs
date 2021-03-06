﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {

        public int Id { get; set; }


        [Required]
        public string Name { get; set; }

        [Display(Name = "Subscribe to News Letter")]
        public bool SubscribeToNewsLetter { get; set; }

        [Display(Name="Membership Type")]
        public MembershipType MembershipType { get; set; }


        public byte MembershipTypeId { get; set; }

        [Display(Name="Date Of Birth")]
        public DateTime BirthDate { get; set; }



    }
}