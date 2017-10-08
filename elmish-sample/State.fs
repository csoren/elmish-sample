module ElmishSample.State

open ElmishSample.Types
open Elmish

let init () =
    { currentPage = About }, Cmd.none

let update msg model =
    match msg with
    | UpdateCurrentPage page ->
        { model with currentPage = page }, Cmd.none
