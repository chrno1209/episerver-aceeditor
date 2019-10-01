using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Javascript,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class JavascriptEditorDescriptor : AceEditorDescriptor
    {
    }
}