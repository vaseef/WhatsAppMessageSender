namespace WhatsAppMessageSender
{
    partial class Form1
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
            this.btnLaunchWhatsapp = new System.Windows.Forms.Button();
            this.btnSelectGroup = new System.Windows.Forms.Button();
            this.btnPlaceMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtChatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLaunchWhatsapp
            // 
            this.btnLaunchWhatsapp.Location = new System.Drawing.Point(95, 12);
            this.btnLaunchWhatsapp.Name = "btnLaunchWhatsapp";
            this.btnLaunchWhatsapp.Size = new System.Drawing.Size(167, 36);
            this.btnLaunchWhatsapp.TabIndex = 0;
            this.btnLaunchWhatsapp.Text = "Launch WhatsApp";
            this.btnLaunchWhatsapp.UseVisualStyleBackColor = true;
            this.btnLaunchWhatsapp.Click += new System.EventHandler(this.btnLaunchWhatsapp_Click);
            // 
            // btnSelectGroup
            // 
            this.btnSelectGroup.Location = new System.Drawing.Point(95, 99);
            this.btnSelectGroup.Name = "btnSelectGroup";
            this.btnSelectGroup.Size = new System.Drawing.Size(167, 38);
            this.btnSelectGroup.TabIndex = 1;
            this.btnSelectGroup.Text = "Select Chat";
            this.btnSelectGroup.UseVisualStyleBackColor = true;
            this.btnSelectGroup.Click += new System.EventHandler(this.btnSelectGroup_Click);
            // 
            // btnPlaceMessage
            // 
            this.btnPlaceMessage.Location = new System.Drawing.Point(95, 195);
            this.btnPlaceMessage.Name = "btnPlaceMessage";
            this.btnPlaceMessage.Size = new System.Drawing.Size(167, 33);
            this.btnPlaceMessage.TabIndex = 2;
            this.btnPlaceMessage.Text = "Place Message";
            this.btnPlaceMessage.UseVisualStyleBackColor = true;
            this.btnPlaceMessage.Click += new System.EventHandler(this.btnPlaceMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(41, 158);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(275, 31);
            this.txtMessage.TabIndex = 3;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(95, 234);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(167, 34);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtChatName
            // 
            this.txtChatName.Location = new System.Drawing.Point(95, 69);
            this.txtChatName.Name = "txtChatName";
            this.txtChatName.Size = new System.Drawing.Size(167, 20);
            this.txtChatName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Person/Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChatName);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnPlaceMessage);
            this.Controls.Add(this.btnSelectGroup);
            this.Controls.Add(this.btnLaunchWhatsapp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchWhatsapp;
        private System.Windows.Forms.Button btnSelectGroup;
        private System.Windows.Forms.Button btnPlaceMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtChatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

