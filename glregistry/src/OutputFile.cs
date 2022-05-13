namespace glregistry;

class OutputFile : ICodeProvider {
    // whichever is not null is what the file represents
    public GLFeature Feature;
    public GLExtension Extension;

    public List<GLEnum> Enums = new();
    public List<GLCommand> Commands = new();
    public List<GLGroup> Groups = new();

    public string Name {
        get {
            if (Feature != null) {
                return Feature.Name;
            }

            if (Extension != null) {
                return Extension.Name;
            }

            return null;
        }
    }

    string ICodeProvider.CDecl => string.Empty;
    string ICodeProvider.CSDecl => string.Empty;

    public void UpdateCode() {
        Enums.UpdateCode();
        Commands.UpdateCode();
        Groups.UpdateCode();
    }

    public void TrimLists() {
        Enums.RemoveAll(x => !x.Required);
        Commands.RemoveAll(x => !x.Required);
    }
}
