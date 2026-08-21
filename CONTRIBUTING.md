# Contributing to FFmpeg.AutoGen

Thank you for your interest in contributing to FFmpeg.AutoGen! 

## Project Status

This project is transitioning to a semi-managed model. The maintainer welcomes contributions from the community!

**Maintainer:** Ruslan Balanukhin ([@Ruslan-B](https://github.com/Ruslan-B))

## How to Contribute

### Reporting Issues

- Check if the issue already exists
- Provide a clear description and steps to reproduce
- Include relevant code samples and FFmpeg version information

### Submitting Pull Requests

1. **Fork the repository** and create your branch from `main`
   ```bash
   git checkout -b feature/my-new-feature
   ```

2. **Make your changes**
   - Follow existing code style. In the generator that includes naming regex groups
     (`(?<name>...)`) and reading them by name rather than by index
   - If you touched the generator, regenerate and commit the `*.g.cs` files with it
     (see [Regenerating Bindings](#regenerating-bindings))
   - Add tests if applicable
   - Update documentation if needed

3. **Test your changes**
   ```bash
   dotnet build -c Release
   dotnet test -c Release
   ```

4. **Commit your changes**
   - Use clear commit messages
   - Reference related issues

5. **Push to your fork** and submit a pull request to the `main` branch

6. **Wait for review**
   - The maintainer will review your PR
   - Be ready to make changes if requested

## Development Setup

### Prerequisites

- Visual Studio 2022 with C# and C++ desktop development workloads
- Windows SDK for desktop
- .NET 6.0, 8.0, and 9.0 SDKs
- **7-Zip** (for extracting FFmpeg binaries)

### FFmpeg Binaries Setup

After cloning, download the required FFmpeg DLLs:

```powershell
.\FFmpeg\download-ffmpeg.ps1
```

### Building

```bash
dotnet build -c Release
```

### Running Tests

```bash
dotnet test -c Release
```

### Regenerating Bindings

Run the `FFmpeg.AutoGen.CppSharpUnsafeGenerator` project to regenerate all `*.g.cs` files:

```bash
dotnet run -c Release --project FFmpeg.AutoGen.CppSharpUnsafeGenerator -- --input FFmpeg --namespace FFmpeg.AutoGen
```

The generated files are committed on purpose. It means the repository can be built and used
without running the generator at all, and it makes a generator change reviewable as a
before-and-after diff of its own output, which is how generator bugs are usually spotted.

Because of that, a pull request that touches the generator must also carry the regenerated
files, and the two must agree. After regenerating, check that the only differences are the
ones you intended:

```bash
git diff --stat -- '*.g.cs'
```

And on a branch where you have already committed the regenerated output, this must come back
empty:

```bash
git diff --exit-code -- '*.g.cs'
```

A non-empty diff there means the committed `*.g.cs` files do not match the generator in the
same pull request.

## Code of Conduct

- Be respectful and inclusive
- Focus on constructive feedback
- Help create a welcoming environment for all contributors

## License

By contributing, you agree that your contributions will be licensed under the MIT License.

## Questions?

For general usage questions, please use:
- [Stack Overflow](https://stackoverflow.com/search?tab=newest&q=ffmpeg%20autogen)
- [Questions Repository](https://github.com/Ruslan-B/FFmpeg.AutoGen.Questions/issues)

For project-specific questions about contributions, open an issue in this repository.
