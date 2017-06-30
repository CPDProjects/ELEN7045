using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RateCardAnswer:IModel
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; }
        public string QuestionReferenceNo { get; set; }
        public string FreeTextAnswer { get; set; }
        public RateCardAnswersType AnswerType { get; set; }        

    }
}
