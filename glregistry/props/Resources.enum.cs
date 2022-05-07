namespace glregistry;

public static partial class Resources {
    public const string EnumHeader = @"public enum {0} : {1} {{ ";

    public const string EnumCode = @"    {0} = gl.Constants.{1},";

    public const string EnumFooter = @"
}
";

}