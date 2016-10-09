## IO-ControlModule
A general lightweight application framework for I/O control and remote monitoring using TCP protocol for M2M solutions.

[](https://github.com/EdoLabWorks/ximgs/blob/master/newIOmodule.png)

Using C# and WPF, you have the full .NET framework at your disposal for your remote monitoring and control applications.

Our focus here is to show from the web control interface how we can control in simulation - devices, instruments or machines using simple LED indicators to give us a first hand feel and insight during our initial application development process.

Later on, you can easily integrate actual I/O sensors/actuators or instruments/machine interfacing with its device driver in a PC-Based automation solutions.  

Using simple toggle buttons, you can send back and forth ON/OFF control signals to a remote server.
With its built asynchronous internal TCP server you can receive incoming control signals from any connected clients. 
Currently, the internal TCP client/server settings are set to default "localhost" or "127.0.0.1" for inter-process communication only. 

This application should be used together with the [NodeJS web control interface](https://github.com/EdoLabWorks/NodeJS-Web-Control-Project).

### Usage
To give it a quick try, just open it in Visual Studio from your development PC and run [NodeJS web control interface](https://github.com/EdoLabWorks/NodeJS-Web-Control-Project) application as a separate process.

[](https://github.com/EdoLabWorks/ximgs/blob/master/canvas.png)
[](https://github.com/EdoLabWorks/xedo-imgs/blob/master/OverviewIOModule.png)

### License
MIT



