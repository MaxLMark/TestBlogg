using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiBloggMax.Models.Media
{
    [ContentType]
    public class GenericFile : MediaData
    {
        public virtual string Description { get; set; }
    }

    [ContentType]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,gif,bmp,png")]
    public class ImageFile : ImageData
    {
        public virtual string AlternativeText { get; set; }
    }

    [ContentType]
    [MediaDescriptor(ExtensionString = "pdf,doc,docx")]
    public class DocumentFile : MediaData
    {
        public virtual string AlternativeText { get; set; }
    }
}