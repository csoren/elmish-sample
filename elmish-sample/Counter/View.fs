module ElmishSample.Counter.View

open Elmish.Xamarin.Forms.VirtualDOM
open ElmishSample.Counter.Types

let stack model dispatch =
    stackLayout [
        StackLayoutAttribute.HorizontalOptions Xamarin.Forms.LayoutOptions.FillAndExpand
        StackLayoutAttribute.VerticalOptions Xamarin.Forms.LayoutOptions.FillAndExpand
    ] [
        stackLayout [
            StackLayoutAttribute.Orientation Xamarin.Forms.StackOrientation.Horizontal
            StackLayoutAttribute.HorizontalOptions Xamarin.Forms.LayoutOptions.CenterAndExpand
        ] [
            button [
                ButtonAttribute.HorizontalOptions Xamarin.Forms.LayoutOptions.Center
                ButtonAttribute.Text "-1"
                OnClicked (UnitEvent.Event <| fun () -> dispatch Decrement)
            ]
            button [
                ButtonAttribute.HorizontalOptions Xamarin.Forms.LayoutOptions.Center
                ButtonAttribute.Text "+1"
                OnClicked (UnitEvent.Event <| fun () -> dispatch Increment)
            ]
        ]
        label [
            LabelAttribute.HorizontalOptions Xamarin.Forms.LayoutOptions.Center
            LabelAttribute.Text (sprintf "Count: %d" model.count)
        ]
    ]

let root model dispatch =
    contentPage []
        (stack model dispatch)
    