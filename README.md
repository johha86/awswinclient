# AWS Windows Client

[![Build Status](https://dev.azure.com/GuaguancoLab/AWS%20Win%20Client/_apis/build/status/johha86.awswinclient?branchName=master)](https://dev.azure.com/GuaguancoLab/AWS%20Win%20Client/_build/latest?definitionId=5&branchName=master)

## Introduction

AWS Windows Client is a Windows Form project to embbed the AWS Console into a Desktop application. The project use the  [WebView2][l3] control to show the web content.

## Prerequisites
  - .NET Framework 4.7.2 or later.
  - [WebView2 Runtime] or any [non-stable Microsoft Edge (Chromium) Canary channel][l1] installed on Windows 10, Windows 8.1, or Windows 7.
  - [Visual Studio 2017][l2] or later

## Dependencies
 The project use the nugget package **Microsoft.Web.WebView2** .
 
## Installation
  - Download or clone this project
  - Build and run in Visual Studio
  
## Deployment
The WebView2 control uses Microsoft Edge (Chromium) as the rendering engine to display the web content in native applications. For such reason the [WebView2 Runtime][l4], must be present before the app starts.

## Questions
If you have any question just send me an email to [jharmenteros86@gmail.com][l5].

License
----

GNU GENERAL PUBLIC LICENSE


  [WebView2 Runtime]: <https://developer.microsoft.com/microsoft-edge/webview2> 
  [l1]: <https://www.microsoftedgeinsider.com/download>
  [l2]: <https://visualstudio.microsoft.com/>
  [l3]: <https://docs.microsoft.com/en-us/microsoft-edge/webview2/>
  [l4]: <https://developer.microsoft.com/microsoft-edge/webview2>
  [l5]: <mailto:jharmenteros86@gmail.com>
  
  