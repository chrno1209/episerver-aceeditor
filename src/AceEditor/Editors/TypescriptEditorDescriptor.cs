using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Typescript,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class TypescriptEditorDescriptor : AceEditorDescriptor
    {
    }
}