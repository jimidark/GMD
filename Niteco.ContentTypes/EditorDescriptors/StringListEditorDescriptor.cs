using System;
using System.Collections.Generic;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using Niteco.Common.Consts;

namespace Niteco.ContentTypes.EditorDescriptors
{
    /// <summary>
    /// Register an editor for StringList properties
    /// </summary>
    [EditorDescriptorRegistration(TargetType = typeof(String[]), UIHint = SiteUIHints.Strings)]
    public class StringListEditorDescriptor : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            ClientEditingClass = "niteco/editors/StringList";

            base.ModifyMetadata(metadata, attributes);
        }
    }
}
