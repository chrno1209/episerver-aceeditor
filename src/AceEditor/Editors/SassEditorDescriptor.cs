using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Sass,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class SassEditorDescriptor : AceEditorDescriptor
    {
    }
}