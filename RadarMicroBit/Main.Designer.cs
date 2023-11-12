namespace RadarMicroBit
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            startStop = new Button();
            radar = new PictureBox();
            readarDrawing = new System.Windows.Forms.Timer(components);
            outText = new Label();
            panel1 = new Panel();
            portName = new TextBox();
            label1 = new Label();
            modulacion = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            offset = new NumericUpDown();
            label4 = new Label();
            longitud = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)radar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modulacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)offset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)longitud).BeginInit();
            SuspendLayout();
            // 
            // startStop
            // 
            startStop.BackColor = Color.White;
            startStop.Location = new Point(12, 274);
            startStop.Name = "startStop";
            startStop.Size = new Size(75, 23);
            startStop.TabIndex = 0;
            startStop.Text = "Start";
            startStop.UseVisualStyleBackColor = false;
            startStop.Click += button1_Click;
            // 
            // radar
            // 
            radar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radar.BackColor = Color.Black;
            radar.Location = new Point(12, 12);
            radar.Name = "radar";
            radar.Size = new Size(641, 256);
            radar.TabIndex = 3;
            radar.TabStop = false;
            radar.Paint += radar_Paint;
            // 
            // readarDrawing
            // 
            readarDrawing.Enabled = true;
            readarDrawing.Interval = 10;
            readarDrawing.Tick += readarDrawing_Tick;
            // 
            // outText
            // 
            outText.AutoSize = true;
            outText.Location = new Point(3, 4);
            outText.Name = "outText";
            outText.Size = new Size(107, 30);
            outText.TabIndex = 4;
            outText.Text = "Esperando órdenes\r\n\r\n";
            outText.Click += outText_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(outText);
            panel1.Location = new Point(12, 362);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 80);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // portName
            // 
            portName.Location = new Point(144, 275);
            portName.Name = "portName";
            portName.Size = new Size(54, 23);
            portName.TabIndex = 7;
            portName.Text = "COM3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 278);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "Puerto:";
            // 
            // modulacion
            // 
            modulacion.Location = new Point(267, 274);
            modulacion.Maximum = 128;
            modulacion.Minimum = 1;
            modulacion.Name = "modulacion";
            modulacion.Size = new Size(170, 45);
            modulacion.TabIndex = 8;
            modulacion.Value = 1;
            modulacion.Scroll += modulacion_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 278);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Amplitud";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 278);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 11;
            label3.Text = "Offset:";
            // 
            // offset
            // 
            offset.Location = new Point(491, 278);
            offset.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            offset.Name = "offset";
            offset.Size = new Size(120, 23);
            offset.TabIndex = 12;
            offset.ValueChanged += offset_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 315);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 14;
            label4.Text = "Longitud";
            // 
            // longitud
            // 
            longitud.Location = new Point(267, 311);
            longitud.Maximum = 15;
            longitud.Minimum = 1;
            longitud.Name = "longitud";
            longitud.Size = new Size(170, 45);
            longitud.TabIndex = 13;
            longitud.Value = 1;
            longitud.Scroll += longitud_Scroll;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 454);
            Controls.Add(label4);
            Controls.Add(longitud);
            Controls.Add(offset);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(modulacion);
            Controls.Add(label1);
            Controls.Add(portName);
            Controls.Add(panel1);
            Controls.Add(radar);
            Controls.Add(startStop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Tu pulso MicroBit";
            Paint += Main_Paint;
            ((System.ComponentModel.ISupportInitialize)radar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)modulacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)offset).EndInit();
            ((System.ComponentModel.ISupportInitialize)longitud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startStop;
        private PictureBox radar;
        private System.Windows.Forms.Timer readarDrawing;
        private Label outText;
        private Panel panel1;
        private Label label1;
        private TextBox portName;
        private TrackBar modulacion;
        private Label label2;
        private Label label3;
        private NumericUpDown offset;
        private Label label4;
        private TrackBar longitud;
    }
}