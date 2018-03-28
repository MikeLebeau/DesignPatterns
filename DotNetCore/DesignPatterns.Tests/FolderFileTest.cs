using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolderFile;
using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPatterns
{
    [TestClass]
    public class FolderFileTest
    {
        [TestMethod]
        public void Should_folder_contains_one_element_when_gettings_contains()
        {
            var textFile = new File { Name = "data.txt" };
            var parentFolder = new Folder { Name = "Parent Folder" };
            parentFolder.Elements.Add(textFile);

            var containsNumber = parentFolder.GetContainsNumber();
            
            Assert.AreEqual(1, containsNumber);
        }

        [TestMethod]
        public void Should_folder_contains_three_elements_when_gettings_contains()
        {
            var folder = CreateFolderTree();

            var containsNumber = folder.GetContainsNumber();
            
            Assert.AreEqual(2, containsNumber);
        }

        private static Folder CreateFolderTree()
        {
            var textFile = new File { Name = "bdata.txt" };
            var firstFolder = new Folder { Name = "aData Folder" };
            var secondFolder = new Folder { Name = "Folder" };
            var parentFolder = new Folder { Name = "Parent Folder" };

            var link = new Link {Name = "Link"};
            link.Ref = secondFolder;
            
            firstFolder.Elements = new List<IElement>{ secondFolder };

            parentFolder.Elements = new List<IElement>();
            parentFolder.Elements.Add(textFile);
            parentFolder.Elements.Add(firstFolder);
            parentFolder.Elements.Add(link);

            return parentFolder;
        }

        // By Moi
        [TestMethod]
        public void blabla()
        {
            var folder = CreateFolderTree();

            foreach(IElement el in folder.Elements){
                Debug.WriteLine("Name : " + el.Name);
                Debug.WriteLine("Type : " + el.GetType());
            }

            Assert.AreEqual(3, folder.Elements.Count);
        }

        [TestMethod]
        public void blablu()
        {
            var textFile = new File { Name = "data.txt" };
            
            var secondFolder = new Folder { Name = "Folder" };
            secondFolder.Elements = new List<IElement>{ textFile };

            var link = new Link {Name = "Link"};
            link.Ref = secondFolder;

            var parentFolder = new Folder { Name = "Parent Folder" };
            parentFolder.Elements = new List<IElement>{ link };

            foreach(string el in parentFolder.GetContentName()){
                Debug.WriteLine("Name : " + el);
            }

            Assert.AreEqual(1, parentFolder.Elements.Count);
        }
    }
}
