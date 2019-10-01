using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Scss,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class ScssEditorDescriptor : AceEditorDescriptor
    {
    }
}