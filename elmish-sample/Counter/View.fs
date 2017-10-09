module ElmishSample.Counter.View

open Elmish.Xamarin.Forms.VirtualDOM
open ElmishSample.Counter.Types

let stack model dispatch =
    stackLayout [
        StackLayoutAttribute.HorizontalOptions Xamarin.Forms.LayoutOptions.FillAndExpand
        StackLayoutAttribute.VerticalOptions Xamarin.Forms.LayoutOptions.FillAndExpand
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
        label [
            LabelAttribute.HorizontalOptions Xamarin.Forms.LayoutOptions.Center
            LabelAttribute.Text (string model.count)
        ]
    ]

let root model dispatch =
    contentPage []
        (stack model dispatch)
    