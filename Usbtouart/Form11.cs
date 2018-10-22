using System;
using System.Windows.Forms;
using Usbtouart;

namespace WindowsFormsApplication1
{
    public partial class Form11 : Form
    {
        public static string st ;
        
        public Form11(string portName)
        {
            InitializeComponent();
            
            if (!mySerialPort.IsOpen)
            {
                
                mySerialPort.PortName = portName;
                mySerialPort.Open();
                tbRX.Text = "open :) ";
                
            }
            else
                tbRX.Text = "busy :( ";

        }

        private int rxlen;
        private int[] masinput;
        DateTime ThToday = DateTime.Now;
        string ThData;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mySerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            

            if (mySerialPort.ReadByte() == 0x55)
            {
                rxlen = mySerialPort.ReadByte();
                masinput = new int[rxlen];
                for (int i = 0; i < rxlen; i++)
                {
                    masinput[i] = mySerialPort.ReadByte();
                }
            }
            else
            {
                MessageBox.Show("Fail");
            }

            /* 
             int dataLength = mySerialPort.BytesToRead;
             byte[] data = new byte[dataLength];
             int nbrDataRead = mySerialPort.Read(data, 0, dataLength);
             if (nbrDataRead == 0)
                 return;
             */
            this.Invoke(new EventHandler(checkData));

        }
        private void checkData(object o, EventArgs e)
        {
            ThData = ThToday.ToString();

            if(masinput[0] == 0x11)
            {
                if(masinput[1] == 0x23)
                    tbTX.AppendText(ThData + " Check first one" + "\n");
                else
                    tbTX.AppendText(ThData + " Not correct word from first" + "\n");
            }else if(masinput[0] == 0x13)
            {
                if (masinput[1] == 0x33)
                    tbTX.AppendText(ThData + " Alert from first one" + "\n");
                else
                    tbTX.AppendText(ThData + " Not correct word alert from first" + "\n");
            }        

        }

        private void displayText(object o, EventArgs e)
        {

            for (int i = 0; i < rxlen; i++)
            {
                tbRX.AppendText(masinput[i].ToString());
                tbRX.AppendText("\n");
            }           
           // pictureBox1.Show();
        }
        
        private void bSend_Click(object sender, EventArgs e)
        {
            // mySerialPort.Write(rxInt);
            mySerialPort.Write(new byte[] { 0x55, 0x03, 0x11, 0x23, 0x23 }, 0, 5);
        }
       
        private void bClear_Click(object sender, EventArgs e)
        {
            tbTX.Clear();
            //tbRX.Clear();
            //pictureBox1.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mySerialPort.Close();
            Application.Exit(); 
        }

        private void tbTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void first1check_Click(object sender, EventArgs e)
        {
            mySerialPort.Write(new byte[] { 0x55, 0x3, 0x11, 0x23, 0x23 }, 0, 5);
            
            tbTX.AppendText("---->" + ThToday.ToString() + " Check first one" + "\n");
        }

        private void first1alert_Click(object sender, EventArgs e)
        {
            mySerialPort.Write(new byte[] { 0x55, 0x3, 0x13, 0x33, 0x33 }, 0, 5);
    
            tbTX.AppendText("---->" + ThToday.ToString() + " Alert first one" + "\n");
        }
    }
}
