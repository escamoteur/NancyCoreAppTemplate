# NancyCoreApp Template

This repository contains a basic NancyFx App running on .Net Core using Kestrel as Host.

### Installation
To install this template use

`dotnet new –install Nancy.Templates.BasicNetCoreApp::*`

Which will install the template into the .Net Core Template Cache

### Usage

In a console window type

`dotnet new NancyCoreApp -n "NameOfNewProject" -o "locationOfNewProject"`

where `NameOfNewProject` will be used as project and namespace name of the newly created project.

### Updating the template

Before you can install a new version of the template you have currently to clear the .Net Core Template Cache with

`dotnet new --debug:reinit`

In future there will be a way to uninstall templates selectively

### Modifyig the template

After you are happy with the changes you made copy the content of the project directory ro the `nuget\content` folder and run nuget from the nuget folder.
