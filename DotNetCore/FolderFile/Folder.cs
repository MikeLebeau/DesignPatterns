using System.Collections.Generic;
using System.Diagnostics;

namespace FolderFile
{
    public class Folder : IElement
    {
        public string Name { get; set; }

        public List<IElement> Elements { get; set; }

        public int GetContainsNumber()
        {
            return Elements.Count;
        }

        public List<string> GetContentName()
        {
            List<string> result = new List<string>();

            if(Elements != null){
                foreach(IElement element in Elements){
                    result.Add(element.Name);

                    if(element.GetType() == typeof(Folder)){
                        result.AddRange(((Folder)element).GetContentName());
                    }else if(element.GetType() == typeof(Link) && ((Link)element).Ref.GetType() == typeof(Folder)){
                        result.Add(((Folder)((Link)element).Ref).Name);
                        result.AddRange(((Folder)((Link)element).Ref).GetContentName());
                    }
                }
            }

            //result.Sort();

            return result;
        }
    }
}
