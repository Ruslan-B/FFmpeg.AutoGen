# Important
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
 - Visual Studio 2019 with C# and C++ desktop development workloads and Windows SDK for desktop.

Steps to generate:
- Run ```FFmpeg.AutoGen.CppSharpUnsafeGenerator;```
- All files with extension ```*.g.cs```  in ```FFmpeg.AutoGen``` project will be regenerated.

## License

Copyright © Ruslan Balanukhin 2020
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
