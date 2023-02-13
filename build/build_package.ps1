# Taken from psake https://github.com/psake/psake

# Clear Release folder
Remove-Item -Path ..\src\bin\Release\*.nupkg
dotnet clean ..\src\OkoloIt.Architecture.Cqrs.csproj -c Release;

# Build Project
dotnet build ..\src\OkoloIt.Architecture.Cqrs.csproj -c Release;
dotnet pack ..\src\OkoloIt.Architecture.Cqrs.csproj -c Release;