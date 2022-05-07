namespace glregistry;

class Program {
    static void Main(string[] args) {
        GLregistry registry;

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(GLregistry));
        using (XmlReader reader = new XmlTextReader(Resources.XmlFilename)) {
            registry = xmlSerializer.Deserialize(reader) as GLregistry;
        }

        Console.WriteLine("Initializing registry");
        registry.Initialize();

        Console.WriteLine("Updating references");
        registry.UpdateReferences();

        Console.WriteLine("Updating code");
        registry.UpdateCode();

        Console.WriteLine("Writing library");
        Generator.WriteRegistry(registry);
    }
}