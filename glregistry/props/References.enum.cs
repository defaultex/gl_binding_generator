namespace glregistry;

public static partial class References {

    public const string OutputEnumFolder = OutputFolder + "/enums";
    public const string OutputFeatureEnumFolder = OutputFolder + "/{0}/enums";
    public const string OutputExtensionEnumFolder = OutputFolder + "/extensions/{0}/enums";

    public const string EnumFilename = OutputEnumFolder + "/{0}.cs";
    public const string FeatureEnumFilename = OutputFeatureEnumFolder + "/{1}.cs";
    public const string ExtensionEnumFilename = OutputExtensionEnumFolder + "/{1}.cs";

    public const string EnumHeader = @"
public enum {0} : {1} {{ ";

    public const string EnumCode = @"
#if {2}
    {0} = gl.Constants.{1}, 
#endif
";

    public const string EnumFooter = @"
}
";

}