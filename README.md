# angelica_villegas.428.P1

Welcome to CS 428 Project 1 - Around the World GitHub Documentation 

Created by Angelica Villegas Salazar.

## Introduction
This is a project for Virtual, Augmented and Mixed Reality taught by Professor Andy Johnson. 

The goal was to create two designs of two distinct locations that could be projected onto two cubes. Each cube has five models on top (three models from the web, two models I created), one side that states the location temperature (in either Fahrenheit or Celsius), one side that states the current time at the location, one side that states the location name and one side that I chose to add a 2D model. If you flip the cube upside down and rightside up the lighting will change.

For more information visit the [project website](https://sites.google.com/uic.edu/cs428-angelica/project-1).

## Project Features
## Software Requirements

* Unity 
  - [version 2021.3.6f1](https://unity3d.com/unity/whats-new/2021.3.6) 
* Vuforia
  - [version 10.9](https://developer.vuforia.com/downloads/sdk?field_sdk_release_version_tid=58)
* [Unity Hub](https://unity3d.com/get-unity/download)

## Installation Instructions

1. Download the newest version of Unity Hub.
1. Once the download is complete, Open Unity Hub, navigate to the left hand bar and click on the **Installs** tab
1. If this is your first install of Unity Hub/Unity there will be no installs listed. To install the correct version on Unity:
    1. Navigate to **Install Editor** in the top left
    1. Navigate to the **Archive** tab in the top bar
    1. In the statment in this tab, click on the hyper link that says **download archive**
    1. Navigate to the correct version of Unity(2021.3.6f1)
    1. Click on the **Unity Hub** button to download this version to Unity Hub. 
    1. This will prompt Unity Hub to open and then will open an **Install** page with the version listed. 
        1. Under **Platforms** make sure to select **Android Build Support** and **iOS Build Support** if you want to build to a mobile device. 
        1. Under **Documentation** make sure to select **Documentation**
    1. If you forget to check any modules above you can do it after Unity is installed. 
    1. Click on the **Install**
    1. The correct version should now be installing
1. Now that the correct version of Unity is installed, you can move forward in the project


## Project Instructions

1. Print out and assemble the MergeCube and ClassCube (found in the **CubesForVuforia** folder)
1. Download the code from this GitHub
1. Unzip the file and move the file into the Unity folder that was created
1. Before opening you have to install Vuforia

### Install Vuforia

1. Navigate to the [vuforia website](https://developer.vuforia.com/)
1. Create an account then navigate to **Downloads** page 
1. Download [Vuforia 10.9](https://developer.vuforia.com/downloads/sdk) via Unity Hub (It should be the first option **Add Vuforia Engine to a Unity Project or upgrade to the latest version**)
1. Once the download is complete click to open the .unityPackage, this should open Unity Hub and download the Vuforia package

### Setting up project
1. Click **Open** in the Unity **Projects** page and select the project folder where this project is saved to open it.
1. It should spend some time processing and will open up the project
1. Once opne you may have to import Vuforia to do this go to **Assets** from there **Import Package** and then **Custom Package** you should be able to then import all the files required.  
1. Additionally, you will need a Vuforia key to have the project work correctly:
    1. Go to the [Vuforia website](https://developer.vuforia.com/vui/develop/licenses)
        1. Create a Vuforia developer account
        1. Under the **Develop** tab ensure you are on the **License Manager** page
        1. Click on **Get Development Key** to create a license key.
        1. Once created you should get the key that you can now copy
    1. Go to the Unity project
        1. On the top bar, find the **Window** tab and scroll to **Vuforia Configuration** 
        1. Paste this key in the **Global** section of the **Vuforia Configuration** window in the right hand menu in Unity
1. In the **Project** folder in the bottom part of Unity in there is an **Assets** folder, which contains a *Scenes** folder
1. In the **Scenes** folder there is a file named **ThemeParkCubes.unity**, drag it into the hieracy (not inside any scene) and delete the Default scene/cameras that are there. 
1. Congratulations! If you open the Scene, under ARCamera you should see two models, MagicKingdom (Cube 1) and SuperNintendoWorld (Cube2). Print out the merge and  If you click the play you can now use AR to see the two cube designs on the physical cubes built.


If there are problems installing, ensure that the **com.ptc.vuforia.engine-10.9.3.tgz** is in the **Packages** folder


You can find further information about Vuforia and Unity [here](https://library.vuforia.com/getting-started/getting-started-vuforia-engine-unity).

