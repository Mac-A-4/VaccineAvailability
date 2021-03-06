using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using COVID21;

namespace COVID21GUI {
    public partial class COVID21GUI : Form {
        public COVID21GUI() {
            InitializeComponent();
        }

        private void SetupIndustrySelect() {
            foreach (Industry x in Enum.GetValues(typeof(Industry))) {
                industrySelect.Items.Add(IndustryName.Get(x));
            }
        }

        private void SetupCountySelect() {
            foreach (County x in Enum.GetValues(typeof(County))) {
                countySelect.Items.Add(CountyName.Get(x));
            }
        }

        private void COVID21GUI_Load(object sender, EventArgs e) {
            SetupIndustrySelect();
            SetupCountySelect();
        }

        private void addButton_Click(object sender, EventArgs e) {
            int result;
            if (int.TryParse(zipInput.Text, out result)) {
                if (!zipList.Items.Contains(result)) {
                    zipList.Items.Add(result);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e) {
            if (zipList.SelectedIndex != -1) {
                zipList.Items.RemoveAt(zipList.SelectedIndex);
            }
        }

        private Timer updateInterval;
        private Task currentTask;
        private VaccineSearch currentSearch;
        private int currentSize;
        private DateTime currentStart;

        private void UpdateSearch() {
            var newSearch = new VaccineSearch(
                Convert.ToInt32(ageSelect.Value),
                IndustryName.GetValue(industrySelect.SelectedItem.ToString()),
                CountyName.GetValue(countySelect.SelectedItem.ToString()),
                zipList.Items.OfType<int>().ToArray()
                );
            var newSize = newSearch.GetAppointmentCount();
            if (newSize > currentSize) {
                SystemSounds.Exclamation.Play();
            }
            currentSearch = newSearch;
            currentSize = newSize;
        }

        private void StartUpdateSearch() {
            currentStart = DateTime.Now;
            currentTask = Task.Run(() => UpdateSearch());
        }

        private void UpdateOutputList() {
            outputList.BeginUpdate();
            outputList.Items.Clear();
            foreach (var x in currentSearch.Locations) {
                outputList.Items.Add(x);
            }
            outputList.EndUpdate();
        }

        private void OnUpdate(object sender, EventArgs e) {
            if (currentTask.IsCompleted) {
                UpdateOutputList();
                StartUpdateSearch();
                progressBar.Value = 0;
            }
            timeLabel.Text = string.Format("{0}s", (DateTime.Now - currentStart).TotalSeconds.ToString("0.00"));
            progressBar.PerformStep();
        }

        private void StartSearch() {
            outputList.Items.Clear();
            currentSize = 0;
            StartUpdateSearch();
            updateInterval = new Timer();
            updateInterval.Interval = 16;
            updateInterval.Tick += new EventHandler(OnUpdate);
            updateInterval.Enabled = true;
            ageSelect.Enabled = false;
            industrySelect.Enabled = false;
            countySelect.Enabled = false;
            zipInput.Enabled = false;
            addButton.Enabled = false;
            removeButton.Enabled = false;
            zipList.Enabled = false;
        }

        private void StopSearch() {
            progressBar.Value = 0;
            updateInterval.Enabled = false;
            ageSelect.Enabled = true;
            industrySelect.Enabled = true;
            countySelect.Enabled = true;
            zipInput.Enabled = true;
            addButton.Enabled = true;
            removeButton.Enabled = true;
            zipList.Enabled = true;
            timeLabel.Text = "";
        }

        private static bool searching = false;

        private void searchButton_Click(object sender, EventArgs e) {
            if (searching) {
                StopSearch();
                searchButton.Text = "Search";
                searching = false;
            }
            else {
                StartSearch();
                searchButton.Text = "Stop";
                searching = true;
            }
        }
    }
}
