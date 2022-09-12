# Visual Programming in C# .NET framework

## Getting Started With .NET Framework
#
### Installation 

For Linux, Visual Studio is not available. So we will install Visual Studio Code either using the apt command from terminal or manually downloading the .deb file from the official website.

```
sudo apt install code
```

<a href="https://docs.microsoft.com/en-us/dotnet/core/install/">
Click here
</a> to install .NET SDK and core.

Or for debian based devices like ubuntu run the following commands in the terminal


> **Imp: You must install the dotnet core in the directory where you will be creating the projects**

```
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb 

sudo dpkg -i packages-microsoft-prod.deb 

sudo apt update 

sudo apt install apt-transport-https 

sudo apt install dotnet-sdk-6.0 
```
### Project Creation

After the installation of .NET core, we simply create a project in the specific directory using the terminal integrated with VS Code.


```
dotnet new console -o HelloWorld
```
This creates a separate directory for the project with the name HelloWorld.

```
cd HelloWorld
```
This helps us to enter the project directory.
```
dotnet run
```
This builds the projects and compiles the files creating a ```/bin``` directory which contains a ```HelloWorld.dll``` file.
