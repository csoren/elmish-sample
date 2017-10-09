module ElmishSample.View

open Elmish.Xamarin.Forms.VirtualDOM
open ElmishSample.Types

let subPage model dispatch page : Elmish.Xamarin.Forms.VirtualDOM.Page =
    match page with
    | Counter -> Counter.View.root model.counter (CounterMsg >> dispatch)
    | _ -> About.View.root model dispatch

let detail model dispatch =
    navigationPage [
        subPage model dispatch model.currentPage
    ]


let textCell dispatch text msg =
    textCell [
        TextCellAttribute.Text text
        OnTapped (UnitEvent.Event <| fun () -> dispatch msg)
    ]

let menuTable model dispatch =
    let menuItem title pageId =
        textCell dispatch title (UpdateCurrentPage pageId)

    tableView [
        Intent Xamarin.Forms.TableIntent.Menu
    ] [
        tableSection [
            TableSectionAttribute.Title "Pages"
        ] [
            menuItem "Hello" Hello
            menuItem "Counter" Counter
            menuItem "About" About
        ]
    ]


let menu model dispatch =
    contentPage [
        ContentPageAttribute.Title "Elmish sample"
        Icon "hamburgericon.png"
    ]   (menuTable model dispatch)


let root model dispatch =
    masterDetailPage [
        IsPresented model.masterPresented
        OnIsPresentedChanged (BoolEvent.Event <| (UpdateMasterPresented >> dispatch))
    ]   (menu model dispatch)
        (detail model dispatch)
