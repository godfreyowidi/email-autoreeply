# Email Handler Contact Us Form.

## Description

  This application makes it significantly easy to send emails by collecting user input in the form of name, email, phone, subject and message. It can serve as a complaint, compliment, and issue submission form. It can be used as a standalone or side by side with a website.

## Technology used

1. C# v9
2. ASP.NET Core v6
3. Browser - Google Chrome
4. Gmail and Outlook email service
5. Visual Studio 2019
6. Git
7. Github

## Setup

  Download or Clone the project repository from GitHub using this link 

  https://github.com/godfreyowidi/email-autoreeply

  Using Git, navigate to the project local directory and right click to open in Visual Studio 2019.

  Open using the Project Solution option.

## Usage

  Allow access to less secure application in your gmail account

  Using this link https://support.google.com/mail/answer/7126229?hl=en ensure you configure your Gmail's SMTP server settings through Google

  You can include this application as part of your website codebase under the Contact Us page or host it as a standalone then share the link with your clients.

  Customize the following address and contact information according to your needs


  Replace you Gmail email credentials to match exactly as below



  After replacing instances of all your Gmail email and password, you can customize the email message as per your requirement. As much as most of the parts will remain the same, the message is not too generic as two different clients can never send the same message. The application sends email messages with the clients name and the subject they entered. As can be seen below;



  After customizing the message, click the run button on Visual Studio 2019 to start the application.

  The application will open in a development environment in the following link

  http://localhost:59502/Default.aspx

  You can enter random details to test the application.

  An email message will be sent to your Gmail account and an auto response will be sent to the email you entered on the input section.

  The application will also throw an error message in case something goes wrong, for example a connection issue


