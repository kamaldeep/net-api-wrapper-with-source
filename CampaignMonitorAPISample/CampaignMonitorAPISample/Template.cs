using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignMonitorAPISample
{
    public class Template
    {
        internal static void Create()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string clientID = "xxxxxxxxxxxClientIDxxxxxxxxxxxxx";
            string templateName = "Test Template Name";
            string htmlPageUrl = "http://notarealdomain.com/templates/test/index.html";
            string zipFileUrl = "http://notarealdomain.com/templates/test/images.zip";
            string screenshotUrl = "http://notarealdomain.com/templates/test/screenshot.jpg";

            var result = CampaignMonitorAPIWrapper.Template.Create(apiKey, clientID, templateName, htmlPageUrl, zipFileUrl, screenshotUrl);

            if (result.Code != 0)
                Console.WriteLine("Error creating template : " + result.Code.ToString() + " - " + result.Message);
            else
                Console.WriteLine("TemplateID : " + result.ReturnObject);
        }

        internal static void GetDetail()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string templateID = "xxxxxxxxxxxTemplateIDxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.Template.GetDetail(apiKey, templateID);

            if (result.Code != 0)
                Console.WriteLine("Error retrieving template details : " + result.Code.ToString() + " - " + result.Message);
            else
            {
                Console.WriteLine("Template ID : " + result.ReturnObject.TemplateID);
                Console.WriteLine("Template Name : " + result.ReturnObject.Name);
                Console.WriteLine("Template Preview URL : " + result.ReturnObject.PreviewURL);
                Console.WriteLine("Template Screenshot URL : " + result.ReturnObject.ScreenshotURL);
            }
        }

        internal static void Update()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string templateID = "xxxxxxxxxxxTemplateIDxxxxxxxxxxxxx";

            string templateName = "Updated Template Name";
            string htmlPageUrl = "http://notarealdomain.com/templates/test/new_index.html";
            string zipFileUrl = "http://notarealdomain.com/templates/test/new_images.zip";
            string screenshotUrl = "http://notarealdomain.com/templates/test/new_screenshot.jpg";

            var result = CampaignMonitorAPIWrapper.Template.Update(apiKey, templateID, templateName, htmlPageUrl, zipFileUrl, screenshotUrl);

            if (result.Code != 0)
                Console.WriteLine("Error updating template : " + result.Code.ToString() + " - " + result.Message);
            else
                Console.WriteLine("The template was successfully updated.");
        }

        internal static void Delete()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string templateID = "xxxxxxxxxxxTemplateIDxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.Template.Delete(apiKey, templateID);

            if (result.Code != 0)
                Console.WriteLine("Error deleting template : " + result.Code.ToString() + " - " + result.Message);
            else
                Console.WriteLine("The template was successfully deleted.");
        }
    }
}
