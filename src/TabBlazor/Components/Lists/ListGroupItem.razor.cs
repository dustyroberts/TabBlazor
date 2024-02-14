using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGageUI
{
    public partial class ListGroupItem : TablerBaseComponent
    {

        protected string HtmlTag => "div";
        protected override string ClassNames => ClassBuilder
            .Add("list-group-item")
            .Add("cursor-pointer")
            .ToString();
    }
}
