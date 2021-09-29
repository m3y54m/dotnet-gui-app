# .NET Desktop App with GUI for Linux

A getting started project for .NET 5.0 with C# and AvaloniaUI in Linux

https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code
https://github.com/AvaloniaUI/Avalonia

## Commands

### Install AvaloniaUI Templates

https://github.com/AvaloniaUI/avalonia-dotnet-templates

```console
dotnet new -i Avalonia.Templates
```

### Creating a new MVVM Application

```console
dotnet new avalonia.mvvm -o dotnet-gui-app
cd dotnet-gui-app
```

### Install AvaloniaUI minimum required packages

https://www.nuget.org/packages/Avalonia/

https://www.nuget.org/packages/Avalonia.Desktop/

https://www.nuget.org/packages/Avalonia.ReactiveUI/

https://www.nuget.org/packages/Avalonia.Diagnostics/


```console
dotnet add package Avalonia --version 0.10.7
dotnet add package Avalonia.Desktop --version 0.10.7
dotnet add package Avalonia.ReactiveUI --version 0.10.7
dotnet add package Avalonia.Diagnostics --version 0.10.7
```

## Add .NET gitignore file

```console
dotnet new gitignore
```

## Run the app

```console
dotnet run
```