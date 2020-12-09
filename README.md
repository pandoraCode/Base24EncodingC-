
 
 # Base24Encoding in C#

# Description
Custom base64Encoding in C#.

 Base64/ : The classlib
 
 TestBase64lib/ : A c# console application to desmonstrate the use of the created lib

## Usage in custom project
Download Base64.dll from Base64/bin/Debug/netstandard2.0 and place it in the root folder of you project.

Add the following to your .csproj file

```Dotnet
    <ItemGroup>
  <Reference Include="Base64.dll">
    <HintPath>to/path</HintPath>
    <SpecificVersion>True</SpecificVersion> 
  </Reference>
 </ItemGroup>

```

Then in your .cs file, add:

```csharp
  using Base64;
  
  ...
  base64.Encode(Byte[] source)


```





Merci :)
