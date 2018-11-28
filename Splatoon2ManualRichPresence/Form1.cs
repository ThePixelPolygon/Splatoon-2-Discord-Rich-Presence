using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;

namespace Splatoon2ManualRichPresence
{
    public partial class Form1 : Form
    {
        public DiscordRpcClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize Rich Presence Client
            Initialize();
            this.FormClosing += new FormClosingEventHandler(Form1_Closing);
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            //Disposes the client when the form closes.
            client.Dispose();
        }

        void Initialize()
        {
            //Initialize Client
            client = new DiscordRpcClient("459809227339202570");
            //Logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update from user {0}", e.Presence);
            };
            client.Initialize();
            
        }

        //Status
        string status = null;
        //Details
        string state = null;
        //Small image key. Changes depending on the multiplayer mode selected.
        string smallImageKey = null;
        string smallImageText = null;
        //Used to set the end time
        DateTime endtime = DateTime.Now;
        private void startbtn_Click(object sender, EventArgs e)
        {
            state = stage.Text;
            //Did the user select Regular Battle?
            if (reRad.Checked)
            {
                //Set end time to 3 minutes from DateTime.Now
                endtime = DateTime.UtcNow.AddMinutes(3);
                smallImageKey = "regular";
                smallImageText = "Regular Battle";
                //Set status to turf war
                status = "Turf War";
            }
            //Did the user select Ranked or League Battle?
            else if (raRad.Checked || leRad.Checked)
            {
                //Set end time to 5 minutes from epoch time
                endtime = DateTime.UtcNow.AddMinutes(5);
                if (raRad.Checked)
                {
                    //Sets small image key to ranked battle icon
                    smallImageKey = "ranked";
                    smallImageText = "Ranked Battle";
                }
                else
                {
                    //Sets small image key to league battle icon
                    smallImageKey = "league";
                    smallImageText = "League Battle";
                }
                //Changes details to Splat Zones if selected
                if(szRad.Checked)
                {
                    status = "Splat Zones";
                }
                //changed details to Tower Control if selected
                else if(tcRad.Checked)
                {
                    status = "Tower Control";
                }
                //Changes details to Clam Blitz if selected
                else if(cbRad.Checked)
                {
                    status = "Clam Blitz";
                }
                //Changes details to Rainmaker if selected
                else if(rmRad.Checked)
                {
                    status = "Rainmaker";
                }

            }
            //Did the user select Salmon Run shift?
            else if (srRad.Checked)
            {
                //Set end time to 100 seconds from epoch time.
                endtime = DateTime.UtcNow.AddSeconds(100);
                smallImageKey = "";
                smallImageText = "";
                state = "Working Salmon Run Shift";
                status = "Wave details coming soon!";
            }
            updatePresence(status, state);
            
        }
        void updatePresence(String details, String state)
        {
            client.UpdateDetails(status);
            client.UpdateState(state);
            client.UpdateLargeAsset("cover");
            client.UpdateSmallAsset(smallImageKey, smallImageText);
            client.UpdateStartTime(DateTime.UtcNow);
            client.UpdateEndTime(endtime);
            client.Invoke();
        }
        //Searching for Players
        private void searchbtn_Click(object sender, EventArgs e)
        {
            client.UpdateState("Searching...");
            client.UpdateDetails("");
            client.UpdateClearTime();
            client.UpdateLargeAsset("cover");
            client.UpdateSmallAsset(null, null);
            client.Invoke();
        }
        //In Lobby
        private void idlebtn_Click(object sender, EventArgs e)
        {
            client.UpdateState("In Lobby");
            client.UpdateDetails("");
            client.UpdateClearTime();
            client.UpdateLargeAsset("cover");
            client.UpdateSmallAsset(null, null);
            client.Invoke();
        }
        //Match End
        private void endbtn_Click(object sender, EventArgs e)
        {
            client.UpdateState("Viewing Results");
            client.UpdateDetails("");
            client.UpdateClearTime();
            client.UpdateLargeAsset("cover");
            client.Invoke();
        }
    }
}
