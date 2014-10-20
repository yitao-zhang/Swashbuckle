﻿using System;

namespace Swashbuckle.Swagger20
{
    public interface ISwaggerProvider
    {
        SwaggerDocument GetSwaggerFor(string apiVersion);
    }

    public class UnknownApiVersion : Exception
    {
        public UnknownApiVersion(string apiVersion)
            : base(String.Format("Unknown API version - {0}", apiVersion))
        {}
    }
}