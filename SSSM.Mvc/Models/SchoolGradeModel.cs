using SSSM.Common.Models.Common;
using System.Collections.Generic;

namespace SSSM.Common.Models
{
    public class SchoolGradeModel : BaseNameModel
    {
        public List<SchoolClassModel> SchoolClasses { get; set; }
    }
}
