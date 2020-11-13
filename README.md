From ConsoleApp1 dir:
`dotnet run -- build ./ConsoleApp1.csproj /p:blah`
Expected result: 
/p:blah is not a file so it is left as an unmatched token
Result:
Error: File does not exist: /p:blah