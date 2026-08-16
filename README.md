## Important Announcement

**This project is undergoing a transition to a semi-managed model over the coming months.**

- **All existing packages and versions will continue to work** - there will be no breaking changes to existing functionality
- The project is now **MIT licensed** (changed from LGPL) - see LICENSE.txt for details
- **Contributions are welcome!** If you'd like to help with the project, please feel free to contribute
- The FFmpeg binaries continue to be distributed with their original licenses from the source

**Founder & Maintainer:** Ruslan Balanukhin (Rationale One)

For questions and support, please continue using [stackoverflow.com](https://stackoverflow.com/search?tab=newest&q=ffmpeg%20autogen) or the [questions repository](https://github.com/Ruslan-B/FFmpeg.AutoGen.Questions/issues).

---

# Important
**The FFmpeg API is vast and complex and this project exposes it with minimum modifications - support is very limited.
Please consider to ask *how to* questions on [stackoverflow.com](https://stackoverflow.com/search?tab=newest&q=ffmpeg%20autogen) or in special repository on [github.com](https://github.com/Ruslan-B/FFmpeg.AutoGen.Questions/issues). 
The community may be able to offer some assistance but you will largely be on your own.
As another option you can search for a solution in C(lang) as with some effort you can convert it to C#.**
Here repository with C# converted examples: https://github.com/stjeong/ffmpeg_autogen_cs

## FFmpeg.AutoGen 
[![main](https://github.com/Ruslan-B/FFmpeg.AutoGen/actions/workflows/main.yml/badge.svg)](https://github.com/Ruslan-B/FFmpeg.AutoGen/actions/workflows/main.yml)
[![nuget](https://img.shields.io/nuget/v/FFmpeg.AutoGen.svg)](https://www.nuget.org/packages/FFmpeg.AutoGen/)

FFmpeg auto generated unsafe bindings for C#/.NET and Mono.

## Usage

The basic example of the library usage: video decoding, conversion and frame extraction to jpeg is included in ```FFmpeg.AutoGen.Example``` project.  
For the more sophisticated operations please refer to offical [ffmpeg Documentation](https://www.ffmpeg.org/documentation.html) expecially API section of it.
Nuget packages version uses [semantic versioning](https://semver.org/) and is in sync with the FFmpeg release the bindings are generated from, e.g. package `9.0.1` targets FFmpeg 9.0.1.

- on Windows:
The x64 libraries source from [CODEX FFMPEG](https://www.gyan.dev/ffmpeg/builds/).
Run the download script to get the required DLLs:
```powershell
.\FFmpeg\download-ffmpeg.ps1
```
Please check the example project, it shows how to specify the path to libraries.

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
 - Visual Studio 2022 with C# and C++ desktop development workloads and Windows SDK for desktop.

Steps to generate:
- Run ```FFmpeg.AutoGen.CppSharpUnsafeGenerator;```
- All files with extension ```*.g.cs```  in ```FFmpeg.AutoGen``` project will be regenerated.

## License

Copyright © 2025 Ruslan Balanukhin (Rationale One)  
All rights reserved.

Distributed under the **MIT License**.  
See LICENSE.txt for full license text.

**Note:** FFmpeg binaries are distributed under their original licenses (GPL/LGPL) from the source.
Please refer to [FFmpeg License](https://www.ffmpeg.org/legal.html) for details.
