using FhirResourceCreator.Fhir;
using System.Text;

namespace FhirResourceCreator.Models
{

    public class ResourceModel
    {
        const string RescourceFolderSub = "Sub";

        private readonly string? _RootNamespace;
        private readonly string? _ResourceName;
        private readonly string? _SaveTo;
        private readonly List<ElementRecord>? _Elements;

        /// <summary>
        /// Builds a resource model from StructureDefinition.snapshot elements.
        /// </summary>
        public ResourceModel(string resourceName, string saveTo, string? rootNamespace, IEnumerable<ElementRecord> elements)
        {
            _ResourceName = resourceName;
            _Elements = elements.ToList();
            _SaveTo = $"{saveTo}\\{resourceName}{RescourceFolderSub}";
            _RootNamespace = rootNamespace;
        }

        #region Public Method
        public string? SaveTo => _SaveTo;
        public string? ResourceName => _ResourceName;

        public IReadOnlyList<ElementRecord>? Elements => _Elements; 
        public ElementRecord? GetElement(string path)
        {
            return _Elements?.FirstOrDefault(x => x.ThisPath == path);
        }
        public OneClassContent GetResourceContent()
        {
            StringBuilder sbp = new();
            StringBuilder sbc = new();
            StringBuilder sbs = new();
            var targets = _Elements?.Where(x => x.ParentPath == _ResourceName).Where(x=>!x.IsSkip);
            if(targets != null && targets.Any())
            {
                foreach (var item in targets)
                {
                    sbp.AppendLine(item.GetProperty());
                    sbc.AppendLine(item.GetConstructor());
                    sbs.AppendLine(item.GetSetup());
                }
            }

            return new OneClassContent()
            {
                PropertyString = sbp.ToString(),
                ConstructorString = sbc.ToString(),
                SetupString = sbs.ToString()
            };
        }

        public OneClassContent GetBackboneContent(string? parentPath)
        {
            StringBuilder sbp = new();
            StringBuilder sbc = new();
            StringBuilder sbs = new();
            string backboneNamespace = $"{_RootNamespace}.{parentPath}{RescourceFolderSub}";
            var target = _Elements?.Where(x => x.ParentPath is string itemParentPath && itemParentPath == parentPath).Where(x=>!x.IsSkip);
            if(target != null && target.Any())
            {
                foreach( var item in target)
                {
                    switch (item.KeywordType)
                    {
                        case KeywordCheckerType.ForBackbone:
                            sbp.AppendLine(item.GetProperty(backboneNamespace));
                            sbc.AppendLine(item.GetConstructor(backboneNamespace));
                            sbs.AppendLine(item.GetSetup(backboneNamespace));
                            break;
                        case KeywordCheckerType.ForComplex:
                            sbp.AppendLine(item.GetProperty(KeywordChecker.ComplexDataTypeNamespace));
                            sbc.AppendLine(item.GetConstructor(KeywordChecker.ComplexDataTypeNamespace));
                            sbs.AppendLine(item.GetSetup(KeywordChecker.ComplexDataTypeNamespace));
                            break;
                        default:
                            sbp.AppendLine(item.GetProperty());
                            sbc.AppendLine(item.GetConstructor());
                            sbs.AppendLine(item.GetSetup());
                            break;
                    }
                }
            }
            return new OneClassContent()
            {
                PropertyString = sbp.ToString(),
                ConstructorString = sbc.ToString(),
                SetupString = sbs.ToString()
            };
        }

        #endregion
    }
}

