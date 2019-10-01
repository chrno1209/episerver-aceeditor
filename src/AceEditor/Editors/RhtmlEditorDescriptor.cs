using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Rhtml,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class RhtmlEditorDescriptor : AceEditorDescriptor
    {
    }
}