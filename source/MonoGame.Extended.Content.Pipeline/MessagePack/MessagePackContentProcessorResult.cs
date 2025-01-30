using System;

namespace MonoGame.Extended.Content.Pipeline.MessagePack;

public class MessagePackContentProcessorResult
{
    public string ContentType { get; set; }
    public byte[] Data { get; set; }
}
