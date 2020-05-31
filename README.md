# Automate Sending Messages via WhatsApp Messenger
This is a simple example to demonstrate how to send messages via WhatsApp using automated mechanism.
Please see the video for more details(https://youtu.be/9D0lJ-qudjg). 

Consider a person who want to send the same message/picture/url to many people say a 1000 groups or individuals. How much time consuming it will be !! This tool will help to automate this situation by searching and posting messages to each group/individual. 

Here we are opening the WhatsApp web in Chrome browser using a C# code and then searching for a chat with specific name. Then placing the message and clicking the send button. The utility accepts a comma seperated list of person/group names and the message. Here messages can be a url or a plain text.
eg: person/group names can be like :Test 1,Test 2,friends,family


All these actions are done through the C# utility.

Requiured Tools & Packages:
1. Visual Studio 2019 with .Net Framework 4.0 or above
2. NPM Install: Selenium.WebDriver.3.141.0
3. NPM Install: Selenium.WebDriver.ChromeDriver.81.0.4044.13800

Selenium is a free (open source) automated testing suite for web applications across different browsers and platforms.

Note: As per whatsapp, this kind of automation is not allowed for business purpose.

-WhatsApp Documentation.

-"Please note that if you use anything other than the official WhatsApp Business API or other official WhatsApp tools, we reserve the right to limit or remove your access to WhatsApp as this violates our policies. Please do not use any non-WhatsApp authorized third-party tools to communicate on WhatsApp. To discover the group of third-party providers WhatsApp works with, visit the Partner Directory."
https://www.facebook.com/business/partner-directory/search?platforms=whatsapp&solution_type=messaging
https://developers.facebook.com/docs/whatsapp/overview

Thank You.
