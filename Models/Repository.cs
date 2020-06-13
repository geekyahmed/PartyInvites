using System.Linq;
using System.Collections.Generic;

namespace PartyInvites.Models
{
  public static class Repository
  {
    private static List<GuestResponse> responses = new List<GuestResponse>();
    public static IEnumerable<GuestResponse> Responses => responses;

    public static IEnumerable<GuestResponse> Going => Responses.Where(r => r.WillAttend == true);

    public static void AddResponse(GuestResponse response)
    {
      responses.Add(response);
    }
  }
}
