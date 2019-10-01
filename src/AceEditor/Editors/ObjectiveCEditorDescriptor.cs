using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.ObjectiveC,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class ObjectiveCEditorDescriptor : AceEditorDescriptor
    {
    }
}