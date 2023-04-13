using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Messaging;
using System.Threading;
using System.IO;

namespace Message_Queuing
{
    public partial class frmMessage_Queuing : Form
    {
        public frmMessage_Queuing()
        {
            InitializeComponent();
        }
        public System.Messaging.MessageQueue mq;

        private void tim_Read_Tick(object sender, EventArgs e)
        {
                ReadData();
        }


        public delegate void UpdateRichEditCallback(string text);
        public delegate void UpdateCheckBoxCallback();
        private void ReadData()
        {

            bool flag = true;
            System.Messaging.Message mes;
            string m;


            while (flag == true)
            {
                try
                {
                    mes = mq.Receive(new TimeSpan(0, 0, 3));
                    mes.Formatter = new XmlMessageFormatter(new String[] { "System.String,mscorlib" });
                    m = mes.Body.ToString();
                    MsgBox1.Items.Add(m.ToString());
                    Application.DoEvents(); 
                }
                catch
                {
                    flag = false;
                }

            }

        }


        private void frmMessage_Queuing_Load(object sender, EventArgs e)
        {
            try
            {
                if (MessageQueue.Exists(@".\Private$\MyQueue"))
                    mq = new System.Messaging.MessageQueue(@".\Private$\MyQueue");
                else
                    mq = MessageQueue.Create(@".\Private$\MyQueue");
            }
            catch (Exception ex) { MsgBox1.Items.Add(ex.Message.ToString()); }
        }

        private void btn_add_msg_to_q_Click(object sender, EventArgs e)
        {
            System.Messaging.Message mm = new System.Messaging.Message();
            mm.Body = txtmsg.Text;
            mq.Send(mm);
        }

 


    }
}
