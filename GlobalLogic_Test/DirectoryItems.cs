using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace GlobalLogic_Test
{
    class DirectoryItems
    {
        public string Name { get; set; }
        public string DateCreated { get; set; }
        public List<FileItem> Files { get; set; }
        public List<DirectoryItems> Children { get; set; }

        public DirectoryItems(FileSystemInfo fsi)
        {
            Name = fsi.Name;
            DateCreated = fsi.CreationTime.ToString("dd MMMM yyyy hh:mm tt");

            Children = new List<DirectoryItems>();
            Files = new List<FileItem>();

            foreach (FileSystemInfo f in (fsi as DirectoryInfo).GetFileSystemInfos())
            {
                if (f.Attributes == FileAttributes.Directory)
                    Children.Add(new DirectoryItems(f));
                else
                {
                    Files.Add(new FileItem(f));
                }
            }
        }
        public string JsonToDynatree()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
