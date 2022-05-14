namespace glregistry;

public static partial class Resources {

    public const string CSProjFilename = OutputFolder + "/gl.csproj";
    public const string CSProjCode = @"
<Project Sdk = ""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>

</Project>";

}