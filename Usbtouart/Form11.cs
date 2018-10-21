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

        private int rxInt;
        private int rxIntcmd;
        private int rxIntl;
        private int rxIntl2;
        private int rxIntl3;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mySerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rxInt = mySerialPort.ReadByte();
            rxIntcmd = mySerialPort.ReadByte();
            rxIntl = mySerialPort.ReadByte();
            rxIntl2 = mySerialPort.ReadByte();
            rxIntl3 = mySerialPort.ReadByte();
            

            if(rxInt == 0x55)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("Fail");
            }

            if (rxIntcmd == 0x11)
            {
                MessageBox.Show("ok command");
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
            this.Invoke(new EventHandler(displayText));

        }

        private void displayText(object o, EventArgs e)
        {
           
            tbRX.AppendText(rxInt + " ");
            tbRX.AppendText("\n");
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
            tbRX.Clear();
          //  pictureBox1.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mySerialPort.Close();
            Application.Exit(); 
        }

        private void tbTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mySerialPort.IsOpen && checkBox1.Checked)
            {
                char[] ch = new char[1];
                ch[0] = e.KeyChar;
                mySerialPort.Write(ch, 0, 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // mySerialPort.Write(tbTX.Text);
            //  mySerialPort.Write("20");
            mySerialPort.Write(new byte[] { 0x55, 0x3, 0x11, 0x23, 0x23 }, 0, 5);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
