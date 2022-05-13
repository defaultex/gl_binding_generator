namespace glregistry;

public static partial class Resources {
    
    public const string XmlFilename = @"../glregistry/gl.xml";

    public const string OutputFolder = @"../gl";
    public const string ObjectFolder = OutputFolder + "/objects";
    public const string FeatureFolder = OutputFolder + "/features/{0}";
    public const string ExtensionFolder = OutputFolder + "/extensions/{0}";
    
    public const string ObjectFilename = ObjectFolder + "/GL{0}.cs";

    public const string FunctionsFilename = "/{0}.Functions.cs";
    public const string ConstantsFilename = "/{0}.Constants.cs";
    public const string EnumFilename = "/{0}.cs";

}