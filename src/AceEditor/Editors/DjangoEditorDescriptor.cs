using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Django,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class DjangoEditorDescriptor : AceEditorDescriptor
    {
    }
}