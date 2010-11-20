using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LogBookExtractor
{
    using System.Globalization;
    using System.IO;
    using System.Xml.Serialization;

    public partial class LogBookExtractorFrm : Form
    {
        public LogBookExtractorFrm()
        {
            InitializeComponent();
        }

        private void btnBrowseLog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbInputLog.Text = dlg.FileName;
            }
        }

        private void btnBrowseGpx_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbOutputGpx.Text = dlg.FileName;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbInputLog.Text) || tbOutputGpx.Text.Length == 0)
            {
                MessageBox.Show(
                    "You have to select a log file and gpx output first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StreamReader r = new StreamReader(tbInputLog.Text);
                string s;
                string ps = String.Empty;
                DateTime date = new DateTime();
                TimeSpan entrytime = new TimeSpan();
                DateTime entrydate = new DateTime();
                double latitude = 0;
                double longitude = 0;
                gpxType gpx = new gpxType();
                gpx.creator = "OpenCPN LogBookExtractor";
                gpx.version = "1.1";
                List<trkType> trks = new List<trkType>();
                trkType trk = new trkType();
                trksegType seg = new trksegType();
                List<wptType> trkpts = new List<wptType>();
                int trknum = 0;
                while ((s = r.ReadLine()) != null)
                {
                    while (s.Contains("  "))
                    {
                        s = s.Replace("  ", " ");
                    }
                    if (s.Contains("-------Starting opencpn-------"))
                    {
                        if (trknum > 0)
                        {
                            seg.trkpt = trkpts.ToArray();
                            trk.trkseg[0] = seg;
                            trks.Add(trk);
                        }
                        date = DateTime.Parse(ps.Split(' ')[1]);
                        trk = new trkType
                            {
                                name = String.Format("Logbook {0}", date.ToShortDateString()),
                                number = (trknum + 100).ToString(),
                                trkseg = new trksegType[1]
                            };
                        seg = new trksegType();
                        trkpts.Clear();
                        trknum++;
                    }
                    if (s.Contains("LOGBOOK"))
                    {
                        string[] sa = s.Split(' ');
                        /*
                        if (sa[0].EndsWith(":"))
                        {
                            entrytime = TimeSpan.Parse(sa[0].Substring(0, sa[0].Length - 1));
                        }
                        else
                        {
                            entrytime = TimeSpan.Parse(sa[0]);
                            if (sa[1] == "PM:")
                            {
                                entrytime.Add(new TimeSpan(12, 0, 0));
                            }
                        }
                        */
                        entrydate = DateTime.Parse(sa[3]);
                        entrytime = TimeSpan.Parse(sa[4]);
                        int i = 0;
                        foreach (var s1 in sa)
                        {
                            if (s1 == "Lat")
                            {
                                latitude = double.Parse(sa[i + 1], CultureInfo.InvariantCulture);        
                            }
                            if (s1 == "Lon")
                            {
                                longitude = double.Parse(sa[i + 1], CultureInfo.InvariantCulture);
                            }
                            i++;
                        }
                        trkpts.Add(new wptType() { lat = (decimal)latitude, lon = (decimal)longitude, time = entrydate.Add(entrytime), timeSpecified = true });
                    }
                    ps = s;
                }
                gpx.trk = trks.ToArray();
                XmlSerializer ser = new XmlSerializer(typeof(gpxType));
                StreamWriter w = new StreamWriter(tbOutputGpx.Text);
                ser.Serialize(w, gpx);
                w.Close();
            }
        }
    }
}
