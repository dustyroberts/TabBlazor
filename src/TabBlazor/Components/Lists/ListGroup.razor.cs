using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGageUI
{
    public partial class ListGroup : TablerBaseComponent
    {

        protected string HtmlTag => "div";
        protected override string ClassNames => ClassBuilder
                    .Add("list-group")
                    .Add("list-group-flush")
                    .ToString();
    }
}
