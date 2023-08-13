using System;

using R5T.T0143;


namespace R5T.T0223
{
    /// <summary>
    /// Attribute indicating a type is a Razor link.
    /// It's usually pretty clear that something is a Razor link, but the marker attribute is useful for surveying assemblies and code, then building a catalogue of Razor links.
    /// </summary>
    [AttributeUsage(
        // Only class, since Razor components are only classes.
        AttributeTargets.Class,
        AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class RazorLinkMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a type is *not* a Razor link type.
        /// This is useful for marking types that end up canonical Razor link code file locations, but are not actually Razor links.
        /// </summary>
        public bool IsRazorLink { get; }


        public RazorLinkMarkerAttribute(
            bool isRazorLink = true)
        {
            this.IsRazorLink = isRazorLink;
        }
    }
}
