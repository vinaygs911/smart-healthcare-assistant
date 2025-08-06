@echo off
dotnet clean SmartHealthAssistant.sln -c Debug -p:Platform="Any CPU"
dotnet restore
dotnet build SmartHealthAssistant.sln -c Debug -p:Platform="Any CPU"