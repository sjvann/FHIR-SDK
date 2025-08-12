using System;
using System.Linq;
using System.Text.Json.Nodes;
using FhirSDK.Resources.R5;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace FhirSDK.Resources.R5.Tests.Generic;

public static class FluentChainExecutor
{
    public static object Execute(string resourceDirName, object resource, ResourceCase c)
    {
        if (c.Chain == null || c.Chain.Count == 0) return resource;

        return resourceDirName switch
        {
            "Patient" => ExecutePatient((Patient)resource, c),
            "Observation" => ExecuteObservation((Observation)resource, c),
            "Organization" => ExecuteOrganization((Organization)resource, c),
            _ => resource
        };
    }

    private static Patient ExecutePatient(Patient p, ResourceCase c)
    {
        foreach (var step in c.Chain!)
        {
            var call = step.Call;
            var args = step.Args;
            switch (call)
            {
                case "WithGender":
                    p = p.WithGender(args![0]!.GetValue<string>());
                    break;
                case "WithBirthDate":
                    p = p.WithBirthDate(args![0]!.GetValue<string>());
                    break;
                case "WithActive":
                    p = p.WithActive(args![0]!.GetValue<bool>());
                    break;
                case "AddName":
                    var nameSpec = args![0]!.AsObject();
                    p = p.AddName(hn =>
                    {
                        if (nameSpec["family"] is JsonValue fv)
                            hn.Family = new FhirString(fv.GetValue<string>());
                        if (nameSpec["given"] is JsonArray ga)
                            hn.Given = ga.Select(x => new FhirString(x!.GetValue<string>())).ToList();
                    });
                    break;
                case "AddIdentifier":
                    var idSpec = args![0]!.AsObject();
                    p = p.AddIdentifier(id =>
                    {
                        if (idSpec["use"] is JsonValue use)
                            id.Use = new FhirCode(use.GetValue<string>());
                        if (idSpec["system"] is JsonValue sys)
                            id.System = new FhirUri(sys.GetValue<string>());
                        if (idSpec["value"] is JsonValue val)
                            id.Value = new FhirString(val.GetValue<string>());
                    });
                    break;
                case "AddTelecom":
                    var telSpec = args![0]!.AsObject();
                    p = p.AddTelecom(cp =>
                    {
                        if (telSpec["system"] is JsonValue sys)
                            cp.System = new FhirCode(sys.GetValue<string>());
                        if (telSpec["value"] is JsonValue val)
                            cp.Value = new FhirString(val.GetValue<string>());
                    });
                    break;
                case "WithDeceasedBoolean":
                    p = p.WithDeceasedBoolean(args![0]!.GetValue<bool>());
                    break;
                case "WithDeceasedDateTime":
                    p = p.WithDeceasedDateTime(args![0]!.GetValue<string>());
                    break;
                default:
                    throw new NotSupportedException($"Unsupported patient chain call: {call}");
            }
        }
        return p;
        }


    private static Observation ExecuteObservation(Observation o, ResourceCase c)
    {
        foreach (var step in c.Chain!)
        {
            var call = step.Call; var args = step.Args;
            switch (call)
            {
                case "WithStatus":
                    o = o.WithStatus(args![0]!.GetValue<string>()); break;
                case "WithCode":
                    var system = args![0]!.GetValue<string>();
                    var code = args[1]!.GetValue<string>();
                    var display = args.Count > 2 ? args[2]?.GetValue<string>() : null;
                    o = o.WithCode(system, code, display); break;
                case "WithSubject":
                    o = o.WithSubject(args![0]!.GetValue<string>()); break;
                case "WithValueString":
                    o = o.WithValueString(args![0]!.GetValue<string>()); break;
                case "WithValueQuantity":
                    var val = args![0]!.GetValue<decimal>();
                    var unit = args[1]!.GetValue<string>();
                    var sys = args.Count > 2 ? args[2]?.GetValue<string>() : null;
                    var cde = args.Count > 3 ? args[3]?.GetValue<string>() : null;
                    o = o.WithValueQuantity(val, unit, sys, cde); break;
                case "WithEffectiveDateTime":
                    o = o.WithEffectiveDateTime(args![0]!.GetValue<string>()); break;
                case "WithEffectivePeriod":
                    o.EffectivePeriod = new DataTypeServices.DataTypes.ComplexTypes.Period
                    {
                        Start = new FhirDateTime(args![0]!.GetValue<string>()),
                        End = args!.Count > 1 ? new FhirDateTime(args[1]!.GetValue<string>()) : null
                    };
                    break;
                default:
                    throw new NotSupportedException($"Unsupported observation chain call: {call}");
            }
        }
        return o;
    }

    private static Organization ExecuteOrganization(Organization org, ResourceCase c)
    {
        foreach (var step in c.Chain!)
        {
            var call = step.Call; var args = step.Args;
            switch (call)
            {
                case "WithActive":
                    org = org.WithActive(args![0]!.GetValue<bool>()); break;
                case "WithName":
                    org = org.WithName(args![0]!.GetValue<string>()); break;
                case "AddIdentifier":
                    org = org.AddIdentifier(args![0]!.GetValue<string>(), args[1]!.GetValue<string>()); break;
                case "AddAlias":
                    org = org.AddAlias(args![0]!.GetValue<string>()); break;
                default:
                    throw new NotSupportedException($"Unsupported organization chain call: {call}");
            }
        }
        return org;
    }
}

