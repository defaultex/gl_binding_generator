public static partial class References {

    public const string OutputEnumFolder = OutputFolder + "/enums";
    public const string EnumFilename = OutputEnumFolder + "/{0}.cs";

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