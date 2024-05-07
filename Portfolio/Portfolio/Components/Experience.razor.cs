using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    /// <summary>
    /// Component for displaying any kind of "Experience" on the portfolio page. Provides a simple
    /// layout for the experience, with the majority of the content being provided as a child content
    /// render fragment. 
    /// </summary>
    public partial class Experience
    {
        /// <summary>
        /// Experience title.
        /// </summary>
        [Parameter] public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Location where the experience happened. Will not be rendered if empty.
        /// </summary>
        [Parameter] public string Location { get; set; } = string.Empty;

        /// <summary>
        /// Time span during which the experience occurred. Will not be rendered if empty. 
        /// </summary>
        [Parameter] public string When { get; set; } = string.Empty;

        /// <summary>
        /// Image to display to left of experience. Only displays on medium and up breakpoints.
        /// The image should ideally be square for best viewing. 
        /// </summary>
        [Parameter] public string? ImageSource { get; set; } = null;

        /// <summary>
        /// Hyperlink that will be followed when clicking on the image. 
        /// </summary>
        [Parameter] public string? ImageLink { get; set; } = null;

        /// <summary>
        /// HTML anchor element name. Can be used to allow for quick navigation within a page. 
        /// </summary>
        [Parameter] public string AnchorName { get; set; } = string.Empty;

        /// <summary>
        /// Freeform content to render within the experience component. 
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; } = default!;
    }
}
