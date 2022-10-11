using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutyBusinessLayer.ViewModels
{
    internal interface IViewModel
    {
        public string Action { get; set; }
        public bool ReadOnly { get; set; }
        public string Theme { get; set; }
        public bool ShowAction { get; set; }
    }
}
