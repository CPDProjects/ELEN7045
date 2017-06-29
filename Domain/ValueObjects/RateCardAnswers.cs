using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RateCardAnswers
    {
        public int Id { get; set; }
        public string FreeTextAnswer { get; set; }
        public RateCardAnswersType Answer { get; set; }

        public RateCardQuestion Question { get; set; }

    }
}
