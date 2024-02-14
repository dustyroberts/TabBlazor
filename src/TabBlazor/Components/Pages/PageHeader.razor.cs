namespace NGageUI
{
    public partial class PageHeader : TablerBaseComponent
    {
        [Parameter] public string Title { get; set; }
        [Parameter] public string PreTitle { get; set; }

        protected override string ClassNames => ClassBuilder
            .Add("page-header d-print-none")
            .ToString();
    }
}