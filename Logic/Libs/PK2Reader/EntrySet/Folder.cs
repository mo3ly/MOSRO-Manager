using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PK2Reader
{
    public class Folder
    {
        private string m_Name;
        private string m_path;
        private long m_Position;
        private List<File> m_Files;
        private List<Folder> m_SubFolders;

        public string Name { get { return m_Name; } set { m_Name = value; } }
        public string Path { get { return m_path; } set { m_path = value; } }
        public long Position { get { return m_Position; } set { m_Position = value; } }
        public List<File> Files { get { return m_Files; } set { m_Files = value; } }
        public List<Folder> SubFolders { get { return m_SubFolders; } set { m_SubFolders = value; } }

    }
}
