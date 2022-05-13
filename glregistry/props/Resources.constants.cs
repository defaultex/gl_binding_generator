namespace glregistry;

public static partial class Resources {

    public const string ConstantsHeader = @"public partial class {0} {{ 
    public partial class Constants {{";

    public const string ConstantsDefinition = @"        public const {2} {0} = {1};";

    public const string ConstantsFooter = @"    }
}";

}