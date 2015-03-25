using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var loc = Request.Params["loc"];
        string location;
        if (loc ==null)
            loc="0";
        switch( loc)
        {
            case "1":
                location = "1 好店";
                break;
            case "2":
                 location = "2 好店";
                 break;
            case "3":
                 location = "3 好店";
                 break;
            default:
                location="网店";
                break;

        }
        
    }
}