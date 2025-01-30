using System.Buffers;
using System.Text.Json;
using MessagePack;
using Microsoft.Xna.Framework.Content;

namespace MonoGame.Extended.Content.ContentReaders;

public class MessagePackContentTypeReader<T> : ContentTypeReader<T>
{
    protected override T Read(ContentReader reader, T existingInstance)
    {
        var len = reader.ReadInt32();
        var rental = ArrayPool<byte>.Shared.Rent(len);
        try
        {
            reader.Read(rental, 0, len);
            return MessagePackSerializer.Deserialize<T>(rental);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(rental);
        }
    }
}
