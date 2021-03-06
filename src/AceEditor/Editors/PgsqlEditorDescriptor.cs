﻿using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Pgsql,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class PgsqlEditorDescriptor : AceEditorDescriptor
    {
    }
}