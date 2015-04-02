using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace GACD_StackOverflow_Project.Validations
{
    public class Mailgun
    {
        public static RestResponse SendSimpleMessage(string to,string subject,string message)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator = new HttpBasicAuthenticator("api", "key-3d12136a2c806206ddb9bb84b8b08850");
            RestRequest request = new RestRequest();
            request.AddParameter("domain", "sandbox9da1ceb37d5e4ee19f83e115c08a073d.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "MiniStackOverflow <postmaster@sandbox9da1ceb37d5e4ee19f83e115c08a073d.mailgun.org>");
            request.AddParameter("to", "<" + to + ">");
            request.AddParameter("subject", subject);
            request.AddParameter("text", message);
            request.Method = Method.POST;
            return (RestResponse)client.Execute(request);
        }
    }
}