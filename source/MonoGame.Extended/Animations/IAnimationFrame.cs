// Copyright (c) Craftwork Games. All rights reserved.
// Licensed under the MIT license.
// See LICENSE file in the project root for full license information.

using System;

namespace MonoGame.Extended.Animations;

/// <summary>
/// Defines the interface for an animation frame, specifying the frame index and its duration.
/// </summary>
public interface IAnimationFrame
{
    /// <summary>
    /// Gets the frame index represented by this animation frame.
    /// </summary>
    int FrameIndex { get; }

    /// <summary>
    /// Gets the total duration this frame should be displayed during an animation.
    /// </summary>
    TimeSpan Duration { get; }

    /// <summary>
    /// A function that takes the current frame index and transforms it -- For special-case use. Warning: Be careful with index overflows!
    /// </summary>
    public Func<int, int>? FrameIndexTransformer { get; }
}
