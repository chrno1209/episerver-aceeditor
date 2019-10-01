using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Coffee,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class CoffeeEditorDescriptor : AceEditorDescriptor
    {
    }
}