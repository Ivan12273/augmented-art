# Augmented Art

Personal Augmented Reality project created with Unity and Vuforia.

This project is an AR application that works with markers. The purpose is that users can scan a marker that is close to a painting (or that is the painting itself) and that the application displays the frame with an animation and three options that users will be able to select, the options would include:
1. Button to take a screenshot.
2. Button to show information regarding the work.
3. Button to show some reference video.

## Content
- [Design](#design)
    - [Home](#instalación)
    - [Target detected](#target-detected)
    - [Information box](#information-box)
    - [Playing the video](#playing-the-video)
- [Development](#development)
    - [Creating the home panel](#creating-the-home-panel)
    - [Image editing](#image-editing)
    - [Adding the target and the painting](#adding-the-target-and-the-painting)
    - [Animation in Unity](#animation-in-unity)
    - [Information button programming](#information-button-programming)
    - [Video button programming](#video-button-programming)
    - [Screenshot button programming](#screenshot-button-programming)
- [Testing the application](#testing-the-application)
- [Available targets](#available-targets)
- [Future updates](#future-updates)
- [Download the demo](#download-the-demo)
- [Videos used in the project](#videos-used-in-the-project)

## Design
Before I started building the program, I had to think about the layout and graphic elements that I would use to present the information to the user.
For the elaboration of the UI designs of the application, I used the [figma](https://www.figma.com/) tool, as a result, the following GUIs were elaborated for the project:

### Home
The first thing the user will see when starting the application, I made both the logo and the background with the [Krita](https://krita.org/) editing tool.

![augmented art](img/img1.png)

### Target detected
The corresponding painting will be displayed, includes an animation and the name of the painting is displayed above it along with three buttons:
• On the left is a button to take screenshots.
• On the right is the button that displays information about the painting and also the button that displays a video related to it.

![augmented art](img/img2.png)

### Information box
When the user presses the information button, this box is shown that includes: the image and the name of the painting, the name of the artist and a brief description of the painting.

![augmented art](img/img3.png)

### Playing the video
When the user presses the video button, a box with the video related to the painting will be displayed.

![augmented art](img/img4.png)

## Development
In this section I describe my process of creating the project.

### Creating the home panel
For the home interface I created a canvas in the project, to this I added the elements that I designed previously: the background, the button, the logo and the texts, for the text I had to download and import the SourceSansPro source in the project.

![augmented art](img/Img5.png)

An animation was included to give a more interactive effect to the home panel, the animation makes the home button fade and reappear subtly.

![augmented art](img/img6.png)

The button closes the home panel when pressed and in turn starts the ARCamera:

![augmented art](img/img7.png)

### Image editing
For each animation I had to edit some images of each painting, I did this with the Krita editing tool:

![augmented art](img/img8.png)

Edited images for The Starry Night painting:

![augmented art](img/img9.png)

Once the necessary images were finished, I imported them into Unity and converted them into sprites so that I could use them in the tool:

![augmented art](img/img10.png)

### Adding the target and the painting
A "PlaneTitle" was added to add the title of the painting, new targets were added to the vuforia database and imported.

![augmented art](img/img11.png)

The paint was added on top of the target:

![augmented art](img/img12.png)

### Animation in Unity
Once I imported the images and transformed them into sprites, with the Unity animation tool I put them together by adding the correct time intervals.
With the property "Sprite" I was able to make each image change to another at the moment that I selected:

![augmented art](img/img13.png)

### Information button programming
To add the project buttons, I had to create a new canvas, this time inside the ARCamera hierarchy just below the target and the painting (ImageHolder) so that they can appear together with the frame when the user points with their camera:

![augmented art](img/img14.png)
![augmented art](img/img15.png)

The icon and button were added, some transparency was also added to give it a better effect.
The following functionality was added to the information button:

![augmented art](img/img16.png)

The code basically makes that when the information button is pressed, it activates the panel with the painting information:

![augmented art](img/img17.png)

The panel includes elements such as: titles, description, painting image and a button to close the panel.

![augmented art](img/img18.png)

The functionality of the button to close the panel is similar to that of the button to open it:

![augmented art](img/img19.png)

### Video button programming
The button to display the video works the same as the button to display the information:

![augmented art](img/img20.png)

Video panel:

![augmented art](img/img21.png)

For the video, I added the video player component as well as a new texture so that I can render it:

![augmented art](img/img22.png)

The videos had to be imported prior to the project. To close the panel, this functionality was added to the button:

![augmented art](img/img23.png)

### Screenshot button programming
For the screenshot button, I imported an external Asset called Native Toolkit:

![augmented art](img/img24.png)

The following functionality was added to the screenshot button:

![augmented art](img/img25.png)

When the user presses the button, the application takes a screenshot and stores it on the device, in the path Android > data > com.IvnAguilar.AugmentedArt.

## Testing the application
Home

![augmented art](img/img26.jpg)

Turning the camera on

![augmented art](img/img27.jpg)

Detecting the target

![augmented art](img/img28.jpg)
![augmented art](img/img29.jpg)

Pressing the information button

![augmented art](img/img30.jpg)

Pressing the video button

![augmented art](img/img31.jpg)

Screenshot saved

![augmented art](img/img32.jpg)

## Available targets

![augmented art](img/img33.png) ![augmented art](img/img34.png)
![augmented art](img/img35.png) ![augmented art](img/img36.png)
![augmented art](img/img37.png)

## Future updates
• New elements in the information panel that may be useful for the user or more interesting data. 
• Updates for the video panel so the user can pause, control volume, or rewind and forward.
• New buttons to increase interaction with the user, an idea that was contemplated at the beginning was a button that displayed a new view with the gallery of all the paintings available in the application.
• New animations for each painting, also new effects or improve the existing ones.
• More paints could be added to the application to increase the information available.

## Download the demo
You can download the demo clicking [here](https://drive.google.com/file/d/1-CGjKvBhqWzglTTI2ZHqnVuAv0tLanPF/view?usp=sharing)

## Videos used in the project
All the videos used in this project are not mine. These are the original authors:

[Mona Lisa Video](https://www.youtube.com/watch?v=IitbJszd1kM)

[Starry Night Video](https://www.youtube.com/watch?v=x-FiTQvt9LI)

[American Gothic Video](https://www.youtube.com/watch?v=vk2GvyNmYD0)

[Café Terrace at Night Video](https://www.youtube.com/watch?v=cliOvhDDtcY)

[The Scream Video](https://www.youtube.com/watch?v=a6WtQt-QQnc)
