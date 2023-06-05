using Core.Extension;
using DataTypeService.Based;
using DataTypeService.Complex;
using System.Text.Json.Nodes;

namespace DataTypeService.Special
{
    public class Meta : ComplexType
    {

        #region Property
        public Primitive.Id? VersionId { get; init; }
        public Primitive.Instant? LastUpdated { get; init; }
        public Primitive.Uri? Source { get; init; }
        public IEnumerable<Primitive.Canonical>? Profile { get; init; }
        public IEnumerable<Coding>? Security { get; init; }
        public IEnumerable<Coding>? Tag { get; init; }
        #endregion
        #region Constructor
        public Meta() { }
        public Meta(Meta source)
        {
            VersionId = source.VersionId;
            LastUpdated = source.LastUpdated;
            Source = source.Source;
            Profile = source.Profile;
            Security = source.Security;
            Tag = source.Tag;
        }
        public Meta(string? value) : this(value.Parse()) { }
        public Meta(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                if (source["versionId"] != null)
                {
                    VersionId = new Primitive.Id(source["versionId"]);
                }
                if (source["lastUpdated"] != null)
                {
                    LastUpdated = new Primitive.Instant(source["lastUpdated"]);
                }
                if (source["source"] != null)
                {
                    Source = new Primitive.Uri(source["source"]);
                }

                if (source["profile"]?.AsArray() is JsonArray profiles)
                {
                    Profile = from item in profiles
                              where item != null
                              select new Primitive.Canonical(item);
                }
                if (source["security"]?.AsArray() is JsonArray securitys)
                {
                    Security = from item in securitys
                               where item != null
                               select new Coding(item);
                }
                if (source["tag"]?.AsArray() is JsonArray tags)
                {
                    Tag = from item in tags
                          where item != null
                          select new Coding(item);
                }
               

            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "Meta";
        #endregion

        #region Public Method
        public override void SetProperties()
        {
            List<KeyValuePair<string, JsonNode?>> result = new();
            if (VersionId is Primitive.Id versionId)
            {
                result.Add(ForPrimitiveType("versionId", versionId));
            }
            if (LastUpdated is Primitive.Instant lastUpdated)
            {
                result.Add(ForPrimitiveType("lastUpdated", lastUpdated));
            }
            if (Source is Primitive.Uri source)
            {
                result.Add(ForPrimitiveType("source", source));
            }
            if (Profile is IEnumerable<Primitive.Canonical> profile)
            {
                result.Add(ForArrayType("profile", profile));
            }
            if (Security is IEnumerable<Coding> security)
            {
                result.Add(ForArrayType("security", security));
            }
            if (Tag is IEnumerable<Coding> tag)
            {
                result.Add(ForArrayType("tag", tag))
;
            }
            _Properties = result;
        }
        #endregion
    }
}
