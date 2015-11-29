set dumpbin="%PROGRAMFILES(X86)%\Microsoft Visual Studio 12.0\VC\bin\amd64\dumpbin.exe" 
del .\ffmpeg\exports.txt
cd .\ffmpeg\bin\x64\
%dumpbin% /EXPORTS avcodec-56.dll avdevice-56.dll avfilter-5.dll avformat-56.dll avutil-54.dll postproc-53.dll swresample-1.dll swscale-3.dll >> ..\..\exports.txt
cd ..\..\..\