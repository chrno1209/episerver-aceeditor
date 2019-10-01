using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Powershell,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class PowershellEditorDescriptor : AceEditorDescriptor
    {
    }
}