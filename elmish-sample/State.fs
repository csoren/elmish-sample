module ElmishSample.State

open ElmishSample.Types
open Elmish

let init () =
    {   masterPresented = false
        currentPage = About
    },
    Cmd.none

let update msg model =
    match msg with
    | UpdateMasterPresented presented ->
        { model with masterPresented = presented }, Cmd.none
    | UpdateCurrentPage page ->
        { model with
            masterPresented = false
            currentPage = page
        },
        Cmd.none
