using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RateCardQuestion:IModel
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; }
        public string QuestionText { get; set; }
        public bool IsActive { get; set; }
        public bool IsMandatory { get; set; }
        public FaultCategory FaultType { get; set; }
    }

   
}
