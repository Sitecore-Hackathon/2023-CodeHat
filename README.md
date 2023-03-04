![Hackathon Logo](docs/images/hackathon.png?raw=true "Hackathon Logo")
# Sitecore Hackathon 2023

- MUST READ: **[Submission requirements](SUBMISSION_REQUIREMENTS.md)**
- [Entry form template](ENTRYFORM.md)
  
## Team name
⟹ Code Hat

## Category
⟹ SXA and Headless

## Description
⟹ Create a new SXA component to crop an image 
   - It was created a headless component using Sitecore Experience Accelerator (SXA) to facilite the website creation and component reusability.

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

### Configuration
⟹ If there are any custom configuration that has to be set manually then remember to add all details here.

_Remove this subsection if your entry does not require any configuration that is not fully covered in the installation instructions already_

## Usage instructions
⟹ Provide documentation about your module, how do the users use your module, where are things located, what do the icons mean, are there any secret shortcuts etc.

Include screenshots where necessary. You can add images to the `./images` folder and then link to them from your documentation:

![Hackathon Logo](docs/images/hackathon.png?raw=true "Hackathon Logo")

You can embed images of different formats too:

![Deal With It](docs/images/deal-with-it.gif?raw=true "Deal With It")

And you can embed external images too:

![Random](https://thiscatdoesnotexist.com/)

## Comments
If you'd like to make additional comments that is important for your module entry.
