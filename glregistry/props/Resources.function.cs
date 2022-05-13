namespace glregistry;

public static partial class Resources {

    public const string FeatureHeader = @"public partial class {0} {{ 
    public partial class Functions {{ ";

    public const string FeatureFunction = @"
        /// <summary>{0}</summary>
        public static unsafe {1}
";

    public const string FeatureFooter = @"    }
}";

}