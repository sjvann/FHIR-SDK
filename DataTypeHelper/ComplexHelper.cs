

using DataTypeHelper.Complex;
using DataTypeHelper.Meta;
using DataTypeHelper.Special;
using DataTypeService.Complex;

using DataTypeService.Meta;
using DataTypeService.Special;

namespace DataTypeService.Helper
{
    public static partial class DataTypeHelper
    {
        #region Complex Data Type
        public static Coding ToFhirCoding(this CodingHelper v)
        {
            return new Coding
            {
                System = v.System.ToFhirUri(),
                Version = v.Version.ToFhirString(),
                Code = v.Code.ToFhirCode(),
                Display = v.Display.ToFhirString(),
                UserSelected = v.UserSelected.ToFhirBoolean()
            };
        }
        public static CodeableConcept ToFhirCodeableConcept(this CodeableConceptHelper v)
        {
            return new CodeableConcept()
            {
                Coding = v.Coding?.Select(x => x.ToFhirCoding()!),
                Text = v.Text.ToFhirString()
            };

        }
        public static Address ToFhirAddress(this AddressHelper v)
        {
            return  new Address()
            {
                Use = v.Use.ToFhirCode(),
                Type = v.Type.ToFhirCode(),
                Text = v.Text.ToFhirString(),
                Line = v.Line?.Select(x => x.ToFhirString()!),
                City = v.Use.ToFhirString(),
                District = v.District.ToFhirString(),
                State = v.State.ToFhirString(),
                PostalCode = v.PostalCode.ToFhirString(),
                Country = v.Country.ToFhirString(),
                Period = v.Period?.ToFhirPeriod()
            };

        }
        public static Period ToFhirPeriod(this PeriodHelper v)
        {
            return new Period()
            {
                Start = v.Start?.ToFhirDateTime(),
                End = v.End?.ToFhirDateTime()
            };
        }
        public static Identifier ToFhirIdentifier(this IdentifierHelper v)
        {
            return  new Identifier
            {
                Use = v.Use.ToFhirCode(),
                Type = v.Type?.ToFhirCodeableConcept(),
                System = v.System.ToFhirUri(),
                Value = v.Value.ToFhirString(),
                Period = v.Period?.ToFhirPeriod(),
                Assigner = v.Assigner?.ToFhirReference()
            };
        }

        public static Attachment ToFhirAttachment(this AttachmentHelper v)
        {
            return new Attachment
            {
                ContentType = v.ContentType.ToFhirCode(),
                Language = v.Language.ToFhirCode(),
                Data = v.Data.ToFhirBase64Binary(),
                Url = v.Url.ToFhirUrl(),
                Size = v.Size.ToFhirInt64(),
                Hash = v.Hash.ToFhirBase64Binary(),
                Title = v.Title.ToFhirString(),
                Creation =  v.Creation?.ToFhirDateTime(),
                Height = v.Height.ToFhirPositiveInt(),
                Width = v.Width.ToFhirPositiveInt(),
                Frames = v.Frames.ToFhirPositiveInt(),
                Duration = v.Duration.ToFhirDecimal(),
                Pages = v.Pages.ToFhirPositiveInt()
            };
        }
        public static ContactPoint ToFhirContactPoint(this ContactPointHelper v)
        {
            return new ContactPoint
            {
                System = v.System.ToFhirCode(),
                Value = v.Value.ToFhirString(),
                Use = v.Use.ToFhirCode(),
                Rank = v.Rank.ToFhirPositiveInt(),
                Period = v.Period?.ToFhirPeriod()
            };
        }
        public static HumanName ToFhirHumanName(this HumanNameHelper v)
        {
            return new HumanName
            {
                Use = v.Use.ToFhirCode(),
                Text = v.Text.ToFhirString(),
                Family = v.Family.ToFhirString(),
                Given = v.Given?.Select(x => x.ToFhirString()!),
                Prefix = v.Prefix?.Select(x => x.ToFhirString()!),
                Suffix = v.Suffix?.Select(x => x.ToFhirString()!),
                Period = v.Period?.ToFhirPeriod()
            };
        }
        public static Annotation ToFhirAnnotation(this AnnotationHelper v)
        {
            return new Annotation
            {
                Author = v.Author.ToFhirChoiceAuthor(),
                Time = v.Time?.ToFhirDateTime(),
                Text = v.Text.ToFhirMarkdown()
            };
        }
        public static Quantity ToFhirQuantity(this QuantityHelper v)
        {
            return  new Quantity
            {
                Value = v.Value.ToFhirDecimal(),
                Comparator = v.Comparator.ToFhirCode(),
                Unit = v.Unit.ToFhirString(),
                System = v.System.ToFhirUri(),
                Code = v.Code.ToFhirCode()
            };
        }
        public static Duration ToFhirDuration(this DurationHelper v)
        {
            return  new Duration
            {
                Value = v.Value.ToFhirDecimal(),
                Comparator = v.Comparator.ToFhirCode(),
                Unit = v.Unit.ToFhirString(),
                System = v.System.ToFhirUri(),
                Code = v.Code.ToFhirCode()
            };
        }
        public static SimpleQuantity ToFhirSimpleQuantity(this SimpleQuantityHelper v)
        {
            return  new SimpleQuantity
            {
                Value = v.Value.ToFhirDecimal(),
                Comparator = v.Comparator.ToFhirCode(),
                Unit = v.Unit.ToFhirString(),
                System = v.System.ToFhirUri(),
                Code = v.Code.ToFhirCode()
            };
        }
        public static Money ToFhirMoney(this MoneyHelper v)
        {
            return new Money
            {
                Value = v.Value.ToFhirDecimal(),
                Currency = v.Currency.ToFhirCode()
            };
        }
        public static Complex.Range ToFhirRange(this RangeHelper v)
        {
            return  new Complex.Range
            {
                Low = v.Low?.ToFhirSimpleQuantity(),
                High = v.Hight?.ToFhirSimpleQuantity()
            };
        }
        public static Ratio ToFhirRatio(this RatioHelper v)
        {
            return new Ratio
            {
                Numerator = v.Numerator?.ToFhirQuantity(),
                Denominator = v.Denominator?.ToFhirSimpleQuantity()
            };
        }
        public static RatioRange ToFhirRatioRange(this RatioRangeHelper v)
        {
            return  new RatioRange
            {
                LowNumerator = v.LowNumberator?.ToFhirSimpleQuantity(),
                HighNumerator = v.HighNumberator?.ToFhirSimpleQuantity(),
                Denominator = v.Denominator?.ToFhirSimpleQuantity()
            };
        }
        public static SampledData ToFhirSampledData(this SampledDataHelper v)
        {
            return new SampledData
            {
                Origin = v.Origin?.ToFhirQuantity(),
                Interval = v.Interval.ToFhirDecimal(),
                IntervalUnit = v.IntervalUnit.ToFhirCode(),
                Factor = v.Factor.ToFhirDecimal(),
                LowerLimit = v.LowerLimit.ToFhirDecimal(),
                UpperLimit = v.UpperLimit.ToFhirDecimal(),
                Dimensions = v.Dimensions.ToFhirPositiveInt(),
                Data = v.Data.ToFhirString()
            };
        }
        public static Repeat ToFhirRepeat(this RepeatHelper v)
        {
            return new Repeat
            {
                Bounds = v.Bounds.ToFhirChoiceBounds(),
                Count = v.Count.ToFhirPositiveInt(),
                CountMax = v.CountMax.ToFhirPositiveInt(),
                Duration = v.Duration.ToFhirDecimal(),
                DurationMax = v.DurationMax.ToFhirDecimal(),
                DurationUnit = v.DurationUnit.ToFhirCode(),
                Frequency = v.Frequency.ToFhirPositiveInt(),
                FrequencyMax = v.FrequencyMax.ToFhirPositiveInt(),
                Period = v.Period.ToFhirDecimal(),
                PeriodMax = v.PeriodMax.ToFhirDecimal(),
                PeriodUnit = v.PeriodUnit.ToFhirCode(),
                DayOfWeek = v.DayOfWeek?.Select(x => x.ToFhirCode()!),
                TimeOfDay = v.TimeOfDay?.Select(x => x.ToFhirTime()!),
                When = v.When?.Select(x => x.ToFhirCode()!),
                Offset = v.Offset.ToFhirPositiveInt()
            };
        }
        public static Timing ToFhirTiming(this TimingHelper v)
        {
            return new Timing
            {
                Event =v.Event?.Select(x=>x.ToFhirDateTime()!).ToList(),
                Repeat = v.Repeat?.ToFhirRepeat(),
                Code = v.Code?.ToFhirCodeableConcept()
            };
        }
        public static Signature ToFhirSignature(this SignatureHelper v)
        {
            return new Signature
            {
               Type = v.Type?.Select(x=>x.ToFhirCoding()!),
               When = v.When?.ToFhirInstant(),
               Who = v.Who?.ToFhirReference(),
               OnBehalfOf = v.OnBehalfOf?.ToFhirReference(),
               TargetFormat = v.TargetFormat.ToFhirCode(),
               SigFormat = v.SigFormat.ToFhirCode(),
               Data = v.Data.ToFhirBase64Binary()
            };
        }
        #endregion
        #region Meta Data Type
        public static ExtendedContactDetail ToFhirExtendedContactDetail(this ExtendedContactDetailHelper v)
        {
            return new ExtendedContactDetail
            {
                Purpose = v.Purpose?.ToFhirCodeableConcept(),
                Name = v.Name?.Select(x=>x.ToFhirHumanName()!),
                Telecom = v.Telecom?.Select(x=>x.ToFhirContactPoint()!),
                Address = v.Address?.ToFhirAddress(),
                Organization = v.Organization?.ToFhirReference(),
                Period = v.Period?.ToFhirPeriod()
            };
        }
        #endregion
        #region Special Data Type
        public static Reference ToFhirReference(this ReferenceHelper v)
        {
            return new Reference
            {
                ReferenceName = v.ReferenceName.ToFhirString(),
                Type = v.Type.ToFhirUri(),
                Identifier = v.Identifier?.ToFhirIdentifier(),
                Display = v.Display.ToFhirString()
            };
        }
        public static Narrative ToFhirNarrative(this NarrativeHelper v)
        {
            return new Narrative
            {
               Status = v.Status.ToFhirCode(),
               Div = v.Div.ToFhirXHtml()
            };
        }
        #endregion
    }
}
