## louncher.json (?)
{
    // Use IntelliSense to learn about possible attributes.
    // Hover to view descriptions of existing attributes.
    // For more information, visit: https://go.microsoft.com/fwlink/?linkid=830387
    "version": "0.2.0",
    "configurations": [
    {
        "name": ".NET Core Launch (console)",
        "type": "coreclr",
        "request": "launch",
        //"program": "${fileDirname}/bin/Debug/net5.0/",
        //"program": "${file}",
        "program": "${workspaceFolder}/bin/Debug/<insert-target-framework-here>/<insert-project-name-here>.dll",
        "args": [],
        "cwd": "${workspaceFolder}",
        "stopAtEntry": false,
        "console": "internalConsole"
    }
    ]
}