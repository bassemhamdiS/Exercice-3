﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReadingLibrary
{
    interface IFileReader
    {
        string Read(string path);
    }
}