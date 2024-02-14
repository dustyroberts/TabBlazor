using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGageUI
{
   public class ToastOptions
    {
        /// <summary>
        /// Delay in Seconds
        /// Set 0 to show it until manually removed
        /// </summary>
        public int Delay { get; set; } = 3;
        public bool ShowHeader { get; set; } = true;
        public bool ShowProgress { get; set; } = true;
        public bool AutoClose => Delay > 0;
        
        public bool AddStatusIcon { get; set; }

        // applies to ShowHeader and AddStatusIcon and progress bar
        public string StatusColor { get; set; } // Add a property for progress color (css color-class)

        public int InitialProgressValue { get; set; }
    }
}
