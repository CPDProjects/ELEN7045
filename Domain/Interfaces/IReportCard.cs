namespace Domain
{
    public interface IReportCard
    {
        GpsCoordinates GpsCoordinates { get; set; }
        int Id { get; set; }
        Media[] Photographs { get; set; }
        RateCardQuestion[] Questions { get; set; }
        RateCardAnswer[] Answers { get; set; }
        string ReferenceNo { get; set; }
        RateCardVersion Version { get; set; }
    }
}