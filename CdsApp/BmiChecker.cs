using CdsApp.Model;
using CdsApp.Profiles;
using Core.CdsHooks.Cards;
using ResourceTypeServices.R5.ObservationSub;

namespace CdsApp
{
    public class BmiChecker
    {
        const decimal LowBound = 18.5M;
        const decimal NormalBound = 24.0M;
        const decimal UpBound = 35.0M;

        private readonly IEnumerable<BmiCheckResultModel>? _bmiResults;
        private readonly List<CardModel> _cardResult = new();

        public BmiChecker(IEnumerable<Observation> source)
        {
          var bmiProfiles = source.Select(x => new USCoreBmiProfileProfile(x));
            _bmiResults = bmiProfiles.Select(x => new BmiCheckResultModel
            {
                Effective = x.GetEffective()?.Value.DateTime,
                Value = x.GetValue()?.Value?.Value,
                Result = CheckBmi(x.GetValue()?.Value?.Value)
            });
            SetupCardResult();
        }
        public IEnumerable<CardModel> GetCardResult() => _cardResult;
        private void SetupCardResult()
        {
            if(_bmiResults != null && _bmiResults.Any())
            {
                foreach(var item in _bmiResults)
                {
                    var card = new CardModel
                    {
                        Uuid = Guid.NewGuid().ToString(),
                        Summary = GetSummary(item.Effective),
                        Indicator = "info",
                        Detail = GetDetail(item.Result, item.Value),
                        Source = GetSource(),
                        Links = GetLinks(item.Result)

                    };
                    _cardResult.Add(card);
                }
            }
        }

        private static List<LinkModel> GetLinks(string? result)
        {
            List<LinkModel> links = new();
            if (result != "正常")
            {
                links.Add(new LinkModel
                {
                    Label = "諮詢服務",
                    Url = "https://www.hpa.gov.tw"
                });
            }
            return links;
        }

        private SourceModel GetSource()
        {
            return new SourceModel
            {
                Label = "國立台北護理健康大學-健康事業管理系 Copyright @2023",
                Url = "https://dohcm.ntunhs.edu.tw/"
            };
        }

        public IEnumerable<BmiCheckResultModel>? GetResult() => _bmiResults ;

        private static string CheckBmi(decimal? bmi)
        {

            if (bmi == null) { return "無法計算"; }
            else
            {
                if (bmi < LowBound) { return "過輕"; }
                else if (bmi <= NormalBound) { return "正常"; }
                else if (bmi >= UpBound) { return "嚴重肥胖"; }
                else { return "過重"; }
            }

        }
        private static string GetSummary(DateTime? source)
        {
            var timeMake = source != null? $"({source.Value.ToString("yyyy-MM-dd")})" :string.Empty;
            return $"BMI風險檢核器 {timeMake}";
        }

        private static string GetDetail(string? result, decimal? value)
        {
            if (result == null || value == null) { return "無法檢測"; }
            else
            {
                return $"檢測結果為 {result}，BMI值為{value?.ToString("F2")}";
            }
        }
    }
}
