using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Text,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class TextEditorDescriptor : AceEditorDescriptor
    {
    }
}