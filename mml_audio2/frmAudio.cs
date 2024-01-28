using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mml_audio2
{
    public partial class frmAudio : Form
    {
        WaveOut wOut = new WaveOut();
        WaveStream fileReader;
        long time;
        public frmAudio()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Audio|*.mp3";
            o.Title = "Open Audio File";

            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                waveViewer1.WaveStream = new NAudio.Wave.Mp3FileReader(o.FileName);
                fileReader = new Mp3FileReader(o.FileName);


                lstProperties.Items.Add(
                    new ListViewItem(new string[] { 
                        "File Name", 
                        o.FileName 
                    })
                    );

                lstProperties.Items.Add(
                    new ListViewItem(new string[] { 
                        "TotalTime", 
                        fileReader.TotalTime.ToString() 
                    })
                    );


                lstProperties.Items.Add(
                    new ListViewItem(new string[] { 
                        "BitsPerSample", 
                        fileReader.WaveFormat.BitsPerSample.ToString() 
                    })
                    );


                lstProperties.Items.Add(
                    new ListViewItem(new string[] { 
                        "SampleRate", 
                        fileReader.WaveFormat.SampleRate.ToString() 
                    })
                    );

                lstProperties.Items.Add(
                    new ListViewItem(new string[] { 
                        "Channels", 
                        fileReader.WaveFormat.Channels.ToString() 
                    })
                    );




            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Play";
            fileReader.Seek(0, System.IO.SeekOrigin.Begin);
            wOut.Init(fileReader);
            wOut.Play();
            timer1.Enabled = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Stop";
            wOut.Stop();
            time = timer1.Interval;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = fileReader.CurrentTime.ToString();
            hScrollBar1.Value =
                (int)(hScrollBar1.Maximum * fileReader.Position / fileReader.Length);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            fileReader.Position =
                fileReader.Length * hScrollBar1.Value / hScrollBar1.Maximum;
        }


        private short[] ReadData(WaveStream ws)
        {
            byte[] bytes = new byte[ws.Length];
            ws.Position = 0;
            ws.Read(bytes, 0, bytes.Length);

            short[] data = new short[bytes.Length / 2];
            for (int i = 0; i < data.Length; i++)
                data[i] = (short)(bytes[2 * i] + (bytes[2 * i + 1] << 8));
            return data;
        }

        private void WriteData(short[] data)
        {
            byte[] bytes = new byte[data.Length * 2];
            for (int i = 0; i < data.Length; i++)
            {
                bytes[2 * i] = (byte)(data[i] % 256);
                bytes[2 * i + 1] = (byte)(data[i] >> 8);
            }

            //fileReader.Write(bytes, 0, bytes.Length);
            WaveStream w = new RawSourceWaveStream(
                bytes, 0, bytes.Length,
                fileReader.WaveFormat);
            fileReader = w;
            
        }

        private void volumeDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            short[] data = ReadData(fileReader);
          

            for (int i = 0; i < data.Length; i++)
                data[i] = (short)((data[i] * .5-(int.Parse(volumeDownRatio.Text)/100 )) );

            WriteData(data);
        }

        private void volumeUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            short[] data = ReadData(fileReader);
            short[] newData = new short[data.Length / 2];

            for (int i = 0; i < data.Length; i++)
            {
                int d = (int)(data[i] * 1.8);
                if (d < short.MaxValue && d > short.MinValue)
                    data[i] = (short)d;
                else
                    if (data[i] > 0)
                        data[i] = (short)(data[i] + (short.MaxValue - data[i]) * ((int.Parse(volumeUpRatio.Text))/100));
                    else
                        data[i] = (short)(data[i] + (short.MinValue - data[i]) * ((int.Parse(volumeUpRatio.Text)) / 100));

            }
            WriteData(data);
        }

        private void fasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            short[] data = ReadData(fileReader);
            short[] newData = new short[data.Length / 2];

            for (int i = 0; i < newData.Length; i += fileReader.WaveFormat.Channels)
            {
                newData[i] = data[i * 2];
                newData[i + 1] = data[i * 2 + 1];
            }

            WriteData(newData);
        }

        private void slowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            short[] data = ReadData(fileReader);
            short[] newData = new short[data.Length * 2];
            int f1 = fileReader.WaveFormat.Channels;
            int rate = Int32.Parse(TxtSlow.Text);
            int channel = fileReader.WaveFormat.Channels;

            for (int i = 0; i < newData.Length; i += fileReader.WaveFormat.Channels)
            {
                int j = i / rate / channel * f1;
                newData[i] = data[j];
                newData[i + 1] = data[j + 1];
            }

            WriteData(newData);
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            short[] data = ReadData(fileReader);
            short[] newData = data.Reverse().ToArray();
            for (int i = 0; i < newData.Length; i += fileReader.WaveFormat.Channels)
            {

            }


            WriteData(newData);

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void mergToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Audio|*.mp3";
            o.Title = "Open Audio File";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WaveStream newfile = new Mp3FileReader(o.FileName);
                if (newfile.WaveFormat.Channels != fileReader.WaveFormat.Channels)
                {
                    MessageBox.Show("channels");
                    return;
                }
                else if (newfile.WaveFormat.BitsPerSample != fileReader.WaveFormat.BitsPerSample)
                {
                    MessageBox.Show("BitsPerSample");
                    return;
                }
                else if (newfile.WaveFormat.SampleRate != fileReader.WaveFormat.SampleRate)
                {
                    MessageBox.Show("SampleRate");
                    return;
                }
                short[] data1 = ReadData(fileReader);
                short[] data2= ReadData(newfile);
                short[] newdata = new short[Math.Max(data1.Length , data2.Length)];
                for(int i = 0; i < newdata.Length; i++)
                {
                    //if (i<)
                    if (i >= data1.Length)
                    {
                        newdata[i] = data2[i];
                    }
                    else if(i>= data2.Length)
                    {
                        newdata[i] = data1[i];
                    }
                    else
                    newdata[i] =(short)( (data1[i] + data2[i])/2);//لتحديد نسبة الدمج بضرب الاول برقم والتاني بمكل الرقم للواحد



                }
                WriteData(newdata);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Audio|*.wav";
            f.Title = "Save Audio File";
            if (f.ShowDialog() == DialogResult.OK)
            {
                WaveFileWriter.CreateWaveFile(f.FileName, fileReader);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void waveViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "resume";
            fileReader.Seek(time, System.IO.SeekOrigin.Current);
            wOut.Init(fileReader);
            wOut.Play();
            timer1.Enabled = true;
        }

        private void lstProperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deepMergToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            o.Title = "Open Audio File";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WaveStream newfile = new Mp3FileReader(o.FileName);
                if (newfile.WaveFormat.Channels != fileReader.WaveFormat.Channels ||
                    newfile.WaveFormat.SampleRate != fileReader.WaveFormat.SampleRate)
                {
                    int outRate = fileReader.WaveFormat.SampleRate;

                    var outFile = @"MF1.wav";

                    var outFormat = new WaveFormat(outRate, fileReader.WaveFormat.Channels);
                    var resampler = new WaveFormatConversionStream(outFormat, newfile);

                    WaveFileWriter.CreateWaveFile(outFile, resampler);

                    var ratio = (Int32.Parse(mergRatio.Text) / 10);
                    var rt = 1 - ratio;
                    WaveStream outfiled = new WaveFileReader(outFile);
                    short[] data11 = ReadData(fileReader);
                    short[] data22 = ReadData(outfiled);
                    short[] newdata2 = new short[Math.Max(data11.Length, data22.Length)];
                    for (int i = 0; i < newdata2.Length; i++)
                    {
                        //if (i<)
                        if (i >= data11.Length)
                        {
                            newdata2[i] = data22[i];
                        }
                        else if (i >= data22.Length)
                        {
                            newdata2[i] = data11[i];
                        }
                        else
                            newdata2[i] = (short)(((data11[i] * ratio) + (data22[i] * rt)) / 2);//لتحديد نسبة الدمج بضرب الاول برقم والتاني بمكل الرقم للواحد



                    }

                    WriteData(newdata2);



                }
                else if (newfile.WaveFormat.BitsPerSample != fileReader.WaveFormat.BitsPerSample)
                {
                    MessageBox.Show("BitsPerSample");
                    return;
                }
                else
                {
                    var ratio = (Int32.Parse(mergRatio.Text) / 10);
                    var rt = 1 - ratio;
                    short[] data1 = ReadData(fileReader);
                    short[] data2 = ReadData(newfile);
                    short[] newdata = new short[Math.Max(data1.Length, data2.Length)];
                    for (int i = 0; i < newdata.Length; i++)
                    {
                        //if (i<)
                        if (i >= data1.Length)
                        {
                            newdata[i] = data2[i];
                        }
                        else if (i >= data2.Length)
                        {
                            newdata[i] = data1[i];
                        }
                        else
                            newdata[i] = (short)(((data1[i] * ratio) + (data2[i]* rt)) / 2);//لتحديد نسبة الدمج بضرب الاول برقم والتاني بمكل الرقم للواحد



                    }
                    WriteData(newdata);
                }
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void mergAtTimeBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Audio|*.mp3";
            o.Title = "Open Audio File";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WaveStream newfile = new Mp3FileReader(o.FileName);
                if (newfile.WaveFormat.Channels != fileReader.WaveFormat.Channels)
                {
                    MessageBox.Show("channels");
                    return;
                }
                else if (newfile.WaveFormat.BitsPerSample != fileReader.WaveFormat.BitsPerSample)
                {
                    MessageBox.Show("BitsPerSample");
                    return;
                }
                else if (newfile.WaveFormat.SampleRate != fileReader.WaveFormat.SampleRate)
                {
                    MessageBox.Show("SampleRate");
                    return;
                }
                short[] data1 = ReadData(fileReader);
            
                WaveOutEvent waveOutEvent = new WaveOutEvent();
                WaveOffsetStream waveOffsetStream = new WaveOffsetStream(newfile,     TimeSpan.FromSeconds(float.Parse(mergTime.Text) ), TimeSpan.Zero, TimeSpan.FromSeconds(180));
                short[] data2 = ReadData(waveOffsetStream);
                    short[] newdata = new short[Math.Max(data1.Length, data2.Length)];
                    for (int i = 0; i < newdata.Length; i++)
                    {
                  
                        if (i >= data1.Length)
                        {
                            newdata[i] = data2[i];
                        }
                        else if (i >= data2.Length)
                        {
                            newdata[i] = data1[i];
                        }
                        else
                            newdata[i] = (short)((data1[i] + data2[i]) / 2);//لتحديد نسبة الدمج بضرب الاول برقم والتاني بمكل الرقم للواحد
                  


                    }
                    WriteData(newdata);

                
            }

        }

        private void channelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var silence = new SilenceProvider(new WaveFormat(44100, 1));
            var waveProvider = new MultiplexingWaveProvider(new IWaveProvider[] { silence, fileReader }, 2);
            waveProvider.ConnectInputToOutput(0, 1);
            waveProvider.ConnectInputToOutput(1, 0);
            fileReader.Seek(0, System.IO.SeekOrigin.Begin);
            wOut.Init(waveProvider);
            wOut.Play();
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var silence = new SilenceProvider(new WaveFormat(44100, 1));
            var waveProvider = new MultiplexingWaveProvider(new IWaveProvider[] {  silence, fileReader }, 2);
            waveProvider.ConnectInputToOutput(0, 0);
            waveProvider.ConnectInputToOutput(1, 1);
            fileReader.Seek(0, System.IO.SeekOrigin.Begin);
            wOut.Init(waveProvider);
            wOut.Play();
        }
    }
}
