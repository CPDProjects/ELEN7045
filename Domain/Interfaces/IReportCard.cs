namespace Domain
{
    public interface IReportCard
    {
        GpsCoordinates GpsCoordinates { get; set; }
        int Id { get; set; }
        Media[] Photographs { get; set; }
        RateCardAnswers[] QuestionsAndAnswers { get; set; }
        string Reference { get; set; }
        RateCardVersion Version { get; set; }
    }
}