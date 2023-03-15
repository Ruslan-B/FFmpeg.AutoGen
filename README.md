# Important Please do support Ukraine!

[GitHub response to the war in Ukraine](https://github.blog/2022-03-02-our-response-to-the-war-in-ukraine/)<br/>
GitHub as a company is also donating $100,000 to [Razom](https://razomforukraine.org/) and matching an additional $200,000 of donations from employees to help support relief efforts in the region.

**The FFmpeg API is vast and complex and this project exposes it with minimum modifications - support is very limited.
Please consider to ask *how to* questions on [stackoverflow.com](https://stackoverflow.com/search?tab=newest&q=ffmpeg%20autogen) or in special repository on [github.com](https://github.com/Ruslan-B/FFmpeg.AutoGen.Questions/issues). 
The community may be able to offer some assistance but you will largely be on your own.
As another option you can search for a solution in C(lang) as with some effort you can convert it to C#.**

## FFmpeg.AutoGen 
[![main](https://github.com/Ruslan-B/FFmpeg.AutoGen/actions/workflows/main.yml/badge.svg)](https://github.com/Ruslan-B/FFmpeg.AutoGen/actions/workflows/main.yml)
[![travis](https://travis-ci.org/Ruslan-B/FFmpeg.AutoGen.svg)](https://travis-ci.org/Ruslan-B/FFmpeg.AutoGen)
[![nuget](https://img.shields.io/nuget/v/FFmpeg.AutoGen.svg)](https://www.nuget.org/packages/FFmpeg.AutoGen/)

FFmpeg auto generated unsafe bindings for C#/.NET and Mono.

## Usage

The basic example of the library usage: video decoding, conversion and frame extraction to jpeg is included in ```FFmpeg.AutoGen.Example``` project.  
For the more sophisticated operations please refer to offical [ffmpeg Documentation](https://www.ffmpeg.org/documentation.html) expecially API section of it.
Nuget packages version uses [semantic versioning](https://semver.org/) and in sync with MAJOR and MINOR version of FFmpeg as PATCH incremets does not changing API.

- on Windows:  
Native ffmpeg libraries are pre bundled in this repository, please note the are GPL(!) libraries. 
The x64 libraries source from [CODEX FFMPEG](https://www.gyan.dev/ffmpeg/builds/).
Please check to example project it shows how specify path to libraries.  

- on OS X:  
Install ffmpeg via [Homebrew](https://formulae.brew.sh/formula/ffmpeg):
```bash
brew install ffmpeg
```
Normally you need to set static ```ffmpeg.RootPath = ``` with full path to FFmpeg libraries.

- on Linux:  
Use your package manager of choice.
Normally you need to set static ```ffmpeg.RootPath = ``` with full path to FFmpeg libraries.

## Generation

The bindings generator uses [CppSharp](https://github.com/mono/CppSharp).

Prerequisites:
 - As of time of writing, FFmpeg 5.1 [is supported](https://github.com/Ruslan-B/FFmpeg.AutoGen/pull/211), whilst FFmpeg 6.0 [is not](https://github.com/Ruslan-B/FFmpeg.AutoGen/issues/241). Versions older or inbetween may or may not be supported. Check and contribute to the table below to keep track of the version used.
 - Visual Studio 2022 with C# and C++ desktop development workloads and Windows SDK for desktop. Older Visual Studio versions are not supported in the master branch and require minor modification of the project file to do so.

Steps to generate:
- Set the [`Active Solution plattform`](https://learn.microsoft.com/en-us/visualstudio/ide/how-to-configure-projects-to-target-multiple-platforms?view=vs-2022) to a specific plattform and *not* AnyCPU. Eg. x64 or x86
  - Just for clarification: Only `FFmpeg.AutoGen.CppSharpUnsafeGenerator` *needs* to run in a specific architecutre. The bindings may be used in your project as as `AnyCPU` or another architecture. However, the bindings won't be valid, even if paired with a .dll of the correct plattform. Bindings need to be regenerated per plattform and included per-plattform with program logic to switch between them.
- Run ```FFmpeg.AutoGen.CppSharpUnsafeGenerator;```
- All files with extension ```*.g.cs```  in ```FFmpeg.AutoGen``` project will be regenerated.

### Confirmed and tested FFmpeg versions and configure options
As build via the `https://git.ffmpeg.org/ffmpeg.git` repo and the relevant [FFmpeg build docs](https://trac.ffmpeg.org/wiki/CompilationGuide)
| Commit or Tag | Plattform | Configure Settings | Comments |
| ------------- | --------- | ------------------ | -------- |
| n5.1          | x86_64    | <details><summary>Configure Flags used</summary>`./configure --disable-nvenc --enable-shared --disable-nvdec --enable-gpl --enable-stripping --disable-vulkan --disable-sdl2 --disable-securetransport --disable-swresample --disable-swscale --disable-avfilter --disable-network --disable-doc --disable-programs --disable-d3d11va --disable-cuda-llvm --disable-dxva2 --disable-schannel --disable-mediafoundation --disable-postproc --disable-avdevice --disable-encoders --disable-hwaccels --disable-muxers --disable-parsers --disable-bsfs --disable-indevs --disable-outdevs --disable-devices --disable-filters --disable-decoders --enable-decoder=h264 --disable-protocols --enable-protocol=file --disable-demuxers --enable-demuxer=mov --enable-demuxer=h264 --enable-demuxer=m4v`</details> | Minimal build and config flags to software decode a soundless H.264 file and nothing else |

## Special Thanks
<a href="https://jetbrains.com">
<img src="https://account.jetbrains.com/static/images/jetbrains-logo-inv.svg" data-canonical-src="https://account.jetbrains.com/static/images/jetbrains-logo-inv.svg" width="128" height="128" />
 <br/>
Non-commercial open source license
 <a/>


## License

Copyright © Ruslan Balanukhin 2022
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
