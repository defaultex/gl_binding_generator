namespace glregistry;

class Program {
    static void Main(string[] args) {
        GLregistry registry;
        using (XmlReader reader = new XmlTextReader(References.XmlFilename)) {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GLregistry));
            registry = xmlSerializer.Deserialize(reader) as GLregistry;
        }
        registry.Initialize();
        registry.UpdateReferences();

        IEnumerable<GLcommand> cherries = registry.Commands.FindAll((x) => !x.CDecl.StartsWith("void"));

        return;
        // GLRegistry registry;
        // Stopwatch sw;

        // Console.WriteLine("Parsing registry xml '{0}'", References.XmlFilename);
        // sw = Stopwatch.StartNew();
        // registry = GLRegistry.ParseRegistry(References.XmlFilename);
        // sw.Stop();
        // Console.WriteLine("Parse completed in '{0}'", sw.ToString());

        // Console.WriteLine("Updating registry references");
        // sw = Stopwatch.StartNew();
        // registry.Update();
        // sw.Stop();
        // Console.WriteLine("Update completed in '{0}'", sw.ToString());

        // Console.WriteLine("Generating registry bindings");
        // sw = Stopwatch.StartNew();
        // Generator.WriteRegistry(registry);
        // sw.Stop();
        // Console.WriteLine("Generation completed in '{0}'", sw.ToString());
    }

}