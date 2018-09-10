namespace FriendLetter.Models
{
  public class LetterVariable
{
  private string _recipient;
  private string _sender;
  private string _vacationspot;
  private string _souvenir;

  public string GetRecipient()
  {
    return _recipient;
  }

  public void SetRecipient(string newRecipient)
  {
    _recipient = newRecipient;
  }

  public string GetSender()
  {
    return _sender;
  }

  public void SetSender(string newSender)
  {
    _sender = newSender;
  }

  public string GetVacationSpot()
  {
    return _vacationspot;
  }

  public void SetVacationSpot(string newVacationSpot)
  {
    _vacationspot = newVacationSpot;
  }

  public string GetSouvenir()
  {
    return _souvenir;
  }

  public void SetSouvenir(string newSouvenir)
  {
    _souvenir = newSouvenir;
  }
}
}
