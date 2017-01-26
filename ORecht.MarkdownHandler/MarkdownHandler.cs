using System;
using System.Web;
using System.IO;

namespace System.Web.Handlers
{
    public class MarkdownHandler : IHttpHandler
    {
        // Override the ProcessRequest method.
        public void ProcessRequest(HttpContext context)
        {
            /*
            context.Response.Write("<H1>This is an HttpHandler Test.</H1>");
            context.Response.Write("<p>Your Browser:</p>");
            context.Response.Write("Type: " + context.Request.Browser.Type + "<br>");
            context.Response.Write("Version: " + context.Request.Browser.Version);
            */
            context.Response.Write("<!DOCTYPE html>");
            context.Response.Write("<html>");
            context.Response.Write("<xmp theme=\"united\" style=\"display:none;\">");

            context.Response.Write(File.ReadAllText(context.Request.PhysicalPath));

            context.Response.Write("</xmp>");
            context.Response.Write("<script src=\"http://strapdownjs.com/v/0.2/strapdown.js\"></script>");
            context.Response.Write("</html>");
        }

        // Override the IsReusable property.
        public bool IsReusable
        {
            get { return true; }
        }
    }
}
