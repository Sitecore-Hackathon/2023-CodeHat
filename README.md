![Hackathon Logo](docs/images/hackathon.png?raw=true "Hackathon Logo")
# Sitecore Hackathon 2023

- MUST READ: **[Submission requirements](SUBMISSION_REQUIREMENTS.md)**
- [Entry form template](ENTRYFORM.md)
  
## Team name
⟹ Code Hat

## Category
⟹ SXA and Headless

## Description
⟹ Create a new SXA component to crop an image. It was created a headless component using Sitecore Experience Accelerator (SXA) to facilite the website creation and component reusability.
We followed this link to configure the initial setup for SXA and Next.js

https://www.getfishtank.com/blog/how-to-setup-xm-cloud-sitecore-10-sxa-headless-and-nextjs

It was configured the following steps:
- Setting up your tenant and site
- Installing JSS
- Creating and configured a Next.js project

As initial configuration the site http://localhost:3000/

![image](https://user-images.githubusercontent.com/23084370/222930493-cf1ec132-bb14-4fe8-84e1-d11575287052.png)


## Video link
⟹ Provide a video highlighing your Hackathon module submission and provide a link to the video. You can use any video hosting, file share or even upload the video to this repository. _Just remember to update the link below_

⟹ [Replace this Video link](#video-link)


## Pre-requisites and Dependencies
As pre-requisite it is required a Sitecore 10.3 clean site installation.

As dependencies the following ones:

- Sitecore PowerShell module. Sitecore.PowerShell.Extensions-6.4-IAR.zip
- Sitecore Headless Services. Sitecore Headless Services Server XP 21.0.583.zip
- Sitecore Experience Accelerator. Sitecore Experience Accelerator 10.3.0 rev. 00074

## Installation instructions

Download the code from this repository. Navigate to this folder [Project solution path]\src\Scripts
Open the file "PostPublishConfig.json" and configure the following variables: msBuildExe and siteName. msBuildExe contains the msbuild executable path for Visual Studio 2022. siteName is codehat.dev.local.

Run the following command in PowerShell to syncronize the Sitecore Items with unicorn.
.\PostPublish.ps1 -solutionPath 'C:\Projects\2023-CodeHat\src'


## Usage instructions
The Toolbox with the new component is in the Experience Editor is included bellow.

![image](https://user-images.githubusercontent.com/23084370/222930457-366e09f2-3967-4e9d-a544-c30acbf58bb6.png)

The URL running in 3000 port is displayed the following screen.
Initial screen

![image](https://user-images.githubusercontent.com/23084370/222929874-6fb5cc9e-1427-4816-8264-6a06d49bde95.png)

Screen to upload an image

![image](https://user-images.githubusercontent.com/23084370/222930029-3569d666-0b02-43b0-afd2-eb43dc8bec21.png)

Screen to crop an image

![image](https://user-images.githubusercontent.com/23084370/222930046-bc9512cf-edda-4f9c-b73e-5b61f28c8a00.png)


## Comments

