# Automate Sending Messages via WhatsApp Messenger
This is a simple example to demonstrate how to send messages via WhatsApp using automated mechanism.
Please see the video for more details(https://www.youtube.com/watch?v=ZH20y289X6A&t=11s). 

Consider a person who want to send the same message/picture/url to many people say a 1000 groups or individuals. How much time consuming it will be !! This tool will help to automate this situation by identiying and posting messages to each group/individual. 

Here we are opening the WhatsApp web in Chrome browser using a C# code and then searching for a chat with specific name. Then placing the message and clicking the send button. All these actions are done through the C# utility.

Requiured Tools & Packages:
1. Visual Studio 2019 with .Net Framework 4.0 or above
2. NPM Install: Selenium.WebDriver.3.141.0
3. NPM Install: Selenium.WebDriver.ChromeDriver.81.0.4044.13800

Selenium is a free (open source) automated testing suite for web applications across different browsers and platforms.

Currently there is a limitation as WhatsApp is loading the chats dynamically into the web UI. So at a time the utility is able to load only 16 chats. This tool further need to be enhanced to load all the messages at the same time.
