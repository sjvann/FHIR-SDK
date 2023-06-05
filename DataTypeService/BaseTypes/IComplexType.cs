﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeService.BaseTypes
{
    public interface IComplexType : IDataType
    {
        public JsonNode? GetJsonNode();
        public JsonNode? GetElementProperties();

    }
}
