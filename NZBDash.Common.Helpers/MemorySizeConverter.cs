﻿#region Copyright
//  ***********************************************************************
//  Copyright (c) 2016 Jamie Rees
//  File: MemorySizeConverter.cs
//  Created By: Jamie Rees
// 
//  Permission is hereby granted, free of charge, to any person obtaining
//  a copy of this software and associated documentation files (the
//  "Software"), to deal in the Software without restriction, including
//  without limitation the rights to use, copy, modify, merge, publish,
//  distribute, sublicense, and/or sell copies of the Software, and to
//  permit persons to whom the Software is furnished to do so, subject to
//  the following conditions:
// 
//  The above copyright notice and this permission notice shall be
//  included in all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//  EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//  MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
//  LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
//  OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
//  WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//  ***********************************************************************
#endregion
using System;

using ByteSizeLib;

using Humanizer;

namespace NZBDash.Common.Helpers
{
    public class MemorySizeConverter
    {
        public static string SizeSuffix(long value)
        {
            var result = value.Kilobytes();

            return string.Format("{0} {1}", Math.Round(result.LargestWholeNumberValue, 1), result.LargestWholeNumberSymbol);
        }

        public static string SizeSuffixTime(long value)
        {
            var result = value.Kilobytes();

            return result.Per(TimeSpan.FromSeconds(1)).Humanize("#.#");
        }

        public static string SizeSuffixMb(long value)
        {
            var bytes = value.Megabytes();

            return string.Format("{0} {1}", Math.Round(bytes.LargestWholeNumberValue, 1), bytes.LargestWholeNumberSymbol);
        }


        public static string SizeSuffixMb(double value)
        {
            var bytes = value.Megabytes();

            return string.Format("{0} {1}", Math.Round(bytes.LargestWholeNumberValue, 1), bytes.LargestWholeNumberSymbol);
        }

        public static double ConvertToMb(string text)
        {
            ByteSize outPut;
            ByteSize.TryParse(text, out outPut);

            return outPut.MegaBytes;
        }
    }
}