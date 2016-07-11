using Nancy;
using Letter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
    LetterVariables myLetterVariables = new LetterVariables();
    myLetterVariables.SetRecipient("Eric");
    myLetterVariables.SetSender("John");
    return View["hello.cshtml", myLetterVariables];
  };
  return View["hello.html", myLetterVariables];
};
      
    }
  }
}
