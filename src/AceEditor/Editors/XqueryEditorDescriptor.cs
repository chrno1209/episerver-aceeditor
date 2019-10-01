using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Xquery,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class XqueryEditorDescriptor : AceEditorDescriptor
    {
    }
}