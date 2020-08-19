using GIWEB.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIWEB.Models
{
    public class Plots
    {
        public int Id { get; set; }
        public DateTime DatePlots { get; set; }
        public double PlotsValue { get; set; }
        public PlotsStatus Status { get; set; }

        public Plots()
        {
        }

        public Plots(DateTime datePlots, double plotsValue, PlotsStatus status)
        {
            DatePlots = datePlots;
            PlotsValue = plotsValue;
            Status = status;
        }
    }
}
