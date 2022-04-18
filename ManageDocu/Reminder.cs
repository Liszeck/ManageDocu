using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageDocu
{
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
            GoogleApi();
        }

        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";
        private void GoogleApi() 
        {
;
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret_200074212393-bi4dccg61rhl1hlf7vv03ok1u35o5a5u.apps.googleusercontent.com.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 5;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            if (events.Items != null && events.Items.Count > 0)
            {
                CalendarEvents.Text = "";
                foreach (var eventItem in events.Items)
                {
                    CalendarEvents.Text += eventItem.Summary + " " + eventItem.Start.DateTime + Environment.NewLine;
                }
            }
            else
            {
                CalendarEvents.Text = "Hurray! There is no active document with deadline!";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetEvents_Tick(object sender, EventArgs e)
        {
            GoogleApi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://calendar.google.com/");
        }
    }
}
