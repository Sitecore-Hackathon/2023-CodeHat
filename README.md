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

## Video link
⟹ Provide a video highlighing your Hackathon module submission and provide a link to the video. You can use any video hosting, file share or even upload the video to this repository. _Just remember to update the link below_

⟹ [Replace this Video link](#video-link)


## Pre-requisites and Dependencies
- Pre-requisites:
- Sitecore 10.3 clean installation.

- Dependencies:
- Sitecore PowerShell module. Sitecore.PowerShell.Extensions-6.4-IAR.zip
- Sitecore Headless Services. Sitecore Headless Services Server XP 21.0.583.zip
- Sitecore Experience Accelerator. Sitecore Experience Accelerator 10.3.0 rev. 00074

## Installation instructions

Download the code from this repository. Navigate to this folder [Project solution path]\src\Scripts
Open the file "PostPublishConfig.json" and configure the following variables: msBuildExe and siteName. msBuildExe contains the msbuild executable path for Visual Studio 2022. siteName is codehat.dev.local.

Run the following command in PowerShell to syncronize the Sitecore Items with unicorn.
.\PostPublish.ps1 -solutionPath 'C:\Projects\2023-CodeHat\src'

![image](https://user-images.githubusercontent.com/23084370/222929874-6fb5cc9e-1427-4816-8264-6a06d49bde95.png)

## Usage instructions
The URL running in 3000 port is displayed the following screen.


## Comments
If you'd like to make additional comments that is important for your module entry.
