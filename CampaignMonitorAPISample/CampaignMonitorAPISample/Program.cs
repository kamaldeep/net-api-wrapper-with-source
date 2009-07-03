using System;
using System.Collections.Generic;
using System.Text;

using CampaignMonitorAPIWrapper;

namespace CampaignMonitorAPISample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Subscriber. operations
            //Subscriber.Add();
            //Subscriber.AddWithCustomFields();
            //Subscriber.Unsubscribe();
            #endregion

            #region Subscribers. operations
            //Subscribers.GetActive();
            //Subscribers.GetBounced();
            //Subscribers.GetUnsubscribed();
            //Subscribers.GetIsSubscribed();
            //Subscribers.GetSingleSubscriber();
            #endregion

            #region Campaign. operations
            //Campaign.Create();
            //Campaign.Send();
            //Campaign.GetSummary();
            //Campaign.GetLists();
            //Campaign.GetOpens();
            //Campaign.GetBounces();
            //Campaign.GetSubscriberClicks();
            //Campaign.GetUnsubscribes();
            //Campaign.Delete();
            #endregion

            #region List. operations
            //List.CreateCustomField();
            //List.GetCustomFields();
            //List.DeleteCustomField();
            //List.Create();
            //List.Update();
            //List.GetDetail();
            //List.Delete();
            #endregion

            #region Client. operations
            //Client.Create();
            //Client.UpdateBasics();
            //Client.UpdateAccessAndBilling();
			//Client.GetDetail();
            //Client.Delete();
            //Client.GetCampaigns();
            //Client.GetLists();
            //Client.GetSegments();
            //Client.GetSuppressionList();
            //Client.GetTemplates();
            #endregion

            #region User. operations
            //User.GetClients();
            //User.GetSystemDate();
            //User.GetTimezones();
            //User.GetCountries();
            #endregion

            #region Template. operations
            //Template.Create();
            //Template.GetDetail();
            //Template.Update();
            //Template.Delete();
            #endregion

            Console.ReadLine(); // pause
        }

        
    }
}
