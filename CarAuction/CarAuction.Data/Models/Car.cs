﻿using System;
using System.Collections.Generic;

namespace CarAuction.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public int Odometer { get; set; }
        public DateTime Year { get; set; }
        public string ExteriorColor { get; set; }
        public string InteriorColor { get; set; }
        public bool StrongScratches { get; set; }
        public bool SmallScratches { get; set; }
        public bool SuspensionProblems { get; set; }
        public bool ElectricsFailures { get; set; }
        short? Grade { get; set; }
        public List<Bid> Bids { get; set; }
        public List<AuctionCar> Assignments { get; set; }
    }
}