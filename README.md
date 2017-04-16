# Important
**The FFmpeg API is wast and complex and this project exposes it with minimum modifications - support is very limited.
Please consider to ask *how to* questions on stackoverflow.com. 
The community may be able to offer some assistance but you will largely be on your own.
As another option you can search for a solution in C(lang) as with some effort you can convert them to C#.**

## FFmpeg.AutoGen [![Build Status](https://travis-ci.org/Ruslan-B/FFmpeg.AutoGen.png)](https://travis-ci.org/Ruslan-B/FFmpeg.AutoGen)

FFmpeg auto generated unsafe bindings for C#/.NET and Mono.  
The bindings are generated against: ffmpeg 3.2.2

The 3.2 ClangSharp based version is [here](https://github.com/Ruslan-B/FFmpeg.AutoGen/tree/3.2).

## Usage

The basic example of the library usage: video decoding, conversion and frame extraction to jpeg is included in ```FFmpeg.AutoGen.Example``` project.  
For the more sophisticated operations please refer to offical [ffmpeg Documentation](https://www.ffmpeg.org/documentation.html) expecially API section of it.

- on Windows:  
Native ffmpeg binaries are pre bundled in the repository. 
The x64 binaries source from [Zeranoe FFmpeg](http://ffmpeg.zeranoe.com/builds/).
Please check to example project it shows how specify path to libraries.  
In case you need x86 binaries, feel free to use same source.

- on OS X:  
Install ffmpeg via [MacPorts](http://www.macports.org):
```bash
sudo port install ffmpeg +universal
```
Please make sure that ```FFmpeg.AutoGen.dll``` coupled with ```FFmpeg.AutoGen.config``` and all paths are correct. 
By default MacPorts keeps compiled libraries in ```/opt/local/lib```.

- on Linux:  
You need to patch ```FFmpeg.AutoGen.config``` with full path to FFmpeg libraries.

## Generation

The bindings generator uses [CppSharp](https://github.com/mono/CppSharp).

Prerequisites:
 - FFmpeg library include files ```./ffmpeg/include```

Steps to generate:
- Run ```dump-expots.cmd``` to create exports map
- Run ```FFmpeg.AutoGen.CppSharpUnsafeGenerator;```
- All files with extension ```*.g.cs```  in ```FFmpeg.AutoGen``` project will be regenerated.

## License

Copyright © Ruslan Balanukhin 2015
All rights reserved.

Distributed under the GNU Lesser General Public License (LGPL) version 3.  
http://www.gnu.org/licenses/lgpl.html

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
