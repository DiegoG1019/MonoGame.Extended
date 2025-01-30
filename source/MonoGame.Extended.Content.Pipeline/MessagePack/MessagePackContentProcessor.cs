using System;
using System.ComponentModel;
using System.Net.Mime;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace MonoGame.Extended.Content.Pipeline.MessagePack;

[ContentProcessor(DisplayName = "MessagePack Processor - MonoGame.Extended")]
public class MessagePackContentProcessor : ContentProcessor<ContentImporterResult<byte[]>, MessagePackContentProcessorResult>
{
    [DefaultValue(typeof(Type), "System.Object")]
    public string ContentType { get; set; }

    public override MessagePackContentProcessorResult Process(ContentImporterResult<byte[]> input, ContentProcessorContext context)
    {
        try
        {
            var output = new MessagePackContentProcessorResult
            {
                ContentType = ContentType,
                Data = input.Data
            };
            return output;
        }
        catch (Exception ex)
        {
            context.Logger.LogMessage("Error {0}", ex);
            throw;
        }
    }
}
