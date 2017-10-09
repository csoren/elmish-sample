module ElmishSample.Hello.State

open Elmish

open Types

let init () =
    {   name = ""
    }

let update msg model =
    match msg with
    | UpdateName name ->
        { model with name = name }, Cmd.none
