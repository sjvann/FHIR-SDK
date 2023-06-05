using DataTypeService.Complex;
using ResourceTypeServices.R5.ObservationSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdsApp.Profiles
{
    public class USCoreBmiProfileProfile :USCoreVitalSignsProfile
    {

        public USCoreBmiProfileProfile(Observation source):base(source)
        {

        }



    }
}
