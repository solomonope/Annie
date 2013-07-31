using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitworkSystem.Annie.BO
{
    public class BusinessDay
    {
        [Key]
        public Guid BusinessDayId
        {
            get;
            set;
        }

       
        public DateTime StartTime
        {
            get;
            set;
        }
        public DateTime EndTime
        {
            get;
            set;
        }
        public DateTime BusinessDayDate
        {
            get;
            set;
        }
        public override string ToString()
        {
            return String.Format("Type: BussinessDay|BusinessDayId:{0}|StartTime:{1}|EndTime:{2}|BusinessDayDate:{3}", this.BusinessDayId, this.StartTime, this.EndTime, this.BusinessDayDate);
        }
    }
}
