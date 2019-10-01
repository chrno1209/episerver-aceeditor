using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Lucene,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class LuceneEditorDescriptor : AceEditorDescriptor
    {
    }
}