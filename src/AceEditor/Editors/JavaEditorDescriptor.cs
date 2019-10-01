using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Java,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class JavaEditorDescriptor : AceEditorDescriptor
    {
    }
}