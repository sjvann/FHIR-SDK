using System;
using System.Text.Json.Nodes;
using FhirSDK.Resources.R5;

namespace FhirSDK.Resources.R5.Tests.Generic;

public static class ResourceFactory
{
    public static object Create(string filePath, ResourceCase c)
    {
        var dirName = new System.IO.DirectoryInfo(System.IO.Path.GetDirectoryName(filePath)!).Name;

        // If chain provided, construct default and execute chain; otherwise parse InputJson
        object resource = dirName switch
        {
            "Patient" => c.Chain != null ? new Patient() : new Patient(c.InputJson!),
            "Observation" => c.Chain != null ? new Observation() : new Observation(c.InputJson!),
            "Organization" => c.Chain != null ? new Organization() : new Organization(c.InputJson!),
            _ => throw new NotSupportedException($"Unsupported resource dir: {dirName}")
        };

        return FluentChainExecutor.Execute(dirName, resource, c);
    }
}

