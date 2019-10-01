using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Ruby,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class RubyEditorDescriptor : AceEditorDescriptor
    {
    }
}