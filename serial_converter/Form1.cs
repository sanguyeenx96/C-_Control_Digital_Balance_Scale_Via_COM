using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace serial_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Title
            lbl_name_ver.Text = "Serial Converter Ver.20221114";
        }

        //polling flg -> ture:polling on false:polling off
        public bool polling_enable = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            polling_enable = false;
            btn_polling_on.Enabled = true;
            btn_polling_off.Enabled = false;
            //Polling_timer.Enabled = false;


            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbox_sit_port.Items.Add(port);
                cmbox_scale_port.Items.Add(port);
            }
            if (cmbox_sit_port.Items.Count > 0)
            {
                cmbox_sit_port.SelectedIndex = 0;
            }
            if (cmbox_scale_port.Items.Count > 0)
            {
                cmbox_scale_port.SelectedIndex = 0;
            }

            btn_disconnect.Enabled = false;
            btn_connect.Enabled = true;

            Status_mon.Text = "STOP";
            Status_mon.ForeColor = Color.White;
            Status_mon.BackColor = Color.Gray;

            cmbox_scale_port.SelectedIndex = Properties.Settings.Default.back_up_cmbox_scale_port;
            cmbox_sit_port.SelectedIndex = Properties.Settings.Default.back_up_cmbox_sit_port;
            cmbox_scale_baud.SelectedIndex = Properties.Settings.Default.back_up_cmbox_scale_baud;
            cmbox_sit_baud.SelectedIndex = Properties.Settings.Default.back_up_cmbox_sit_baud;
            txt_filter_zero.Text = Properties.Settings.Default.back_up_txt_filter_zero;
            txt_polling_timer.Text = Properties.Settings.Default.back_up_txt_polling;

        }

        private double dbl_filter_zero = 0.0;
        private double dbl_receive_data = 0.0;
        private int int_polling_timer = 1000;
        
        //port open button
        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool init_result = port_init();
            if (init_result)
            {
                port_open();

                Properties.Settings.Default.back_up_cmbox_scale_port = cmbox_scale_port.SelectedIndex;
                Properties.Settings.Default.back_up_cmbox_sit_port = cmbox_sit_port.SelectedIndex;
                Properties.Settings.Default.back_up_cmbox_scale_baud = cmbox_scale_baud.SelectedIndex;
                Properties.Settings.Default.back_up_cmbox_sit_baud = cmbox_sit_baud.SelectedIndex;
                Properties.Settings.Default.back_up_txt_filter_zero = txt_filter_zero.Text;
                Properties.Settings.Default.back_up_txt_polling = txt_polling_timer.Text;
                Properties.Settings.Default.Save();

                btn_disconnect.Enabled = true;
                btn_connect.Enabled = false;

                Status_mon.Text = "RUN";
                Status_mon.ForeColor = Color.White;
                Status_mon.BackColor = Color.YellowGreen;

                btn_disconnect.Focus();

                try { dbl_filter_zero = double.Parse(txt_filter_zero.Text.ToString()); }
                catch { dbl_filter_zero = 0.0; }

                try { int_polling_timer = int.Parse(txt_polling_timer.Text.ToString()); }
                catch { int_polling_timer = 1000; }

                Polling_timer.Interval = int_polling_timer;
            }
            else
            {
                MessageBox.Show("Failed in the initialization of the port.");
            }
        }

        //port close button
        private void btn_disconnect_Click_1(object sender, EventArgs e)
        {
            polling_enable = false;
            btn_polling_on.Enabled = true;
            btn_polling_off.Enabled = false;
            
            Appli_SIT.Close();
            Appli_Scale.Close();

            btn_disconnect.Enabled = false;
            btn_connect.Enabled = true;

            Status_mon.Text = "STOP";
            Status_mon.ForeColor = Color.White;
            Status_mon.BackColor = Color.Gray;

            btn_connect.Focus();
        }

        //port init
        private bool port_init()
        {
            try
            {
                //(Appli-SIT)Port initial setting
                //Appli_SIT.BaudRate = 19200;
                Appli_SIT.BaudRate = int.Parse(cmbox_sit_baud.Text.ToString());
                Appli_SIT.Parity = Parity.None;
                Appli_SIT.DataBits = 8;
                Appli_SIT.StopBits = StopBits.One;
                Appli_SIT.Handshake = Handshake.None;
                Appli_SIT.Encoding = Encoding.ASCII;
                //Appli_SIT.PortName = "COM1";
                Appli_SIT.PortName = cmbox_sit_port.Text.ToString();

                //(Appli-Electric scale)Port initial setting
                //Appli_Scale.BaudRate = 19200;
                Appli_Scale.BaudRate = int.Parse(cmbox_scale_baud.Text.ToString());
                Appli_Scale.Parity = Parity.None;
                Appli_Scale.DataBits = 8;
                Appli_Scale.StopBits = StopBits.One;
                Appli_Scale.Handshake = Handshake.None;
                Appli_Scale.Encoding = Encoding.ASCII;
                //Appli_Scale.PortName = "COM30";
                Appli_Scale.PortName = cmbox_scale_port.Text.ToString();

                return true;
            }
            catch { return false; }
        }

        //port open
        private void port_open()
        {
            Appli_SIT.Open();
            Appli_Scale.Open();
        }

        //manual send
        private void btn_nanual_send_Click(object sender, EventArgs e)
        {
            if (Appli_SIT.IsOpen)
            {
                Appli_SIT.Write(txt_snd_app_scale.Text + "\r");
            }
        }

        //delegate
        delegate void SetTextCallback(string text);
        private void Response_snd_scale(string text)
        {
            if (txt_snd_app_scale.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Response_snd_scale);
                //Invoke(d, new object[] { text });
                BeginInvoke(d, new object[] { text });
            }
            else
            {
                //txt_receive_data.AppendText(text + "\n");
                //txt_send_data.AppendText(text + "\n");
                txt_snd_app_scale.Text = text;
            }
        }

        private void Response_rcv_scale(string text)
        {
            if (txt_rcv_app_scale.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Response_rcv_scale);
                //Invoke(d, new object[] { text });
                BeginInvoke(d, new object[] { text });
            }
            else
            {
                //txt_receive_data.AppendText(text + "\n");
                //txt_send_data.AppendText(text + "\n");
                txt_rcv_app_scale.Text = text;
            }
        }
        private void Response_snd_sit(string text)
        {
            if (txt_snd_app_sit.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Response_snd_sit);
                //Invoke(d, new object[] { text });
                BeginInvoke(d, new object[] { text });
            }
            else
            {
                //txt_receive_data.AppendText(text + "\n");
                //txt_send_data.AppendText(text + "\n");
                txt_snd_app_sit.Text = text;
            }
        }

        private void Response_rcv_sit(string text)
        {
            if (txt_rcv_app_sit.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Response_rcv_sit);
                //Invoke(d, new object[] { text });
                BeginInvoke(d, new object[] { text });
            }
            else
            {
                //txt_receive_data.AppendText(text + "\n");
                //txt_send_data.AppendText(text + "\n");
                txt_rcv_app_sit.Text = text;
            }
        }

        private void Response_zero_filter(string text)
        {
            if (txt_filter_zero.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Response_zero_filter);
                //Invoke(d, new object[] { text });
                BeginInvoke(d, new object[] { text });
            }
            else
            {
                //txt_receive_data.AppendText(text + "\n");
                //txt_send_data.AppendText(text + "\n");
                txt_filter_zero.Text = text;
            }
        }

        private void Response_polling_timmer(string text)
        {
            if (txt_filter_zero.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Response_polling_timmer);
                //Invoke(d, new object[] { text });
                BeginInvoke(d, new object[] { text });
            }
            else
            {
                //txt_receive_data.AppendText(text + "\n");
                //txt_send_data.AppendText(text + "\n");
                txt_filter_zero.Text = text;
            }
        }

        public string read_buf = "";

        //Event DataReceived(Electric scale -> Appli)
        private void Appli_Scale_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);

            string str_default = "";
            Response_rcv_scale(str_default);
            Response_snd_sit(str_default);
            string str_rcv = "0.00g", str_rcv_trm = "0.00";    //default
            string str_snd = "0.00g";    //default 

            read_buf = Appli_Scale.ReadExisting();

            int cr = read_buf.IndexOf("g \r");

            if (cr >= 0)
            {
                str_rcv = read_buf;

                try
                {
                    str_rcv_trm = str_rcv.Replace(" ", "");   //delete space
                    str_rcv_trm = str_rcv_trm.Replace("g", "");   //delete g
                    str_rcv_trm = str_rcv_trm.Replace("\r", "");   //delete cr
                    dbl_receive_data = double.Parse(str_rcv_trm);
                }
                catch
                {
                    str_rcv = "0.00g";
                    dbl_receive_data = 0.00;
                }

                if (dbl_receive_data <= dbl_filter_zero)
                {
                    str_snd = "     0.00g \r";
                }
                else
                {
                    str_snd = str_rcv;
                }

                Response_rcv_scale(str_rcv);
                Response_snd_sit(str_snd);

                if (str_snd != "")
                {
                    if (Appli_SIT.IsOpen)
                    {
                        Appli_SIT.Write(str_snd);
                    }
                }

            }
            read_buf = "";
            Appli_Scale.DiscardInBuffer();
            Appli_Scale.BaseStream.Flush();
        }

        //Event DataReceived(SIT -> Appli)
        private void Appli_SIT_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);

            string str_default = "";
            Response_rcv_sit(str_default);
            Response_snd_scale(str_default);
            string str_rcv = "", str_rcv_trm = "D01"; ;    //default
            string str_snd = "";    //default

            read_buf = Appli_SIT.ReadExisting();
            int cr = read_buf.IndexOf("\r");

            if (cr >= 0)
            {
                str_rcv = read_buf;

                int command_g = str_rcv.IndexOf("g");
                int command_D01 = str_rcv.IndexOf("D01");
                int command_D09 = str_rcv.IndexOf("D09");

                if (command_D09 >= 0 && command_g >= 0 && command_D01 >= 0)
                {

                }
                else if (command_g >= 0 && command_D01 >= 0)
                {
                    if (Appli_Scale.IsOpen)
                    {
                        str_snd = "g\r";
                        Appli_Scale.Write(str_snd);
                        //str_snd = "D01\r";
                        //Appli_Scale.Write(str_snd);

                        //polling enable flg on(polling start)
                        polling_enable = true;
                        //Polling_timer.Enabled = true;

                    }
                }
                else if (command_D09 >= 0)
                {
                    if (Appli_Scale.IsOpen)
                    {
                        //str_snd = "D09\r";
                        //Appli_Scale.Write(str_snd);

                        //polling enable flg off(polling stop)
                        polling_enable = false;
                        //Polling_timer.Enabled = false;
                    }
                }

                Response_rcv_sit(str_rcv);
                Response_snd_scale(str_snd);
            }
            read_buf = "";
            Appli_SIT.DiscardInBuffer(); //xoá bộ nhớ đệm
            Appli_SIT.BaseStream.Flush();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Polling_timer_Tick(object sender, EventArgs e)
        {
            Polling_send();
        }

        private void Polling_send()
        {
            if (polling_enable == true)
            {
                string str_snd = "D05\r";   //get data onetime
                Appli_Scale.Write(str_snd);
            }
        }

        private void btn_polling_on_Click(object sender, EventArgs e)
        {
            btn_polling_on.Enabled = false;
            btn_polling_off.Enabled = true;
            polling_enable = true;
        }

        private void btn_polling_off_Click(object sender, EventArgs e)
        {
            btn_polling_on.Enabled = true;
            btn_polling_off.Enabled = false;
            polling_enable = false;
        }


    }
}
