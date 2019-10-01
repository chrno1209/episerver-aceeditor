using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Jsp,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class JspEditorDescriptor : AceEditorDescriptor
    {
    }
}