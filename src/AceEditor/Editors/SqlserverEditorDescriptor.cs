using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Sqlserver,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class SqlserverEditorDescriptor : AceEditorDescriptor
    {
    }
}