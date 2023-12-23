# ByteBrusher.CLI

## Overview
Give a brief description of your project here...
(e.g., This application is a C# 10.0 Rider Project, targeting .NET 6.0, serving the purpose of ...)

## Prerequisites
- .NET 8.0 installed
- JetBrains Rider 2023.3.2 (recommended IDE)

## Checking Out the Project
Use the following command to checkout the project:main

```bash
git clone  
```

## Building the Project
In the JetBrains Rider IDE, use the 'Build' option under the 'Build' menu. However, you can also build the project through console with the following command:
```bash
dotnet build
```

## Running the Project
To run the built output, use the 'Run' option under the 'Run' menu in the JetBrains Rider IDE. Alternatively, you can use the console command:
```bash
dotnet run --project ByteBrusher.CLI
```

## Parameters

The CLI application accepts the following parameters:
--path <value>: The path where the application should perform operations.
Example usage: --path C:/Users/ExampleUser/Documents/ExampleFolder
--deleteFlag: An optional flag that, when present, indicates that the application should delete something (replace 'something' with the actual operation).
Example usage: --deleteFlag
--includeVideos: An optional flag that, when present, indicates that the application should include videos in its operations.
Example usage: --includeVideos
--includeDocuments: An optional flag that, when present, indicates that the application should include documents in its operations.
Example usage: --includeDocuments
These parameters can be used individually or combined depending on the operation you want to perform.
For example, to run the application on a specific path and include videos and documents, you would use the following command:
```bash
dotnet run --project ByteBrusher.CLI --path C:/Users/ExampleUser/Documents/ExampleFolder --includeVideos true --includeDocuments true
```