namespace glregistry;

public static partial class Resources {

    public const string CommandSyntaxCSharp = "public static unsafe delegate* unmanaged[Cdecl]<{3}{0}> {1};";
    public const string CommandSyntaxC = "{0} {1}({2})";

    public const string FunctionsFilename = OutputFeatureFolder + "/gl.Functions.cs";
    public const string ExtFunctionsFilename = OutputExtensionFolder + "/gl.Functions.cs";
    
    public const string FeatureHeader = @"#if {0}
public partial class {1} {{ 
    public partial class Functions {{ ";

    public const string FeatureFunction = @"
        /// <summary>{0}</summary>
        public static unsafe {1}
";

    public const string FeatureFooter = @"    }
}
#endif";

    public const string ExtFeatureHeader = @"#if {0}
public partial class {1} {{ 
    public partial class Functions {{ ";

    public const string ExtFeatureFunction = @"
        /// <summary>{0} {1}({2})</summary>
        public static unsafe delegate* unmanaged[Cdecl]<{3}{0}> {1};
";

    public const string ExtFeatureFooter = @"    }
}
#endif";
}