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
 - Visual Studio 2019 with C# and C++ desktop development workloads and Windows SDK for desktop.

Steps to generate:
- Run ```FFmpeg.AutoGen.CppSharpUnsafeGenerator;```
- All files with extension ```*.g.cs```  in ```FFmpeg.AutoGen``` project will be regenerated.

## Packaging ffmpeg *.dlls in a nuget package for automatic extraction
You may package the ffmpeg .dlls required to run you code in a Nuget package that you create. When a user installs your Nuget package, the ffmpeg .dlls will be automatically extracted into the directory of the binary / assembly, without the user having to paste it manually. This opens up the door for a small footprint, custom build ffmpeg library. Because the ffmpeg .dlls are not managed C# code, the packaging required manual editing of Visual Studio's `.csproj` file, after enabling your library to be build as a Nuget package. AFAIK Nuget pack on other OSs also honors these settings.
### .csproj settings
Since Visual Studio 2017, the generation of a `.nuspec` file is *not* required anymore. Put the .dlls in a subfolder (here `ffmpeg\`) in your project. In the `<ItemGroup>` tag create a `<None>` or `<Content>` tag. Specify the files to be included via the `Include` property. (Everything is case-sensitive, so `include` is invalid) set `Pack` to `true` and `PackagePath` to the target path in the nuget package. `lib\$(TargetFramework)` would place it at the same place as the binary (unless `TargetFramework` is undefined). Most crucially, specify `PackageCopyToOutput` as `true`, which performs the extraction and copying upon build.
```xml
<ItemGroup>
  <PackageReference Include="FFmpeg.AutoGen.Bindings.DynamicallyLoaded" Version="5.1.1.1" />
  <None Include="ffmpeg\*.dll" Pack="true" PackagePath="lib\$(TargetFramework)" PackageCopyToOutput="true" />
</ItemGroup>
```
### Extraction not performed upon enabling PackageCopyToOutput in a Nuget package Update
Visual Studio 2022 has a bug, where extraction/copying is not performed, after enabling this packaging behaviour and pushing it as a Nuget package update, where it wasn't enabled previously. To remedy right click your project, that consumes this Nuget package, click `clean` and after that `rebuild`. Now the consuming App should extract the .dlls going forward.

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
