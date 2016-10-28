using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IF.Lastfm.Core.Api;
using IF.Lastfm.Core.Objects;

namespace ManualScrobble
{
    public partial class frmMain : Form
    {        
        private DateTime _when;
        private readonly Random _random = new Random();
        private string _sessionKey;        
        private LastfmClient _client;

        private readonly LastFmConfig _config;

        private void Log(string text, params object[] args)
            => txtLog.AppendText(string.Format(text + "\n", args));        

        public frmMain()
        {
            InitializeComponent();
            _config = new LastFmConfig();
            CreateSession();
            ResetUI();
        }

        private async void CreateSession()
        {
            try
            {                
                Application.DoEvents();                
                Log("Connecting...");

                
                _client = new LastfmClient(_config.ApiKey, _config.ApiSecret);
                var result = await _client.Auth.GetSessionTokenAsync(_config.Username, _config.Password);
                if(result.Success)
                {
                    Log("OK");
                }
                else
                {
                    Log(result.Status.ToString());
                }
            }
            catch (Exception ex)
            {
                Log("Error: {0}", ex.Message);
            }
        }

        public DateTime When
        {
            get { return _when; }
            set
            {                           
                _when = value; txtWhen.Text = value.ToString();
            }
        }

        public void ResetUI()
        {            
            txtArtist.Text = "";
            txtTrack.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitScrobble();
        }

        private async void SubmitScrobble()
        {
            try
            {
                var scrobbles = new List<Scrobble>
                {
                    new Scrobble(txtArtist.Text, "", txtTrack.Text, _when)
                };
                var result = await _client.Scrobbler.ScrobbleAsync(scrobbles);
                Log("Result: {0} success, {1} ignored", result.AcceptedCount, result.Ignored.Count());
            }
            catch (Exception ex)
            {
                Log("Error: {0}", ex.Message);
            }
        }

        private void btnMinusSecs_Click(object sender, EventArgs e)
        {
            When = When.AddMilliseconds(_random.NextDouble() * -10000);
        }

        private void btnMinus1Min_Click(object sender, EventArgs e)
        {
            When = When.AddMinutes(-1);
        }

        private void btnMinus10Min_Click(object sender, EventArgs e)
        {
            When = When.AddMinutes(-10);
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            When = DateTime.Now;
        }

        private void btnMinusHour_Click(object sender, EventArgs e)
        {
            When = When.AddHours(-1);
        }

        private void btnPlusSecs_Click(object sender, EventArgs e)
        {
            When = When.AddMilliseconds(_random.NextDouble() * 10000);
        }
    }
}
