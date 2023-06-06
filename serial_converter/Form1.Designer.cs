namespace serial_converter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_connect = new System.Windows.Forms.Button();
            this.Appli_SIT = new System.IO.Ports.SerialPort(this.components);
            this.Appli_Scale = new System.IO.Ports.SerialPort(this.components);
            this.cmbox_sit_port = new System.Windows.Forms.ComboBox();
            this.cmbox_scale_port = new System.Windows.Forms.ComboBox();
            this.btn_nanual_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rcv_app_scale = new System.Windows.Forms.TextBox();
            this.txt_snd_app_scale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_filter_zero = new System.Windows.Forms.TextBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.lbl_name_ver = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_snd_app_sit = new System.Windows.Forms.TextBox();
            this.txt_rcv_app_sit = new System.Windows.Forms.TextBox();
            this.cmbox_scale_baud = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbox_sit_baud = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Status_mon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Polling_timer = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.txt_polling_timer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_polling_on = new System.Windows.Forms.Button();
            this.btn_polling_off = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(108, 35);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Appli_SIT
            // 
            this.Appli_SIT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Appli_SIT_DataReceived);
            // 
            // Appli_Scale
            // 
            this.Appli_Scale.BaudRate = 19200;
            this.Appli_Scale.DiscardNull = true;
            this.Appli_Scale.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Appli_Scale_DataReceived);
            // 
            // cmbox_sit_port
            // 
            this.cmbox_sit_port.FormattingEnabled = true;
            this.cmbox_sit_port.Location = new System.Drawing.Point(89, 207);
            this.cmbox_sit_port.Name = "cmbox_sit_port";
            this.cmbox_sit_port.Size = new System.Drawing.Size(75, 20);
            this.cmbox_sit_port.TabIndex = 2;
            // 
            // cmbox_scale_port
            // 
            this.cmbox_scale_port.FormattingEnabled = true;
            this.cmbox_scale_port.Location = new System.Drawing.Point(90, 132);
            this.cmbox_scale_port.Name = "cmbox_scale_port";
            this.cmbox_scale_port.Size = new System.Drawing.Size(75, 20);
            this.cmbox_scale_port.TabIndex = 3;
            // 
            // btn_nanual_send
            // 
            this.btn_nanual_send.Location = new System.Drawing.Point(185, 232);
            this.btn_nanual_send.Name = "btn_nanual_send";
            this.btn_nanual_send.Size = new System.Drawing.Size(100, 23);
            this.btn_nanual_send.TabIndex = 4;
            this.btn_nanual_send.Text = "manual_send";
            this.btn_nanual_send.UseVisualStyleBackColor = true;
            this.btn_nanual_send.Click += new System.EventHandler(this.btn_nanual_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Electric scale<->Appli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "SIT<->Appli";
            // 
            // txt_rcv_app_scale
            // 
            this.txt_rcv_app_scale.Location = new System.Drawing.Point(186, 133);
            this.txt_rcv_app_scale.Name = "txt_rcv_app_scale";
            this.txt_rcv_app_scale.Size = new System.Drawing.Size(100, 19);
            this.txt_rcv_app_scale.TabIndex = 7;
            // 
            // txt_snd_app_scale
            // 
            this.txt_snd_app_scale.Location = new System.Drawing.Point(308, 133);
            this.txt_snd_app_scale.Name = "txt_snd_app_scale";
            this.txt_snd_app_scale.Size = new System.Drawing.Size(100, 19);
            this.txt_snd_app_scale.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Receive_Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Send_Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filter Zero";
            // 
            // txt_filter_zero
            // 
            this.txt_filter_zero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_filter_zero.Location = new System.Drawing.Point(23, 83);
            this.txt_filter_zero.Name = "txt_filter_zero";
            this.txt_filter_zero.Size = new System.Drawing.Size(56, 19);
            this.txt_filter_zero.TabIndex = 12;
            this.txt_filter_zero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(189, 35);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 13;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click_1);
            // 
            // lbl_name_ver
            // 
            this.lbl_name_ver.AutoSize = true;
            this.lbl_name_ver.Location = new System.Drawing.Point(268, 9);
            this.lbl_name_ver.Name = "lbl_name_ver";
            this.lbl_name_ver.Size = new System.Drawing.Size(158, 12);
            this.lbl_name_ver.TabIndex = 14;
            this.lbl_name_ver.Text = "Serial converter Ver.********";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "Send_Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Receive_Data";
            // 
            // txt_snd_app_sit
            // 
            this.txt_snd_app_sit.Location = new System.Drawing.Point(185, 206);
            this.txt_snd_app_sit.Name = "txt_snd_app_sit";
            this.txt_snd_app_sit.Size = new System.Drawing.Size(100, 19);
            this.txt_snd_app_sit.TabIndex = 16;
            // 
            // txt_rcv_app_sit
            // 
            this.txt_rcv_app_sit.Location = new System.Drawing.Point(309, 206);
            this.txt_rcv_app_sit.Name = "txt_rcv_app_sit";
            this.txt_rcv_app_sit.Size = new System.Drawing.Size(100, 19);
            this.txt_rcv_app_sit.TabIndex = 15;
            // 
            // cmbox_scale_baud
            // 
            this.cmbox_scale_baud.FormattingEnabled = true;
            this.cmbox_scale_baud.Items.AddRange(new object[] {
            "",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cmbox_scale_baud.Location = new System.Drawing.Point(90, 158);
            this.cmbox_scale_baud.Name = "cmbox_scale_baud";
            this.cmbox_scale_baud.Size = new System.Drawing.Size(75, 20);
            this.cmbox_scale_baud.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "Port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "Baud rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "Baud rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "Port";
            // 
            // cmbox_sit_baud
            // 
            this.cmbox_sit_baud.FormattingEnabled = true;
            this.cmbox_sit_baud.Items.AddRange(new object[] {
            "",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cmbox_sit_baud.Location = new System.Drawing.Point(89, 233);
            this.cmbox_sit_baud.Name = "cmbox_sit_baud";
            this.cmbox_sit_baud.Size = new System.Drawing.Size(76, 20);
            this.cmbox_sit_baud.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "g";
            // 
            // Status_mon
            // 
            this.Status_mon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status_mon.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Status_mon.ForeColor = System.Drawing.Color.White;
            this.Status_mon.Location = new System.Drawing.Point(14, 24);
            this.Status_mon.Name = "Status_mon";
            this.Status_mon.Size = new System.Drawing.Size(84, 34);
            this.Status_mon.TabIndex = 26;
            this.Status_mon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "Operation status";
            // 
            // Polling_timer
            // 
            this.Polling_timer.Enabled = true;
            this.Polling_timer.Interval = 1000;
            this.Polling_timer.Tick += new System.EventHandler(this.Polling_timer_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(306, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "polling timer";
            // 
            // txt_polling_timer
            // 
            this.txt_polling_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_polling_timer.Location = new System.Drawing.Point(308, 83);
            this.txt_polling_timer.Name = "txt_polling_timer";
            this.txt_polling_timer.Size = new System.Drawing.Size(56, 19);
            this.txt_polling_timer.TabIndex = 29;
            this.txt_polling_timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(370, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "msec";
            // 
            // btn_polling_on
            // 
            this.btn_polling_on.Location = new System.Drawing.Point(309, 231);
            this.btn_polling_on.Name = "btn_polling_on";
            this.btn_polling_on.Size = new System.Drawing.Size(99, 23);
            this.btn_polling_on.TabIndex = 31;
            this.btn_polling_on.Text = "Polling_ON";
            this.btn_polling_on.UseVisualStyleBackColor = true;
            this.btn_polling_on.Click += new System.EventHandler(this.btn_polling_on_Click);
            // 
            // btn_polling_off
            // 
            this.btn_polling_off.Location = new System.Drawing.Point(309, 259);
            this.btn_polling_off.Name = "btn_polling_off";
            this.btn_polling_off.Size = new System.Drawing.Size(99, 23);
            this.btn_polling_off.TabIndex = 32;
            this.btn_polling_off.Text = "Polling_OFF";
            this.btn_polling_off.UseVisualStyleBackColor = true;
            this.btn_polling_off.Click += new System.EventHandler(this.btn_polling_off_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 289);
            this.Controls.Add(this.btn_polling_off);
            this.Controls.Add(this.btn_polling_on);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_polling_timer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Status_mon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbox_sit_baud);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbox_scale_baud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_snd_app_sit);
            this.Controls.Add(this.txt_rcv_app_sit);
            this.Controls.Add(this.lbl_name_ver);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.txt_filter_zero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_snd_app_scale);
            this.Controls.Add(this.txt_rcv_app_scale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nanual_send);
            this.Controls.Add(this.cmbox_scale_port);
            this.Controls.Add(this.cmbox_sit_port);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Serial Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.IO.Ports.SerialPort Appli_SIT;
        private System.IO.Ports.SerialPort Appli_Scale;
        private System.Windows.Forms.ComboBox cmbox_sit_port;
        private System.Windows.Forms.ComboBox cmbox_scale_port;
        private System.Windows.Forms.Button btn_nanual_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rcv_app_scale;
        private System.Windows.Forms.TextBox txt_snd_app_scale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_filter_zero;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label lbl_name_ver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_snd_app_sit;
        private System.Windows.Forms.TextBox txt_rcv_app_sit;
        private System.Windows.Forms.ComboBox cmbox_scale_baud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbox_sit_baud;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Status_mon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer Polling_timer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_polling_timer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_polling_on;
        private System.Windows.Forms.Button btn_polling_off;
    }
}

