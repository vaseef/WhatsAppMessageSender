using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppMessageSender
{
    public partial class Form1 : Form
    {
        IWebDriver m_driver;
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

        private void btnSelectGroup_Click(object sender, EventArgs e)
        {
            string itm = txtChatName.Text;
            string className = "_2wP_Y";
            try
            {
                var chatList = m_driver.FindElements(By.ClassName(className));

                foreach (IWebElement element in chatList)
                {
                    if (element != null && !string.IsNullOrEmpty(element.Text))
                    {
                        if (element.Text.StartsWith(itm))
                        {
                            element.Click();
                        }
                    }              
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Class not found");
            }
        }

        private void btnPlaceMessage_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            string classname = "_1Plpp";
            try
            {
                var messageTextBox = m_driver.FindElement(By.ClassName(classname));

                if (messageTextBox != null)
                {
                    messageTextBox.Click();

                    messageTextBox.SendKeys(message);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Class not found");
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string classname = "_35EW6";
            // Store locator values of email text box and sign up button		
            try
            {
                var sendButton = m_driver.FindElement(By.ClassName(classname));

                if (sendButton != null)
                {
                    sendButton.Click();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Class not found");
            }
        }
    }
}
