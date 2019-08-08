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
            FileInfo fi = new FileInfo(fsi.FullName);
            Name = fsi.Name;
            Size = fi.Length;
            Path = fsi.FullName;
        }
    }
}
