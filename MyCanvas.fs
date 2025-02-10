module Canvas

open Fable.Core

// A WebComponent following https://developer.mozilla.org/en-US/docs/Web/API/Web_components/Using_custom_elements#implementing_a_custom_element
[<AttachMembers>]
type MyCanvas() =
    inherit Inheritable.HTMLElement()



[<EntryPoint>]
let main _ = 0 // to avoid warning FS0988: Main module of program is empty