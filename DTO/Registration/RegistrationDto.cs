﻿
using DataAccessLayer.Models;
using ServiceManagement.DTO.Workshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceManagement.DTO.Registration
{
    public class RegistrationDto
    {
        public int ID { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime DateOfRepair { get; set; }
        public WorkshopDto Workshop { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
