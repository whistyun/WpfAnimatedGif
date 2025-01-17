﻿// Copyright (c) 2013 Amemiya
// Licensed under the MIT License.
// Ported from: https://github.com/xupefei/APNG.NET

using System.IO;

namespace AnimatedImage.Formats.Png.Chunks
{
    /// <summary>
    /// The last chunk
    /// </summary>
    internal class IENDChunk
    {
        public const string ChunkType = "IEND";

        internal IENDChunk(ChunkStream cs)
        {
            cs.ReadCrc();
        }

    }
}