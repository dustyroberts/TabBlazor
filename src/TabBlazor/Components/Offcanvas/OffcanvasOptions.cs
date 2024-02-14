using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGageUI
{
    public class OffcanvasOptions
    {
        public bool Backdrop { get; set; } = true;
        public OffcanvasPosition Position { get; set; }
    }
    public enum OffcanvasPosition
    {
        Start = 0,
        End = 1,
        Top = 2,
        Bottom = 3
    }
}
