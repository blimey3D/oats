﻿using System;
using System.IO;

namespace Oats
{
    public interface IStreamSerialiser
    {
        void Initialise (Stream stream, ChannelMode mode); 
        Type [] SupportedTypes { get; }
        void Write<T> (T value);
        T Read <T> ();
    }
}

