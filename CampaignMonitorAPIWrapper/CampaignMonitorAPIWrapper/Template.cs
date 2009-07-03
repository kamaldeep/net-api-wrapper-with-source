using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignMonitorAPIWrapper
{
    public class Template
    {
        public static Result<string> Create(string apiKey, string clientID, string templateName, string htmlPageUrl, string zipFileUrl, string screenshotUrl)
        {
            CampaignMonitorAPI.api api = new CampaignMonitorAPI.api();

            object o = api.CreateTemplate(apiKey, clientID, templateName, htmlPageUrl, zipFileUrl, screenshotUrl);

            if (o is CampaignMonitorAPI.Result)
                return new Result<string>((CampaignMonitorAPI.Result)o, null);
            else
                return new Result<string>(0, "Success", Convert.ToString(o));
        }

        public static Result<CampaignMonitorAPI.Template> GetDetail(string apiKey, string templateID)
        {
            CampaignMonitorAPI.api api = new CampaignMonitorAPI.api();

            object o = api.GetTemplateDetail(apiKey, templateID);

            if (o is CampaignMonitorAPI.Result)
                return new Result<CampaignMonitorAPI.Template>((CampaignMonitorAPI.Result)o, null);
            else
                return new Result<CampaignMonitorAPI.Template>(0, "Success", (CampaignMonitorAPI.Template)o);
        }

        public static Result<string> Update(string apiKey, string templateID, string templateName, string htmlPageUrl, string zipFileUrl, string screenshotUrl)
        {
            CampaignMonitorAPI.api api = new CampaignMonitorAPI.api();

            object o = api.UpdateTemplate(apiKey, templateID, templateName, htmlPageUrl, zipFileUrl, screenshotUrl);

            return new Result<string>((CampaignMonitorAPI.Result)o, null);
        }

        public static Result<string> Delete(string apiKey, string templateID)
        {
            CampaignMonitorAPI.api api = new CampaignMonitorAPI.api();

            object o = api.DeleteTemplate(apiKey, templateID);

            return new Result<string>((CampaignMonitorAPI.Result)o, null);
        }
    }
}
