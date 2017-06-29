using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReportCard : IReportCard
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public RateCardVersion Version { get; set; }
        public RateCardAnswers[] QuestionsAndAnswers { get; set; }
        public Media[] Photographs { get; set; }
        public GpsCoordinates GpsCoordinates { get; set; }

    }
}
