using System;
using System.Collections.Generic;
using System.Text;

namespace oop_eksamensopgave
{
    class SeasonalProduct : Product
    {
        bool _InActiveSeason;
        public bool InActiveSeason
        {
            get { return _InActiveSeason; }
            set
            {
                try
                {
                    _InActiveSeason = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        DateTime _SeasonStartDate;
        public DateTime SeasonStartDate
        {
            get { return _SeasonStartDate; }
            set
            {
                try
                {
                    _SeasonStartDate = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        DateTime _SeasonEndDate;
        public DateTime SeasonEndDate
        {
            get { return _SeasonEndDate; }
            set
            {
                try
                {
                    _SeasonEndDate = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public SeasonalProduct(int id, string name, decimal price, bool active, bool canbeboughtoncredit, bool inactiveseason, DateTime seasonstartdate, DateTime seasonenddate) : base(id, name, price, active, canbeboughtoncredit)
        {
            this.InActiveSeason = inactiveseason;
            this.SeasonStartDate = seasonstartdate;
            this.SeasonEndDate = seasonenddate;
        }
    }
}
