##FFmpeg.AutoGen

Auto Generated FFmpeg wrapper for C#/.NET and Mono.  
Wrapper generated for FFmpeg - Build Version: git-0fb64da (2013-04-28)

##Usage

Example of usage video decoding with frame extraction included in FFmpeg.AutoGen.Example project.

##Download

Compiled wrapper including prebuilt [Zeranoe FFmpeg](http://ffmpeg.zeranoe.com/builds/) (Windows 64-bit) libraries:  
http://sourceforge.net/projects/ffmpeg-autogen/files/

##Build

- Put prebuild shared libraries to "./FFmpeg/bin" folder.  
You can get them for Windows for example from [here](http://ffmpeg.zeranoe.com/builds/).  
- Compile solution.

##Generate

Prerequisites:
 - Python 2.7
   with packages:
    - ctypes 1.0.2
    - ctypesgen 0.r125
 - gcc (MinGW for Windows)

Steps:
- Like for build put prebuild shared libraries to "./FFmpeg/bin".
- Then put updated header files to "./FFmpeg/include".  
They could be extracted from ffmpeg source code or from [dev build](http://ffmpeg.zeranoe.com/builds/). 
- Execute: python generate.py
- File "./FFmpeg.AutoGen/Native.cs" will regenerated.

##License

GNU Lesser General Public License (LGPL) version 3 or later.  
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