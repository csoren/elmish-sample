module ElmishSample.Counter.State

open Elmish

open Types

let init () =
    { count = 0 }

let update msg model =
    match msg with
    | Increment ->
        { model with count = model.count + 1 }, Cmd.none
    | Decrement ->
        { model with count = model.count - 1 }, Cmd.none
