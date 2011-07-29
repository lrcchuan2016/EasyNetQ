﻿using System.Collections.Generic;

namespace EasyNetQ.Hosepipe
{
    public interface IMessageReader
    {
        IEnumerable<string> ReadMessages(QueueParameters parameters);
    }
}