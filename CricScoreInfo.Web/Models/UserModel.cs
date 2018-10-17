namespace CricScoreInfo.Web.Models
{
  public class UserModel
  {
    public string Username { get; set; }
    public string ApiSessionToken { get; set; }
    public bool IsAuthenticated { get; set; }
    public int CompanyProfileId { get; set; }
  }
}
