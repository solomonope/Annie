using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BitworkSystem.Annie.BO;

namespace BitworkSystem.Annie.DAL
{
    public class AnnieDataContext :DbContext
    {
        public DbSet<BusinessDay> BusinessDays { get; set; }
        public DbSet<BusinessDayReport> BusinessDayReports { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Fluid> Fluids { get; set; }
        public DbSet<Pump> Pumps { get; set; }
        public DbSet<PumpReading> PumpReadings { get; set; }
        public DbSet<PumpSale> PumpSales { get; set; }
        public DbSet<SalesRate> SalesRates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Tank> Tanks { get; set; }
        public DbSet<TankActivity> TankActivities { get; set; }
        public DbSet<TankReading> TankReadings { get; set; }
        public DbSet<TankVolumeLogg> TankVolumeLoggs { get; set; }

        


    }
}
