﻿using System;
using System.Collections.Generic;
using ImGuiNET;
using UnityEngine;

namespace UBImGui
{
    [Serializable]
    public struct FontSettings
    {
        public UnityEngine.Object fontObject;
        [HideInInspector] 
        public string fontPath;

        public int sizeInPixels;
        public ScriptGlyphRanges glyphRanges;
        public Range[] customGlyphRanges;
            
        public unsafe List<ushort> BuildRanges()
        {
            var atlas = (ImFontAtlas*)0;
            var ranges = new List<ushort>();
            if ((glyphRanges & ScriptGlyphRanges.Default) != 0)
                AddRangePtr(ImGuiNative.ImFontAtlas_GetGlyphRangesDefault(atlas));
            if ((glyphRanges & ScriptGlyphRanges.Cyrillic) != 0)
                AddRangePtr(ImGuiNative.ImFontAtlas_GetGlyphRangesCyrillic(atlas));
            if ((glyphRanges & ScriptGlyphRanges.Japanese) != 0)
                AddRangePtr(ImGuiNative.ImFontAtlas_GetGlyphRangesJapanese(atlas));
            if ((glyphRanges & ScriptGlyphRanges.Korean) != 0)
                AddRangePtr(ImGuiNative.ImFontAtlas_GetGlyphRangesKorean(atlas));
            if ((glyphRanges & ScriptGlyphRanges.Thai) != 0)
                AddRangePtr(ImGuiNative.ImFontAtlas_GetGlyphRangesThai(atlas));
            if ((glyphRanges & ScriptGlyphRanges.Vietnamese) != 0)
                AddRangePtr(ImGuiNative.ImFontAtlas_GetGlyphRangesVietnamese(atlas));
            if ((glyphRanges & ScriptGlyphRanges.ChineseSimplified) != 0)
                AddRangePtr(ImGuiNative.ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(atlas));
            if ((glyphRanges & ScriptGlyphRanges.ChineseFull) != 0)
                AddRangePtr(ImGuiNative.ImFontAtlas_GetGlyphRangesChineseFull(atlas));
            if ((glyphRanges & ScriptGlyphRanges.Custom) != 0)
                foreach (var range in customGlyphRanges)
                    ranges.AddRange(new[] { range.start, range.end });
            
            return ranges;

            void AddRangePtr(ushort* r)
            {
                while (*r != 0) 
                    ranges.Add(*r++);
            };
        }

        [Flags]
        public enum ScriptGlyphRanges
        {
            Default           = 1 << 0,
            Cyrillic          = 1 << 1,
            Japanese          = 1 << 2,
            Korean            = 1 << 3,
            Thai              = 1 << 4,
            Vietnamese        = 1 << 5,
            ChineseSimplified = 1 << 6,
            ChineseFull       = 1 << 7,
            Custom            = 1 << 8,
        }

        [Serializable]
        public struct Range
        {
            public ushort start;
            public ushort end;
        }
    }
}