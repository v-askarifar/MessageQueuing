namespace Message_Queuing
{
    partial class frmMessage_Queuing
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
            this.MsgBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.btn_add_msg_to_q = new System.Windows.Forms.Button();
            this.tim_Read = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsgBox1
            // 
            this.MsgBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgBox1.Location = new System.Drawing.Point(12, 50);
            this.MsgBox1.Name = "MsgBox1";
            this.MsgBox1.Size = new System.Drawing.Size(471, 199);
            this.MsgBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtmsg);
            this.panel1.Controls.Add(this.btn_add_msg_to_q);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 44);
            this.panel1.TabIndex = 4;
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(143, 14);
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(340, 20);
            this.txtmsg.TabIndex = 1;
            this.txtmsg.Tag = "";
            this.txtmsg.Text = "Hello world";
            // 
            // btn_add_msg_to_q
            // 
            this.btn_add_msg_to_q.Location = new System.Drawing.Point(12, 12);
            this.btn_add_msg_to_q.Name = "btn_add_msg_to_q";
            this.btn_add_msg_to_q.Size = new System.Drawing.Size(101, 23);
            this.btn_add_msg_to_q.TabIndex = 0;
            this.btn_add_msg_to_q.Text = "Add msg to Q";
            this.btn_add_msg_to_q.UseVisualStyleBackColor = true;
            this.btn_add_msg_to_q.Click += new System.EventHandler(this.btn_add_msg_to_q_Click);
            // 
            // tim_Read
            // 
            this.tim_Read.Enabled = true;
            this.tim_Read.Interval = 10000;
            this.tim_Read.Tick += new System.EventHandler(this.tim_Read_Tick);
            // 
            // frmMessage_Queuing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MsgBox1);
            this.Name = "frmMessage_Queuing";
            this.Text = "Message_Queuing";
            this.Load += new System.EventHandler(this.frmMessage_Queuing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MsgBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tim_Read;
        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.Button btn_add_msg_to_q;
    }
}

