using System;
using System.Collections.Generic;
using System.Text;

namespace ByMyPcDesktop.ConnectToApi.Models
{
    public class CpuModelGet
    {
        public Guid id { get; init; }
        public string Name { get; set; }  = string.Empty;
        public string Socket { get; set; } = string.Empty;
        public int Frequency { get; set; }
        public int Count_Cores { get; set; }
        public bool IsLive { get; set; }
    }

    public class CpuSmallModel
    {
        public string Name { get; set; } = string.Empty;
        public string Socket { get; set; } = string.Empty;
    }
}
