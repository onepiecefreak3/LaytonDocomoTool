﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Domain.Level5Management.Docomo.Contract.DataClasses;

namespace Logic.Domain.Level5Management.Docomo.Contract
{
    public interface ITableReader
    {
        TableData Read(Stream indexStream, Stream dataStream);
    }
}