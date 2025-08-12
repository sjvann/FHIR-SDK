using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;

namespace ResourceTypeServices.R5
{
    public class Bundle : ResourceType<Bundle>
	{
		#region private Property
		private Identifier? _identifier;
private FhirCode? _type;
private FhirInstant? _timestamp;
private FhirUnsignedInt? _total;
private List<BundleLink>? _link;
private List<BundleEntry>? _entry;
private Signature? _signature;
private Resource? _issues;

		#endregion
		#region Public Method
		public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirInstant? Timestamp
{
get { return _timestamp; }
set {
_timestamp= value;
OnPropertyChanged("timestamp", value);
}
}

public FhirUnsignedInt? Total
{
get { return _total; }
set {
_total= value;
OnPropertyChanged("total", value);
}
}

public List<BundleLink>? Link
{
get { return _link; }
set {
_link= value;
OnPropertyChanged("link", value);
}
}

public List<BundleEntry>? Entry
{
get { return _entry; }
set {
_entry= value;
OnPropertyChanged("entry", value);
}
}

public Signature? Signature
{
get { return _signature; }
set {
_signature= value;
OnPropertyChanged("signature", value);
}
}

public Resource? Issues
{
get { return _issues; }
set {
_issues= value;
OnPropertyChanged("issues", value);
}
}


		#endregion
		#region Constructor
		public  Bundle() { }
		public  Bundle(string value) : base(value) { }
		public  Bundle(JsonNode? source) : base(source) { }
		#endregion
	}
		public class BundleLink : BackboneElementType<BundleLink>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _relation;
private FhirUri? _url;

		#endregion
		#region public Method
		public FhirCode? Relation
{
get { return _relation; }
set {
_relation= value;
OnPropertyChanged("relation", value);
}
}

public FhirUri? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}


		#endregion
		#region Constructor
		public  BundleLink() { }
		public  BundleLink(string value) : base(value) { }
		public  BundleLink(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class BundleEntrySearch : BackboneElementType<BundleEntrySearch>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _mode;
private FhirDecimal? _score;

		#endregion
		#region public Method
		public FhirCode? Mode
{
get { return _mode; }
set {
_mode= value;
OnPropertyChanged("mode", value);
}
}

public FhirDecimal? Score
{
get { return _score; }
set {
_score= value;
OnPropertyChanged("score", value);
}
}


		#endregion
		#region Constructor
		public  BundleEntrySearch() { }
		public  BundleEntrySearch(string value) : base(value) { }
		public  BundleEntrySearch(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class BundleEntryRequest : BackboneElementType<BundleEntryRequest>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _method;
private FhirUri? _url;
private FhirString? _ifNoneMatch;
private FhirInstant? _ifModifiedSince;
private FhirString? _ifMatch;
private FhirString? _ifNoneExist;

		#endregion
		#region public Method
		public FhirCode? Method
{
get { return _method; }
set {
_method= value;
OnPropertyChanged("method", value);
}
}

public FhirUri? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}

public FhirString? IfNoneMatch
{
get { return _ifNoneMatch; }
set {
_ifNoneMatch= value;
OnPropertyChanged("ifNoneMatch", value);
}
}

public FhirInstant? IfModifiedSince
{
get { return _ifModifiedSince; }
set {
_ifModifiedSince= value;
OnPropertyChanged("ifModifiedSince", value);
}
}

public FhirString? IfMatch
{
get { return _ifMatch; }
set {
_ifMatch= value;
OnPropertyChanged("ifMatch", value);
}
}

public FhirString? IfNoneExist
{
get { return _ifNoneExist; }
set {
_ifNoneExist= value;
OnPropertyChanged("ifNoneExist", value);
}
}


		#endregion
		#region Constructor
		public  BundleEntryRequest() { }
		public  BundleEntryRequest(string value) : base(value) { }
		public  BundleEntryRequest(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class BundleEntryResponse : BackboneElementType<BundleEntryResponse>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _status;
private FhirUri? _location;
private FhirString? _etag;
private FhirInstant? _lastModified;
private Resource? _outcome;

		#endregion
		#region public Method
		public FhirString? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public FhirUri? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public FhirString? Etag
{
get { return _etag; }
set {
_etag= value;
OnPropertyChanged("etag", value);
}
}

public FhirInstant? LastModified
{
get { return _lastModified; }
set {
_lastModified= value;
OnPropertyChanged("lastModified", value);
}
}

public Resource? Outcome
{
get { return _outcome; }
set {
_outcome= value;
OnPropertyChanged("outcome", value);
}
}


		#endregion
		#region Constructor
		public  BundleEntryResponse() { }
		public  BundleEntryResponse(string value) : base(value) { }
		public  BundleEntryResponse(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class BundleEntry : BackboneElementType<BundleEntry>, IBackboneElementType
	{

		#region Private Method
		private FhirUri? _fullUrl;
private Resource? _resource;
private BundleEntrySearch? _search;
private BundleEntryRequest? _request;
private BundleEntryResponse? _response;

		#endregion
		#region public Method
		public FhirUri? FullUrl
{
get { return _fullUrl; }
set {
_fullUrl= value;
OnPropertyChanged("fullUrl", value);
}
}

public Resource? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}

public BundleEntrySearch? Search
{
get { return _search; }
set {
_search= value;
OnPropertyChanged("search", value);
}
}

public BundleEntryRequest? Request
{
get { return _request; }
set {
_request= value;
OnPropertyChanged("request", value);
}
}

public BundleEntryResponse? Response
{
get { return _response; }
set {
_response= value;
OnPropertyChanged("response", value);
}
}


		#endregion
		#region Constructor
		public  BundleEntry() { }
		public  BundleEntry(string value) : base(value) { }
		public  BundleEntry(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
