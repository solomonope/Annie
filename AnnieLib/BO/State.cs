using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitworkSystem.Annie.BO
{
    public class State
    {
       
        [Key]
        public Guid StateId
        {
            get;
            set;
        }
        public string StateName
        {
            get;
            set;
        }
        public Guid CountryId
        {
            get;
            set;
        }
        public Country Country
        {

            get;
            set;
        }

        public ICollection<City> Cities { get; set; }
    }
}