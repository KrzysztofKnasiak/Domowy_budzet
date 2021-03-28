using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Domowy_budzet.Interfaces
{
    public interface IXmlStorage
    {
        bool FromXml(Stream Stream);
        MemoryStream ToXml();
    }
}
