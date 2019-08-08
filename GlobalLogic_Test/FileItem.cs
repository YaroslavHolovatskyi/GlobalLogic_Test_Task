using System.IO;

namespace GlobalLogic_Test
{
    class FileItem
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }

        public FileItem(FileSystemInfo fsi)
        {
            Name = fsi.Name;
            //Size = fsi.
            Path = fsi.FullName;
        }
    }
}
