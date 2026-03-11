# GDIM32 In Class Activities
## Instructions
Put each week's activities under new headers like the one shown above. Headers are created with the # symbol. More # symbols = smaller header.


Hit enter TWICE to create a new line.


- Create bullet points by writing dashes.
- Here's another bullet point entry.


## W1
### Activity 1
- Start Minigames early in order to take advantage of support lines such as office hours, online TA troubleshooting, as well as having peers playtest.
- Make sure all assignments are done and fuction correctly, even if it's turned in past due. Many times will programmers lift code from previous works and apply it to new ones.
- In-Class Activities provide background for future minigames, poay attention to them and the lectures.

### Activity 2
1. The value of x after running the program will be 10.
2. The value of x after running the program will be 2
3. An update functions runs every frame, meaning that every frame the phrase "hello world" will be displayed on the console.
4. Monobehaviour
5. The debug log on the console will pring "x = 10".
6. The lines of code display an argument, which can be used within a parameter to allow for variance within the output depending on the input variable.
7. Transform can not be called by itself, as the resulting translation will not be in accordance to any object ingame. 
8. The variable "_playerTransform" would have to be called in order to create an instance of transformation.

### Activity 3
[https://docs.google.com/document/d/1FBSt1IHePMj8a95307bpUR8aoZhdvcjZGS16ntWBc2M/edit?tab=t.0]

## W2
### Activity 1
![IMG_2593](https://github.com/user-attachments/assets/c0202c74-d555-422d-918a-528169e72340)

### Activity 2
[https://github.com/R3stl3ssDr3ams/mg2-R3stl3ssDr3ams/commit/59a28bf498782e65723b874a306b4519e38b765f]
Added sprite for penguin, and gave it the ability to jump after inputting the space key. Created a private bool to prevent player from jumping infinitely.

## W3
### Activity 0
Jasmine Caicedo

### Activity 3
![IMG_2653](https://github.com/user-attachments/assets/f0002ded-00e1-430a-9cd9-4328d3b8016d)

## W4
### Activity 0
Jasmine Caicedo

### Activity 1
If more than one GameObject share the Locator script, they will delete themselves until one remains. This does not mean the object itself is deltered, however, just the script.

### Activity 2
<img width="1159" height="869" alt="image" src="https://github.com/user-attachments/assets/f66d4dfb-ebc7-459b-877c-ce0ff2d30181" />

### Activity 3
[https://github.com/R3stl3ssDr3ams/HW4]
Added the sprites for the pipe and the bird in the scene, and added colliders in order to allow the pipe to be easily instiated and function with triggers for the player.

## W5
### Activity 1
I would be willing to keep the general form of these classes the same, and given that every item is unique, would maintain their seperation in classes in order to modify their behavior.
If they all utilized the same mechanics and behaviors between them, I would create one class to use between all items using the inheritance from previous classes; that is not the case, however.

### Activity 2
Model : "ScriptableObjects"
View: "DialogueBubble" and "InventoryUI"
Controller: "Player Class"

### Activity 3

#### Scenario 1
All beats would be attached to a set of prefabs with with a set Transform and SpriteRenderer, which would be associated with a ScriptableObject to set what key is bound to said beat. Beat would 
be an abstract class with children depending on the type of beat in order to dictate it's speed and transform. A singleton would be used to script events in order to trigger UI and audio effects, 
as well as destroying the beat game object on note hit. A finite state machine would be attached to a timer in order to dictate the point value that each beat will earn.

#### Scenario 2
Finite state machine would be useful for the growth state of plants which can be manipulated by the type of plant it dervies from. Plant bheavior would likely also derive from a parent abstract class 

#### Scenario 3
Model-View-Controller is used to take player action, through a Player Class, and bring it to the view by modifying the appropriate data through ScriptableObjects, this can include modifying 
the health values of the player or the opponent.

### Activity 4
Present Members: Jasmine Caicedo, Eli Gutierrez, and myself.
First Draft [https://docs.google.com/document/d/1GxlGKB6HPG_Q6x96TOvyybNU5x_lLUS-DKCN9NGH8AQ/edit?tab=t.0]

## W6
### Activity 1
Gizmos would be particularly useful for being able to visualize and directly tweak several elements within the scene, such as collision between objects, which would be needed to facillitate 
interaction and ensure it happens on an even pace. Breakpoints would likewise be useful in debugging to visualize what is and isn't working, which would in theory improve our productivity.

### Activity 2
Attendance: Jasmine Caicedo, Eli Gutierrez, and myself.
Final Draft [https://docs.google.com/document/d/1GxlGKB6HPG_Q6x96TOvyybNU5x_lLUS-DKCN9NGH8AQ/edit?tab=t.0]

## W7
### Activity 1
Raycasting allow vectors to determine sightlines in between objects, which can be used alongside enums to incite behavioral changes. Since the raycast has it's own collision, it can identify 
the tag with objects it collides with.

### Activity 2
Attendance: Jasmine Caicedo, Eli Gutierrez, and myself.

### Activity 3
<img width="1177" height="872" alt="image" src="https://github.com/user-attachments/assets/35b8799f-bac6-4750-9fc9-ff2141d72023" />


### Activity 4
[https://trello.com/b/1inv3wX9/tasks-for-melt-ice]

### Activity 5
[https://github.com/the-elig/GDIM32-Final/blob/main/Melt%20ICE/Assets/Scripts/GameController.cs]

Created a simple GameController class with a locator to find player as a singleton for events which we plan to introduce as we develop this project. Enums are also created as its own member variable, 
which will be used as to instill changes in behavior when both the NPC and Item classes are introduced.

## W8
### Activity 1
Post-processing can outline visial effects within a unity project, and unity packages can be used as an asset in order to import directly into the scene. These packages can be properlly adjusted under 
the Inspector.

### Activity 2
Attendance: Jasmine Caicedo, Eli Gutierrez, and myself.

### Activity 3
![IMG_3015](https://github.com/user-attachments/assets/91ef2c21-86cb-4fd0-aaa2-159793477995)

### Activity 4
I plan to work on loading new scenes and implementing some of the inventory UI.

### Activity 5
[https://github.com/the-elig/GDIM32-Final/commit/f5ce4c7754f615e64076c35b62718f9d83ed2401]
<img width="1597" height="751" alt="Screenshot 2026-02-24 202146" src="https://github.com/user-attachments/assets/f7fdffca-1fd0-4f6c-9a47-3708f71b8e3e" />

Updated assets on the main scene to allow player to switch to a new scene if it interacts with an object with the correct tags. Also moved to locator to the player class in order to streamline singleton event usage 
as well as to not destroy it between scenes and, hopefully, maintain its inventory specifically.

## W9
### Activity 1
Scaling: You know your code will scale well when the program being written can actually handle large amounts of data. This means it's performant, and easy for users to understand / build from. One can hard code all functions within scripts, but it's simpler to create a state machine, or establish an event system, that aid in moving between different states of the game. For future reference, it would be easier to work with collaborators if all code were to scale well.

Dialogue should be a ScriptableObject
DialogueController class can determine which NPC is being interacted with and what prompts to include.

### Activity 2
Attendance: Jasmine Caicedo, Eli Gutierrez, and myself.

### Activity 3
[https://docs.google.com/document/d/1b0oo95CZ6u7DW9ZBhBZXP5bItpNVOOE1IcDawrM76n0/edit?tab=t.0]

### Activity 4
I plan to work mainly on fixing a bug where characters frim the first scene, who were intentionally given the DontDestroy script due to their properties that they would need ot keep between scenes, would still appear before the player between scenes.

### Activity 5
<img width="992" height="724" alt="Screenshot 2026-03-03 230250" src="https://github.com/user-attachments/assets/8ed2350d-4404-4118-9557-2748ef5c372f" />

I was having several complications creating a function that would definitively run after a new scene loaded; ultimately, checking the scene name within an updata functioin turned out to be the most effective option, even if not the most efficient. I plan to come to this at a later date, however.

## W10
### Activity 1
Attendance: Jasmine Caicedo, Eli Gutierrez, and myself.

### Activity 2
Game was received well, with players complimenting the visual design and music. Bugs, however, persist in our build, with the sister still spawning in the main scene, and the cup duplicating within the scene.

### Activity 3
The project is close to finishing; as said, last week, the fundamentals have been set to allow the project to advance smoothly, and we're approaching the end. All to say that our project should closely resemenble the project that we pitched, even if we had to scale down the scope of our environment.

### Activity 4
In large part, I worked on bug fixing alongside Eli and the rest of the LAs, as we encountered a bug where objects that would function in one scene would stop working in another. We found it was an error in moving the event system between scenes, but my commit looks rather scarce since most of my work is reflected within Eli's commit. Regardless, on my behalf I worked on a series of bugs that needed fixing, including:
1.  double sister
2. double neighbor
3. cup respawn
4. key respawn
5. only one inventory slot at a time