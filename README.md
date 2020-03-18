# EECS4471VRLabs

Fahad Khan 214468888 

Acknowledgements:

https://docs.unity3d.com/2018.3/Documentation/Manual/UnityManual.html

Lab0a Scene Description: A movie poster blocking a highway 

Lab0b Description of the elements added to the scene : 

Camera movements= W : up ,
                  X : down , 
                  D : Right ,
                  A : Left ,
                  I : 90 rotation around Z axis ,
                  P : 180 rotation around Z axis ,
                  M : -90 rotation around Z axis ,
                  J : -180 rotation around Z axis ,
                  
Light changes = L : increases intensity to 4 , 

Cube/Sphere Changes= S : shifts selection from Cube to Sphere , 
                     K : deletes selected , 
                     N : initiates a new version of selected ,
                          
LAB0c : DESCRIPTION

there are three animation clips: 
RectBounce = animation of articulated object ( baseball and softball connected with a rod).
flybycamera = animation of Camera zooming in on the movie poster with an attached spot light.
seperatecube = a seperate cube animated on it's own , moving from left to right infront of the poster.

To trigger the Camera Flyby Animation, press Space.
To trigger the Articulated object animation, press Q.


LAB1 : DESCRIPTION

there are two targets, cube is dynamic(rigidBody) and sphere is static. 
The launcher is a blue object and projectile is on top if it as a red sphere bullet.
To launch the project with medium speed, press Right arrow.
To launch the project with fast speed, press UP arrow.
To launch the project with slow speed, press Left arrow.
To shift launcher to right(towards sphere target),press D.
To shift launcher to left(towards cube target),press A.
To shift launcher to up,press F.
To shift launcher to down,press G.
To switch to the Projectile Camera angle, press P.
To switch to the Target Camera angle, press T.
To switch to the Main/Launcher Camera angle, press M.

Lab2: DESCRIPTION

A button that adds primitive objects to the scene (in random locations/orientations) = LIndexTrigger on touch controller;  
A button that allows objects to fall under the effect of gravity = B on touch controller;   
A button to cause all objects to undergo an impulse force = A on touch controller; 
global UI/screen overlay canvas triggered on and off by pressing the ‘m’ key on the keyboard.
Local UI/World space canvas : button to change sphere's color to green. 
                              slider to change sphere's scale between 1-5.
                              button to change cube's position to right.
                              slider to rotate cube.
