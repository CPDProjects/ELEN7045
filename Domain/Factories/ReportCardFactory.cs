using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReportCardFactory
    {
        private string dbConnection;
        private ReportCardRepository repoReportCard;
        private GenericRepository<RateCardQuestion> repoQuestions;
        private GenericRepository<RateCardAnswer> repoAnswers;

        private IList<string> referenceStore;
        public ReportCardFactory(string dbConnection)
        {
            this.dbConnection = dbConnection;
            referenceStore = new List<string>();
        }

        public IReportCard Create(string userName, string faultType,string streetAddress, string gpsLatitude, string gpsLongitude, Dictionary<string,string> questionAnswerPair)
        {
            var location = streetAddress.Replace(" ","").Replace(",","").PadRight(3, 'X');
            var refId =  $"{DateTime.Today.Date.ToString("yyMMMddhh")}{userName}{location.Substring(0, 3)}{faultType}";
            referenceStore.Add(refId);
            var reportCard = new ReportCard
            {
                ReferenceNo = refId,
                GpsCoordinates = new GpsCoordinates
                {
                    Latitude = gpsLatitude,
                    Longitude = gpsLongitude,
                    Address = streetAddress
                }
            };
            reportCard.Questions = (from q in questionAnswerPair.Keys
                                    select new RateCardQuestion { ReferenceNo = q }).ToArray();

            reportCard.Answers = (from q in questionAnswerPair.Keys
                                    select new RateCardAnswer { QuestionReferenceNo = q,
                                        FreeTextAnswer = questionAnswerPair[q]
                                    }).ToArray();

            reportCard.Id= repoReportCard.Create(reportCard);
            return reportCard;
        }

        public RateCardQuestion[] GetReportCardQuestions(string faultType)
        {
            return repoQuestions.GetAll().Where(
                q => q.FaultType.ToString().ToLowerInvariant().Equals(faultType.ToLower())
            ).ToArray();
        }

        public string[] GetFaultTypes()
        {
            return Enum.GetNames(typeof(FaultCategory));
        }


    }
}
