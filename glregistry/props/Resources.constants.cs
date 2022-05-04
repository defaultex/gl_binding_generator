namespace glregistry;

public static partial class Resources {

    public const string ConstantsFilename = OutputFeatureFolder + "/gl.Constants.cs";
    public const string ExtConstantsFilename = OutputExtensionFolder + "/gl.Constants.cs";

    public const string ConstantsHeader = @"#if {0}
public partial class {1} {{ 
    public partial class Constants {{ 
";

    public const string ConstantsDefinition = @"        public const {2} {0} = {1};";

    public const string ConstantsFooter = @"    }
}
#endif";

    public const string ExtConstantsHeader = @"#if {0}
public partial class {1} {{ 
    public partial class Constants {{ 
";

    public const string ExtConstantsDefinition = @"        public const {2} {0} = {1};
";

    public const string ExtConstantsFooter = @"    }
}
#endif";
}