using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace ViewAsMd
{
    internal sealed class FileAndContentTypeDefinitions
    {
        [Export]
        [Name("markdown")]
        [BaseDefinition("text")]
        internal static ContentTypeDefinition markdownContentTypeDefinition;

        [Export]
        [FileExtension(".md")]
        [ContentType("markdown")]
        internal static FileExtensionToContentTypeDefinition markdownFileExtensionDefinition;
    }
}
