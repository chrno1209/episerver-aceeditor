using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Lua,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class LuaEditorDescriptor : AceEditorDescriptor
    {
    }
}