namespace WindowsFormsApplication1
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.bClear = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.tbTX = new System.Windows.Forms.RichTextBox();
            this.tbRX = new System.Windows.Forms.RichTextBox();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.first1check = new System.Windows.Forms.Button();
            this.first1alert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(239, 367);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(164, 41);
            this.bClear.TabIndex = 0;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(643, 12);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 1;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tbTX
            // 
            this.tbTX.Location = new System.Drawing.Point(12, 12);
            this.tbTX.Name = "tbTX";
            this.tbTX.Size = new System.Drawing.Size(612, 327);
            this.tbTX.TabIndex = 2;
            this.tbTX.Text = "";
            this.tbTX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTX_KeyPress);
            // 
            // tbRX
            // 
            this.tbRX.Location = new System.Drawing.Point(643, 82);
            this.tbRX.Name = "tbRX";
            this.tbRX.Size = new System.Drawing.Size(91, 27);
            this.tbRX.TabIndex = 3;
            this.tbRX.Text = "";
            // 
            // mySerialPort
            // 
            this.mySerialPort.PortName = "COM5";
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
            // 
            // first1check
            // 
            this.first1check.Location = new System.Drawing.Point(659, 201);
            this.first1check.Name = "first1check";
            this.first1check.Size = new System.Drawing.Size(75, 23);
            this.first1check.TabIndex = 5;
            this.first1check.Text = "Dev 1 Ch";
            this.first1check.UseVisualStyleBackColor = true;
            this.first1check.Click += new System.EventHandler(this.first1check_Click);
            // 
            // first1alert
            // 
            this.first1alert.Location = new System.Drawing.Point(659, 230);
            this.first1alert.Name = "first1alert";
            this.first1alert.Size = new System.Drawing.Size(74, 21);
            this.first1alert.TabIndex = 10;
            this.first1alert.Text = "Dev 1 Alert";
            this.first1alert.UseVisualStyleBackColor = true;
            this.first1alert.Click += new System.EventHandler(this.first1alert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(683, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 26);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 477);
            this.Controls.Add(this.first1alert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.first1check);
            this.Controls.Add(this.tbRX);
            this.Controls.Add(this.tbTX);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.bClear);
            this.Name = "Form11";
            this.Text = "Form11";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.RichTextBox tbTX;
        private System.Windows.Forms.RichTextBox tbRX;
        private System.Windows.Forms.Button first1check;
        private System.Windows.Forms.Button first1alert;
        protected System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

