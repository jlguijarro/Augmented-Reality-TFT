# Augmented Reality Project


Design and development of an augmented reality application deployed on Android Platforms

<br/>
<br/>

<!-- SHOULD I INCLUDE INPUT MANAGER INFO? SCREENSHOT IN DOC -->
 # RC 1.0 Final Project Branch


In this branch the first release candidate's development is done.

This document collects the different steps built for the consecution of this RC.

<br/>
<br/>



## Project architecture

<br/>

![Project Architecture](/mdImages/projectArchitecture.png "Project Architecture")

<br/>

- Android: Android is the deployment platform used for the project, it compiles into .apk
- Unity: Unity is the development platform used to create the application.
    - AR Core: Google's AR Core is the main plugin used to bring AR characteristics
    - Progamming Languages
        - C#: For Unity development
        - uXML for UI development
        - CSS for UI development
- Firebase: RealTime DB for storaging data
- UX Design: Figma as UI designer and Blender for creating the AR models.

<br/>
<br/>


## Version Control

<br/>

The version control is done through branches wich record the different development steps:

- [v0.1](https://github.com/jlguijarro/Augmented-Reality-Unity-App/tree/AR/v0.1) : Project Configuration. AR Markers
- [v0.2](https://github.com/jlguijarro/Augmented-Reality-Unity-App/tree/AR/v0.2) : Unity packages. Components modified. UX Research
- [v0.3](https://github.com/jlguijarro/Augmented-Reality-Unity-App/tree/AR/v0.3) : C# Logic. Observer pattern added. UX designs
- [v0.4](https://github.com/jlguijarro/Augmented-Reality-Unity-App/tree/AR/v0.4) : UI Implementation using UI Toolkit
- [v0.5](https://github.com/jlguijarro/Augmented-Reality-Unity-App/tree/AR/v0.5) : Firebase and API connections


<br/>

## Application Logic

<br/>

The Application logic information and working mechanisms can be appreciated in the following diagram:

![Application Logic Diagram](/mdImages/AppLogicDiagram.png "Application Logic Diagram")


<br/>
<br/>


## UX Research

<br/>


The UX Research was made using Google Forms, results were the following:

![UX Research](/mdImages/UXResearch.png "UX Research")

<br/>
<br/>

## UI Design

<br/>

The UI design was made using Figma:

![UI Design](/mdImages/UIDesign.png "UI Design")


<br/>

In case you want an .apk build to test and play around with the application you need an Android System with at least Android 7.0 Nougat version. Due to the .apk build size is impossible for me to update it to Github, anyways you can e-mail me for an .apk build to one of the followings emails:

joseluisguijarrorubio@alumnos.upm.es
joseluisguijarrorubio@gmail.com