using Nancy;
using Triangles.Objects;
using System;
using System.Text;
using System.Windows.Controls.Primitives.Popup;
namespace Triangles
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/result"] = _ => {
        TriangleVariables myTriangleVariables = new TriangleVariables();

        int side1;
        int side2;
        int side3;

        bool ifSuccess = int.TryParse(Request.Query["side1"], out side1);
        bool ifSuccess1 = int.TryParse(Request.Query["side2"], out side2);
        bool ifSuccess2 = int.TryParse(Request.Query["side3"], out side3);

        if (!int.TryParse(Request.Query["side1"], out side1) || !int.TryParse(Request.Query["side2"], out side2) || !int.TryParse(Request.Query["side3"], out side3)) {
          Popup codePopup = new Popup();
          TextBlock popupText = new TextBlock();
          popupText.Text = "Popup Text";
          return View["error.cshtml"];
        }
        else
        {
        myTriangleVariables.CheckType(side1, side2, side3);
        // MessageBox.show("ERROR MESSAGE");

          return View["result.cshtml", myTriangleVariables];
        }
      };
    }
  }
}
