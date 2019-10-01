using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Csharp,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class CsharpEditorDescriptor : AceEditorDescriptor
    {
    }
}