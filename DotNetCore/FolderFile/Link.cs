namespace FolderFile
{
    public class Link : IElement
    {
        public string Name { get; set; }

        public IElement Ref { get; set; }
    }
}
