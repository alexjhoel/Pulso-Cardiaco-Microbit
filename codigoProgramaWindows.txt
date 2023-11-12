using System.Drawing;
using System.IO.Ports;
using System.Numerics;

namespace RadarMicroBit
{
    public partial class Main : Form
    {
        SerialPort serialPort;

        List<int> points;

        int bitmapWidth = 0;
        int bitmapHeight = 0;

        int readIndex = 0;

        int modulation = 1;
        int longi = 1;
        int offsetGraph = 0;

        public Main()
        {
            InitializeComponent();
            radar.Image = new Bitmap(radar.Width, radar.Height);
            points = new List<int>();
            points.Add(radar.Height);
            serialPort = new SerialPort(portName.Text, 115200, Parity.None, 8, StopBits.One);
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (startStop.BackColor == Color.Red)
            {
                serialPort.Close();
                startStop.BackColor = Color.White;
            }
            else
            {
                try
                {
                    serialPort = new SerialPort(portName.Text, 115200, Parity.None, 8, StopBits.One);
                    serialPort.Open();
                    serialPort.DataReceived += SerialPort_DataReceived;
                    startStop.BackColor = Color.Red;
                }
                catch (Exception ex)
                {

                }
            }


        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                int reading = int.Parse(serialPort.ReadLine());
                Console.WriteLine(reading);
                //outText.Text += "\n" + reading;
                //List<string> data = serialPort.ReadLine().Split(":").ToList();
                readIndex++;
                if (readIndex > radar.Width / longi)
                {
                    readIndex = 0;
                }
                if (readIndex > points.Count - 1)
                {
                    for (int i = points[points.Count - 1]; i < readIndex; i++)
                    {
                        points.Add(reading);
                    }
                }
                else
                {
                    points[readIndex] = reading;
                }

                drawRadar();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void radar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void drawRadar()
        {

            bitmapWidth = radar.Width * 1;
            bitmapHeight = radar.Height * 1;

            Bitmap bitmap = new Bitmap(bitmapWidth, bitmapHeight, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            Graphics graphics = Graphics.FromImage(bitmap);

            using (Pen selPen = new Pen(Color.Green, 2))
            {


                for (int i = 1; i < points.Count; i++)
                {
                    int y1 = radar.Height - (points[i - 1] * (modulation / 5)) + offsetGraph * modulation;
                    int y2 = radar.Height - (points[i] * (modulation / 5)) + offsetGraph * modulation;
                    graphics.DrawLine(selPen, (i - 1) * longi, y1, i * longi, y2);
                }
            };

            radar.Image = bitmap;
            radar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void modulacion_Scroll(object sender, EventArgs e)
        {
            modulation = modulacion.Value;
        }

        private void offset_Scroll(object sender, EventArgs e)
        {

        }

        private void outText_Click(object sender, EventArgs e)
        {

        }

        private void readarDrawing_Tick(object sender, EventArgs e)
        {

            if (serialPort.IsOpen && readIndex < points.Count) outText.Text = points[readIndex].ToString() + "\n" + outText.Text;
        }

        private void offset_ValueChanged(object sender, EventArgs e)
        {
            offsetGraph = (int)offset.Value;
        }

        private void longitud_Scroll(object sender, EventArgs e)
        {
            longi = (int)longitud.Value;
        }
    }
}