# Rain World Mod Template

This is a template for [BepInEx](https://github.com/BepInEx/BepInEx)-powered mods for [Rain World](https://store.steampowered.com/app/312520/Rain_World/).

## How do I use this template?

1. To get started, navigate to https://github.com/Pixelstormer/rain-world-mod-template and click the green '*Use this template*' button, then click '*Create a new repository*', or follow [these instructions](https://docs.github.com/en/repositories/creating-and-managing-repositories/creating-a-repository-from-a-template).
2. Choose a name for your mod, and change all instances of 'your name' & 'your mod name' as appropriate:
    - `yourmodname.csproj`
        - Rename this file
        - Change the `AssemblyName` property - this value is used for your mod's [GUID](https://rainworldmodding.miraheze.org/wiki/BepInPlugins#Step_2.3_-_Setting_up_the_mod's_information)
        - Change the `Product` property - this value is used for your mod's display name
        - Change  the `ModFolderName` property
    - `YourModName.cs`
        - Rename this file
        - Rename the `yourmodname` namespace
        - Rename the `YourModName` class
    - `assets/modinfo.json`
        - Change the `id` value - this should be the same as your mod's GUID
        - Change the `name` value - this should be the same as your mod's display name
        - Change the `authors` value - this should be your own name
        - Change the `description` value
    - `assets/thumbnail.png`
        - Replace this with a suitable thumbnail for your mod
3. Mod away!

### Running the mod

In order to run the mod, you need to follow a couple of simple steps:
1. Compile the mod by running `dotnet build`. This will create the `build` folder, and another folder inside it, which will be named according to the `ModFolderName` property in the `yourmodname.csproj` file.
2. Navigate to whereever you have Rain World installed, then copy or move the aforementioned `ModFolderName` folder into the `RainWorld_Data/StreamingAssets/mods` folder.
3. Launch the game, and enable your mod from the remix menu.

Tip: Running `dotnet build` compiles your mod with the 'Debug' configuration, which generates extra debug information and disables optimisations. This can be helpful for development, but if your mod is having performance issues, or you want to share it with other people, you should compile it in the 'Release' configuration instead, by running `dotnet build -c Release`.
