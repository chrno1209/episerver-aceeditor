using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Php,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class PhpEditorDescriptor : AceEditorDescriptor
    {
    }
}