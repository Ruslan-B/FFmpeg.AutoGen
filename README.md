FFmpeg.AutoGen
==============

Auto Generated FFmpeg wrapper for C#/.NET and Mono.
Wrapper generated for FFmpeg 1.2 "Magic" that was released on 2013-03-15.

Usage
=====

Example of usage video decoding with frame extraction included in FFmpeg.AutoGen.Example project.


Download
========

Compiled wrapper including FFmpeg win32 libraries:
http://sourceforge.net/projects/ffmpeg-autogen/files/


Build
=====

Put prebuild shared libraries to "./FFmpeg/bin" folder.
You can download it for Windows from: http://ffmpeg.zeranoe.com/builds/
Compile solution.


Generate
========

Prerequisites:
 - Python 2.7
   with packages:
    - ctypes 1.0.2
    - ctypesgen 0.r125
 - gcc (MinGW for Windows)

Like for build put prebuild shared libraries to "./FFmpeg/bin".
Then put updated header files to "./FFmpeg/include".  They could be extracted from Dev build from: http://ffmpeg.zeranoe.com/builds/
Execute:
python generate.py
File "./FFmpeg.AutoGen/Native.cs" will regenerated. 

License
=======

GNU Lesser General Public License (LGPL) version 3 or later.
http://www.gnu.org/licenses/lgpl.html
