﻿using System;

namespace WebApi.DataModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }

        //navigation prop   
        public Guid StudentId { get; set; }
    }
}