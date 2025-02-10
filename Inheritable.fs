


/// All classes in this module are empty.
/// They are only used to allow inheriting from types defined as interface.
/// Use this module when you need to inherit from type that is only defined as an interface.
[<RequireQualifiedAccess>] // don't open this. it would shadow the interfaces
module Inheritable

open Fable.Core

/// This is NOT a Browser.Types.HTMLElement !
/// It is just an empty class with the same name.
/// It used only for inheriting the Browser.Types.HTMLElement interfaces in F#.
/// Use like: ' type [<AttachMembers>] MyClass() = inherit Inheritable.HTMLElement()'
/// Then inside the class you can get the current instance via 'base.this' as Browser.Types.HTMLElement
[<Global>]
[<AllowNullLiteral>]
type HTMLElement() =

    [<Global>]
    member _.this : Browser.Types.HTMLElement = jsNative

