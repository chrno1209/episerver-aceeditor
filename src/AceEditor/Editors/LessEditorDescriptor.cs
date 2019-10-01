using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Less,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class LessEditorDescriptor : AceEditorDescriptor
    {
    }
}