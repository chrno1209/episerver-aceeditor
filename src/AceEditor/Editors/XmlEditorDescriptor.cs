using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Xml,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class XmlEditorDescriptor : AceEditorDescriptor
    {
    }
}