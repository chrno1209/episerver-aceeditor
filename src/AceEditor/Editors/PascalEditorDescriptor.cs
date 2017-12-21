using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Pascal,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class PascalEditorDescriptor : AceEditorDescriptor
    {
    }
}