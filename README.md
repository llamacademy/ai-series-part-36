# Navmesh AI Tutorial 36 - NavMeshAgents Opening Doors

In this tutorial repository you will learn how to construct doors that NavMeshAgents will open when they come nearby.

A few notes about the implementation:
1. These doors automatically open when an Agent comes nearby using a Trigger, which requires your NavMeshAgents to have a Rigidbody on them.
2. These doors automatically close when all Agents have left the Trigger. To make the doors stay open, simply do not call `Door.Close();`
3. There is no animation currently tied to this opening behavior. There are some high level comments in [DoorTrigger.cs](https://github.com/llamacademy/ai-series-part-36/Assets/Scripts/DoorTrigger.cs) on how you can do that.

[![Youtube Tutorial](./Video%20Screenshot.png)](https://youtu.be/kFHvdI08Cus)

## Patreon Supporters
Have you been getting value out of these tutorials? Do you believe in LlamAcademy's mission of helping everyone make their game dev dream become a reality? Consider becoming a Patreon supporter and get your name added to this list, as well as other cool perks.
Head over to https://patreon.com/llamacademy to show your support.

### Gold Tier Supporters
* YOUR NAME HERE!

### Silver Tier Supporters
* Raphael
* Andrew Bowen
* Gerald Anderson
* YOUR NAME HERE!

### Bronze Tier Supporters
* Bastian
* Trey Briggs
* AudemKay
* YOUR NAME HERE!

## Other Projects
Interested in other AI Topics in Unity, or other tutorials on Unity in general? 

* [Check out the LlamAcademy YouTube Channel](https://youtube.com/c/LlamAcademy)!
* [Check out the LlamAcademy GitHub for more projects](https://github.com/llamacademy)

## Requirements
* Requires Unity 2019.4 LTS or higher. 
* Utilizes the [Navmesh Components](https://github.com/Unity-Technologies/NavMeshComponents) from Unity's Github.