using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace FFmpeg.AutoGen.Tests
{
    [TestFixture]
    public class BasicTests
    {
        /// <summary>
        /// version.h
        /// #define LIBAVCODEC_VERSION_MAJOR  58
        /// #define LIBAVCODEC_VERSION_MINOR  91
        /// #define LIBAVCODEC_VERSION_MICRO 100
        /// </summary>
        [Test]
        public void Test_avcodec_version()
        {
            var version = ffmpeg.avcodec_version();
            var major = version >> 16;
            major.Should().Be(58);
        }
    }
}
