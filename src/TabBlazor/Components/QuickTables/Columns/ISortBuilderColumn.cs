namespace NGageUI.Components.QuickTables;

public interface ISortBuilderColumn<TGridItem>
{
    public GridSort<TGridItem> SortBuilder { get; }
}