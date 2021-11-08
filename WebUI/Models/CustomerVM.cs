﻿using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class CustomerVM
    {
        public CustomerVM()
        {

        }
        public CustomerVM(Customer p_customer)
        {
            this.CustomerId = p_customer.CustomerId;
            this.Name = p_customer.Name;
            this.Email= p_customer.Email;
            this.Address = p_customer.Address;
            this.PhoneNumber = p_customer.PhoneNumber;
        }


        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

    }
}
