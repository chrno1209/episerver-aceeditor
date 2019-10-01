using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Swift,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class SwiftEditorDescriptor : AceEditorDescriptor
    {
    }
}