using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Perl,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class PerlEditorDescriptor : AceEditorDescriptor
    {
    }
}