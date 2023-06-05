using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ObservationSub;

namespace CdsApp.Profiles
{
    public class USCoreVitalSignsProfile
    {
        private readonly Observation _source;
        public USCoreVitalSignsProfile(Observation source)
        {
            _source = source;
        }

        public virtual FhirDateTime? GetEffective()
        {

            var value = _source.Effective.GetProperty();
            if (value.Key == "effectiveDateTime" && value.Value != null)
            {
                return new FhirDateTime(value.Value); 
            }
            else
            {
                return null;
            }
        }

        public virtual CodeableConcept? GetCode()
        {
           return _source.Code;
        }
        public virtual Quantity? GetValue()
        {
            var value = _source.Value.GetProperty();
            if (value.Key == "valueQuantity" && value.Value != null)
            {
                return new Quantity(value.Value);
            }
            else
            {
                return null;
            }
        }
    }
}