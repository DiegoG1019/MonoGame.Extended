using System;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

namespace MonoGame.Extended.Content.Pipeline.MessagePack;

[ContentTypeWriter]
public class MessagePackContentTypeWriter : ContentTypeWriter<MessagePackContentProcessorResult>
{
    private string _runtimeType;

    protected override void Write(ContentWriter writer, MessagePackContentProcessorResult result)
    {
        _runtimeType = result.ContentType;
        writer.Write(result.Data.Length);
        writer.Write(result.Data);
    }

    public override string GetRuntimeReader(TargetPlatform targetPlatform)
    {
        return _runtimeType;// "MonoGame.Extended.Serialization.SpriteFactoryContentTypeReader, MonoGame.Extended";
    }

    public override string GetRuntimeType(TargetPlatform targetPlatform)
    {
        return _runtimeType;// "MonoGame.Extended.Serialization.SpriteFactoryContentTypeReader, MonoGame.Extended";
    }
}
