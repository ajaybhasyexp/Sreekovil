using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.ViewModels
{
    public class OfferingTransactionVM
    {
        [Browsable(false)]
        public int OfferingId { get; set; }

        [Browsable(false)]
        public int Index { get; set; }

        public string Name { get; set; }

        [Browsable(false)]
        public int? StarSignId { get; set; }

        public string OfferingName { get; set; }

        public string StarSignName { get; set; }

        public decimal Price { get; set; }
    }
}
