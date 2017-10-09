module ElmishSample.State

open ElmishSample.Types
open Elmish

let init () =
    {   masterPresented = false
        currentPage = About
        counter = Counter.State.init ()
    },
    Cmd.none

let update msg model =
    match msg with
    | CounterMsg msg ->
        let (counterModel, counterMsg) = Counter.State.update msg model.counter
        { model with counter = counterModel }, Cmd.map CounterMsg counterMsg
    | UpdateMasterPresented presented ->
        { model with masterPresented = presented }, Cmd.none
    | UpdateCurrentPage page ->
        { model with
            masterPresented = false
            currentPage = page
        },
        Cmd.none
