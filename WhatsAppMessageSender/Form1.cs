using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppMessageSender
{
    public partial class Form1 : Form
    {
        IWebDriver m_driver;
        private delegate void SafeCallDelegate(string text);
        private delegate void SafeCallDelegateToEnable(bool status);
        private bool bStopSendingMessage = false;
        public Form1()
        {
            InitializeComponent();
            m_driver = new ChromeDriver(@"D:\Work\general\WhatsAppMessageSender\WhatsAppMessageSender\bin\Debug\");
        }

        private void btnLaunchWhatsapp_Click(object sender, EventArgs e)
        {
            m_driver.Url = "https://web.whatsapp.com/";
            m_driver.Manage().Window.Maximize();
        }
        
        private void WriteTextSafe(string text)
        {
            if (txtLogs.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                txtLogs.Invoke(d, new object[] { text });
            }
            else
            {
                txtLogs.Text = text;
            }
        }

        private void EnableSendButton(bool status)
        {
            if (btnSendMessage.InvokeRequired)
            {
                var d = new SafeCallDelegateToEnable(EnableSendButton);
                btnSendMessage.Invoke(d, new object[] { status });
            }
            else
            {
                btnSendMessage.Enabled = status;
            }
        }

        StringBuilder strLogs = new StringBuilder();
        private void SetText(string logString)
        {
            strLogs.AppendLine(logString);
            WriteTextSafe(strLogs.ToString());
        }

        Thread threadMessages = null;
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            threadMessages = new Thread(new ThreadStart(SendMessages));
            threadMessages.Start();
        }

        private void SendMessages()
        {
            bStopSendingMessage = false;

            strLogs.Clear();
            SetText("============Starting=============");
            EnableSendButton(false);
            // Get to address to list and return if it is empty.
            List<string> toChatsList = txtChatName.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (toChatsList.Count < 1)
            {
                MessageBox.Show("Please Enter Any person/group names");
                btnSendMessage.Enabled = true;

                return;
            }

            // Check whether the user entered any message or not.
            string messageToSend = txtMessage.Text;
            if (string.IsNullOrEmpty(messageToSend))
            {
                MessageBox.Show("Please Enter a message to send");
                btnSendMessage.Enabled = true;
                return;
            }

            // send messages.
            int sleepTime = 1000;
            foreach (string toChat in toChatsList)
            {
                try
                {
                    //Chat Name = toChat
                    // Message to Send = messageToSend
                    string toChatTrimmed = toChat.Trim();
                    // Search the chat in search box.
                    SetText($"Searching for chat {toChatTrimmed}: ");
                    Thread.Sleep(sleepTime);
                    var searchLense = m_driver.FindElement(By.ClassName("C28xL"));
                    Thread.Sleep(sleepTime);
                    searchLense.Click();
                    Thread.Sleep(sleepTime);
                    m_driver.SwitchTo().ActiveElement().SendKeys(toChatTrimmed);
                    Thread.Sleep(sleepTime);

                    // Get the chat list. List size should be grater than 0.
                    var chatSearchResultList = m_driver.FindElements(By.ClassName("_2wP_Y"));
                    Thread.Sleep(sleepTime);
                    bool bMessageSent = false;
                    foreach (IWebElement chatResultItem in chatSearchResultList)
                    {
                        if (chatResultItem != null && !string.IsNullOrEmpty(chatResultItem.Text))
                        {
                            string nameMsg = chatResultItem.Text.Split(new[] { '\r', '\n' }).FirstOrDefault();
                            if (nameMsg.Equals(toChatTrimmed))
                            {
                                chatResultItem.Click();
                                bMessageSent = true;
                                break;
                            }
                        }
                    }
                    if (bMessageSent)
                    {
                        SetText($"Found.");
                    }
                    else
                    {
                        SetText($"Not Found.");
                    }
                    Thread.Sleep(sleepTime);
                    // Placing the message
                    string messageEntryField = "_1Plpp";
                    try
                    {
                        var messageTextBox = m_driver.FindElement(By.ClassName(messageEntryField));
                        Thread.Sleep(sleepTime);
                        if (messageTextBox != null)
                        {

                            messageTextBox.Click();
                            Thread.Sleep(sleepTime);
                            messageTextBox.SendKeys(messageToSend);
                            SetText($"Message Placed Successfully.");
                        }
                    }
                    catch (Exception ee)
                    {
                        SetText($"MessageBox Not Found.");
                    }

                    if (bStopSendingMessage)
                    {
                        EnableSendButton(true);
                        SetText("============Ending==============");
                        return;
                    }
                    Thread.Sleep(sleepTime);
                    // send message by clicking the send button
                    string sendMessageButton = "_35EW6";
                    // Store locator values of email text box and sign up button		
                    try
                    {
                        var sendButton = m_driver.FindElement(By.ClassName(sendMessageButton));
                        Thread.Sleep(sleepTime);
                        if (sendButton != null)
                        {
                            sendButton.Click();
                            Thread.Sleep(sleepTime);
                            SetText($"Message Send Successfully.");
                        }
                    }
                    catch (Exception ee)
                    {
                        SetText($"Error in sending message.");
                    }
                }
                catch(Exception ex1)
                {
                    MessageBox.Show($"Error :: {ex1.Message}");
                }
            }

            EnableSendButton(true);

            SetText("============Ending==============");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bStopSendingMessage = true;
        }
    }
}
