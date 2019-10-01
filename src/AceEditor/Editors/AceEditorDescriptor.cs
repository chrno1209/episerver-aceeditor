using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using System;
using System.Collections.Generic;

namespace AceEditor.Editors
{
    public class AceEditorDescriptor: EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            base.ModifyMetadata(metadata, attributes);

            metadata.EditorConfiguration.Add("aceEditorMode", metadata.UIHint.Replace("AceEditor_", ""));

            metadata.ClientEditingClass = "aceeditor/aceEditor";
        }
    }
}