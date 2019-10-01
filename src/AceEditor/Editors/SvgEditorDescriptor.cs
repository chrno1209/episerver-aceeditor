using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Svg,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class SvgEditorDescriptor : AceEditorDescriptor
    {
    }
}