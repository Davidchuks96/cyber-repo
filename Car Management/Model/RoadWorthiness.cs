﻿using Car_Management.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Car_Management.Enum.DStatus;

namespace Car_Management.Model
{
    public class RoadWorthiness
    {
        public DateTime IssuedDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DocumentStatus H_Status{ get; set; }

        public RoadWorthiness()
        {
            H_Status = DocumentStatus.Active;
        }
    }
}