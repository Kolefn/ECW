# Entity-Component-Wrapper
> A design pattern for Unity.

![ECW Diagram](https://kolenunley.com/portfolio/img/ECW_Diagram.jpg)

I was excited when I started working with Unity. It all seemed so easy and simple. That was until a week or so into development. Once my project reached a certain complexity, the 'Cowboy Coding' pattern I was following, which is common within the Unity community, ceased to be so easy and simple. My code was a mess of inheritance and huge over-reaching classes. So I did some research and discovered the [Model-View-Controller](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller) pattern.

I had used MVC before, but I was surprised to see people were using it in Unity. I thought this would be the solution to my problems. I restarted the development of my game and followed the MVC guidelines as strictly as I could. Overall, this worked well and improved the design 10x. However, eventually I came to some road blocks and had to rethink my design. 

MVC in Unity attempts to seperate data,logic, and visuals of your game. To go a step further, many people suggest to seperate your game logic and data from Unity all-together. This is a fundamental conflict because Unity doesn't just offer pretty graphical representation of data. It also handles an immense amount of logic and data organization. Another issue I ran into while using MVC was difficult extendability.

How do I give a character a new ability like Fireblast? It's similar to Frostbolt but has a different animation, mana-cost, cast-time, ect. I will end up rewriting a lot of duplicate model & view code, and modifying one or more controllers. I'm not saying this is bad or unclean (it can be), but it doesn't sound fun. I believe ECW offers a solution to these problems.


![Game Prototype](https://kolenunley.com/portfolio/img/ECW_Prototype_Game.gif)

*A prototype for an arena game built using Cowboy then rebuilt with MVC. I am currently working on a ECW version. The cube character has 5 abilities including an 'ultimate'. The dummies respawn after death.*


Entity-Component-Wrapper is a slight improvement on [Entity-Component](https://en.wikipedia.org/wiki/Entity%E2%80%93component%E2%80%93system). EC is the core pattern of Unity. The thing that attracted me to Unity was the ability to simply plugin components on the fly. You can create new behaviors and looks just by mixing and matching components. 

ECW offers the same benefits but abstracts away the Unity GameObject, utilities (Time, Debug, Vector3, ect), and Components. It also makes light (as light as possible!) use of messaging and callbacks for inter-component communication and for updating components that need to be in-touch with the game loop.

### ECW Benefits
1. Extendable
2. Abstracted From Unity
3. Organized
4. Fun

### ECW Issues
1. Messaging and Callbacks are gross.
2. Abstracting Unity requires a lot of boilerplate code. 

## Example Project

A Unity project (ExampleProject) is provided with example scenes for Cowboy, EC, MVC, and ECW patterns.

```sh
git clone https://github.com/Kolefn/ECW.git
```
Manual: 

1. Download
2. Unzip


Open Unity and click 'add existing' project. Select ExampleProject folder.

Load the example scene in the pattern folder of interest.

## Meta

Kole Nunley – [Website](https://kolenunley.com)

Distributed under the MIT license. See ``LICENSE`` for more information.

[My GitHub](https://github.com/Kolefn/)

## Contributing

1. Fork it (<https://github.com/Kolefn/REINFORCEpp/fork>)
2. Create your feature branch (`git checkout -b feature/fooBar`)
3. Commit your changes (`git commit -am 'Add some fooBar'`)
4. Push to the branch (`git push origin feature/fooBar`)
5. Create a new Pull Request :D
