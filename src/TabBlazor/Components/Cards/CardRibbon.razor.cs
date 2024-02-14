using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGageUI
{
    public enum RibbonPosition
    {
        Top,
        Right
    }

    public partial class CardRibbon : TablerBaseComponent
    {
        [Parameter] public RibbonPosition Position { get; set; } = RibbonPosition.Right;

        protected override string ClassNames => ClassBuilder
            .Add("ribbon")
            .Add(BackgroundColor.GetColorClass("bg"))
            .Add(TextColor.GetColorClass("text"))
            .AddCompare("ribbon-top", Position, RibbonPosition.Top)
            .AddCompare("ribbon-right", Position, RibbonPosition.Right)
            .ToString();
    }
}