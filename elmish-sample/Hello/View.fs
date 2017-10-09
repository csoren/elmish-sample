module ElmishSample.Hello.View

open Elmish.Xamarin.Forms.VirtualDOM
open ElmishSample.Hello.Types

let stack model dispatch =
    stackLayout [
        StackLayoutAttribute.HorizontalOptions Xamarin.Forms.LayoutOptions.FillAndExpand
        StackLayoutAttribute.VerticalOptions Xamarin.Forms.LayoutOptions.FillAndExpand
    ] [
        entry [
            EntryAttribute.Placeholder "First name"
            EntryAttribute.Text model.name
            EntryAttribute.Margin (Xamarin.Forms.Thickness 16.0)
            EntryAttribute.OnTextChanged (StringEvent.Event <| (UpdateName >> dispatch))
        ]
        label [
            LabelAttribute.HorizontalOptions Xamarin.Forms.LayoutOptions.Center
            LabelAttribute.Text (sprintf "Hello, %s" model.name)
        ]
    ]

let root model dispatch =
    contentPage []
        (stack model dispatch)
    