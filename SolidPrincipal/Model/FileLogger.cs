﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class FileLogger:ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"Error.txt", error);
        }
    }
}
