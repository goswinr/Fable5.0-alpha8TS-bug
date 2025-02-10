
run
`dotnet tool restore`

then
`dotnet fable --lang typescript --noCache`

to observe

```
.\Inheritable.fs(1,1): error FABLE: Unable to find a valid constructor for generating interface via ParamObject, please make sure the constructor has at least one parameter.
Compilation failed
```

with
fable 5.0-alpha8

in
fable 5.0-alpha7 it works fine
