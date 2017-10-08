module ElmishSample.View

open Elmish.Xamarin.Forms.VirtualDOM
open ElmishSample.Types

let stack model dispatch =
    stackLayout [
        VerticalOptions Xamarin.Forms.LayoutOptions.Center
    ] [
        label [
            HorizontalTextAlignment Xamarin.Forms.TextAlignment.Center
            LabelAttribute.Text "Welcome to Elmish.Xamarin.Forms!"
        ]
    ]

let detail model dispatch =
    navigationPage [
        contentPage []
            (stack model dispatch)
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
    contentPage
        [   ContentPageAttribute.Title "Elmish sample"
            Icon "hamburgericon.png"
        ]
        (menuTable model dispatch)



let root model dispatch =
    masterDetailPage
        [   IsPresented model.masterPresented
            OnIsPresentedChanged (BoolEvent.Event <| (UpdateMasterPresented >> dispatch))
        ]
        (menu model dispatch)
        (detail model dispatch)
