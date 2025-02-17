using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Project
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            ShowMapScreen();

            timer1.Interval = 10000; //10 seconds per tick
            timer1.Start();
        }

        private void ShowMapScreen()
        {
            btnTown.Visible = true;
            btnForest.Visible = true;
            btnMountain.Visible = true;

            btnReturnToMap.Visible = false;
        }

        private void ShowLocationScreen()
        {
            btnTown.Visible = false;
            btnForest.Visible = false;
            btnMountain.Visible = false;

            btnReturnToMap.Visible = true;
        }

        private void lblCurrentLocation_Click(object sender, EventArgs e)
        {

        }

        private void btnTown_Click(object sender, EventArgs e)
        {
            gameTime = gameTime.AddHours(2);
            lblInGameTime.Text = "Time " + gameTime.ToString("hh:mm tt");
            lblCurrentLocation.Text = "You are currently in: Town";

            // NPCs visible
            btnShopkeeper.Visible = true;
            lblNPCInteraction.Text = "You see a Shopkeeper here.";

            ShowLocationScreen();
        }

        private void btnForest_Click(object sender, EventArgs e)
        {
            gameTime = gameTime.AddHours(2);
            lblInGameTime.Text = "Time " + gameTime.ToString("hh:mm tt");
            lblCurrentLocation.Text = "You are currently in: Forest";

            lblNPCInteraction.Text = "";

            ShowLocationScreen();
        }

        private void btnMountain_Click(object sender, EventArgs e)
        {
            gameTime = gameTime.AddHours(2);
            lblInGameTime.Text = "Time " + gameTime.ToString("hh:mm tt");
            lblCurrentLocation.Text = "You are currently in: Mountain";

            lblNPCInteraction.Text = "";

            ShowLocationScreen();
        }

        private DateTime gameTime = DateTime.Parse("12:00 PM");

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameTime = gameTime.AddMinutes(1);      // Increase the game time by 1 minute every second.
            lblInGameTime.Text = "Time: " + gameTime.ToString("hh:mm tt");
        }

        private void btnShopkeeper_Click_1(object sender, EventArgs e)
        {
            lblNPCInteraction.Text = "Shopkeeper: Welcome to my shop!";
        }

        private void btnReturnToMap_Click(object sender, EventArgs e)
        {
            lblCurrentLocation.Text = "You are currently viewing the Map.";

            ShowMapScreen();
        }
    }
}
