using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    /// <summary>
    /// Component defines a section of the page with a title and an optional lower divider.
    /// Content is provided as a child content render fragment. 
    /// </summary>
    public partial class PageSection
    {
        /// <summary>
        /// Section title. 
        /// </summary>
        [Parameter] public string Title { get; set; } = string.Empty;
        
        /// <summary>
        /// Choose whether to show a divider at the bottom of the page section. 
        /// </summary>
        [Parameter] public bool ShowDivider { get; set; } = true;

        /// <summary>
        /// HTML anchor element name. Can be used to allow for quick navigation within a page. 
        /// </summary>
        [Parameter] public string AnchorName { get; set; } = string.Empty;

        /// <summary>
        /// Freeform content to render within the page section. 
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; } = default!;
    }
}
