module ElmishSample.App

open Elmish
open Elmish.Xamarin.Forms.Application

let init () =
    Program.mkProgram State.init State.update View.root
    |> asApplication
