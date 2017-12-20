using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EPiServer.Plugins.Editors.AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Rhtml,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class RhtmlEditorDescriptor : AceEditorDescriptor
    {
    }
}