using System;
using System.IO;
using MessagePack;
using Microsoft.Xna.Framework.Content.Pipeline;
using MonoGame.Extended.Content.ContentReaders;

namespace MonoGame.Extended.Content.Pipeline.MessagePack;

[ContentImporter(".msgpack", DefaultProcessor = nameof(MessagePackContentProcessor), DisplayName = "MessagePack Importer - MonoGame.Extended")]
public class MessagePackContentImporter : ContentImporter<ContentImporterResult<byte[]>>
{
    public override ContentImporterResult<byte[]> Import(string filename, ContentImporterContext context)
    {
        using var file = File.OpenRead(filename);
        byte[] dat = new byte[file.Length];
        file.Read(dat, 0, dat.Length);
        
        return new ContentImporterResult<byte[]>(filename, dat);
    }
}
