﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitworkSystem.Annie.BO
{
    public class TankVolumeLogg
    {
        [Key]
        public Guid TankVolumeLoggId
        {
            get;
            set;
        }
        
        public Guid TankId
        {
            get;
            set;
        }
        public Tank Tank
        {
            get;
            set;
        }
        public double Volume
        {
            get;
            set;
        }
        public double SellingRate
        {
            get;
            set;
        }
        public DateTime DateTimeOfLogg
        {
            get;
            set;
        }
    }
}
