namespace glregistry;

public static partial class Resources {

    public const string ConstantsHeader = @"#if {0}
public partial class {1} {{ 
    public partial class Constants {{ 
";

    public const string ConstantsDefinition = @"        public const {2} {0} = {1};";

    public const string ConstantsFooter = @"    }
}
#endif";

}