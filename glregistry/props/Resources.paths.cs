namespace glregistry;

public static partial class Resources {
    
    public const string XmlFilename = @"../glregistry/gl.xml";

    public const string OutputFolder = @"../gl";
    public const string ObjectFolder = OutputFolder + "/objects";
    public const string EnumFolder = OutputFolder + "/enums";
    public const string FeatureFolder = OutputFolder + "/features/{0}";
    public const string FeatureEnumFolder = OutputFolder + "/features/{0}/enums";
    public const string ExtensionFolder = OutputFolder + "/extensions/{0}";
    public const string ExtEnumFolder = OutputFolder + "/extensions/{0}/enums";
    
    public const string ObjectFilename = ObjectFolder + "/GL{0}.cs";
    public const string EnumFilename = EnumFolder + "/{0}.cs";

    public const string FunctionsFilename = FeatureFolder + "/gl.Functions.cs";
    public const string ConstantsFilename = FeatureFolder + "/gl.Constants.cs";
    public const string FeatureEnumFilename = FeatureEnumFolder + "/{1}.cs";

    public const string ExtFunctionsFilename = ExtensionFolder + "/gl.Functions.cs";
    public const string ExtConstantsFilename = ExtensionFolder + "/gl.Constants.cs";
    public const string ExtEnumFilename = ExtEnumFolder + "/{1}.cs";




}