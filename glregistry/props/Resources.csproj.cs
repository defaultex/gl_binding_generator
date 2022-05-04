namespace glregistry;

public static partial class Resources {

    public const string CSProjFilename = OutputFolder + "/gl.csproj";
    public const string CSProjCode = @"
<Project Sdk = ""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    <DefineConstants>" +
      "GL_API;GLCORE_API;" +
      "GL_VERSION_1_0;GL_VERSION_1_1;GL_VERSION_1_2;GL_VERSION_1_3;GL_VERSION_1_4;GL_VERSION_1_5;" + 
      "GL_VERSION_2_0;GL_VERSION_2_1;" +
      "GL_VERSION_3_0;GL_VERSION_3_1;GL_VERSION_3_2;GL_VERSION_3_3;" +
      "GL_VERSION_4_0;GL_VERSION_4_1;GL_VERSION_4_2;GL_VERSION_4_3;GL_VERSION_4_4;GL_VERSION_4_5;GL_VERSION_4_6" +
    @"</DefineConstants>
  </PropertyGroup>

</Project>";

}