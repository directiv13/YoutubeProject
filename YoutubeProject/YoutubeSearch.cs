using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace YoutubeProject
{
    class YoutubeSearch
    {
        readonly string thumbnailPattern = @"(\s*\W)videoRenderer(\W):\s*{(\W)videoId(\W):(\W)(\S*)(\W),(\s*\W)thumbnail(\W):\s*{(\W)thumbnails(\W\s*):\s*\[{(\W)url(\W):(\s*\W)(?<URL>\S*)(\W),(\s*\W)width(\W):\d*,(\s*\W)height(\W):\d*}";
        readonly string videoPattern = @"{\u0022url\u0022:\u0022\/watch\?v=(?<VIDEO>\S*)\u0022,\u0022webPageType\u0022:\u0022WEB_PAGE_TYPE_WATCH\u0022,\u0022rootVe\u0022:3832}}";
        readonly string titlePattern = @"\u0022title\u0022:\W*{\u0022runs\u0022:\W*\[{\u0022text\u0022:\W*\u0022(?<TITLE>.+?(?=(\u0022}\],)))";

    }
}
