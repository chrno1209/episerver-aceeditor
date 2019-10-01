using EPiServer.Core;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Html,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    [EditorDescriptorRegistration(
        TargetType = typeof(XhtmlString),
        UIHint = UIHints.Html,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class HtmlEditorDescriptor : AceEditorDescriptor
    {
    }
}