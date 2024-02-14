using Microsoft.AspNetCore.Components;

namespace NGageUI.Components
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
