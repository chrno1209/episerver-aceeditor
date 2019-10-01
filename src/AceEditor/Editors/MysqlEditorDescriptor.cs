using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Mysql,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class MysqlEditorDescriptor : AceEditorDescriptor
    {
    }
}