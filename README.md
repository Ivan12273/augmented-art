# Augmented Art

Personal Augmented Reality project created with Unity and Vuforia.

This project is an AR application that works with markers. The purpose is that users can scan a marker that is close to a painting (or that is the painting itself) and that the application displays the frame with an animation and three options that users will be able to select, the options would include:
1. Button to take a screenshot.
2. Button to show information regarding the work.
3. Button to show some reference video.

## Content
- [Design](#Design)

## Design
Before I started building the program, I had to think about the layout and graphic elements that I would use to present the information to the user.
For the elaboration of the UI designs of the application, I used the [figma](https://www.figma.com/) tool, as a result, the following GUIs were elaborated for the project:

### Home
The first thing the user will see when starting the application, I made both the logo and the background with the [Krita](https://krita.org/) editing tool.

![augmented art](img/img1.PNG)

### Target detected
The corresponding painting will be displayed, includes an animation and the name of the painting is displayed above it along with three buttons:
• On the left is a button to take screenshots.
• On the right is the button that displays information about the painting and also the button that displays a video related to it.

![augmented art](img/img2.PNG)

### Information box
When the user presses the information button, this box is shown that includes: the image and the name of the painting, the name of the artist and a brief description of the painting.

![augmented art](img/img3.PNG)

### Playing the video
When the user presses the video button, a box with the video related to the painting will be displayed.

![augmented art](img/img4.PNG)
