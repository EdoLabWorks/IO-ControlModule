# IO-ControlModule
A lightweight device monitor and control simulator for M2M applications.

[](https://github.com/EdoLabWorks/xedo-imgs/blob/master/BlueIOModule.png)
![](https://github.com/EdoLabWorks/ximgs/blob/master/newIOmodule.png)

Using C# and WPF, you have the full .NET framework at your disposal for your remote monitoring and control applications.

Our focus here is to show from the web control interface how we can control in simulation - devices, instruments or machines using simple LED indicators to give us a first hand feel and insight during our initial application development process.

Also as a simple demonstration in reverse process, how we can send real-time notifications from our IO-control module to the web control interface.

If you press the toggle buttons on each device front-panel section, you can send an ON/OFF message and change the button color of the web control interface correspondingly. 

Although we are just using simple websocket messaging here, the same concept can be used to provide real-time control instead of just notification to our M2M applications.

This application should be used together with the NodeJS Web Control interface.

For now, just open it in debug mode in Visual Studio and run the NodeJS Web Control application.

[](https://github.com/EdoLabWorks/ximgs/blob/master/canvas.png)
[](https://github.com/EdoLabWorks/xedo-imgs/blob/master/OverviewIOModule.png)





