module ElmishSample.About.View

open Elmish.Xamarin.Forms.VirtualDOM


let stack model dispatch =
    stackLayout [
        StackLayoutAttribute.VerticalOptions Xamarin.Forms.LayoutOptions.Center
    ] [
        label [
            LabelAttribute.HorizontalTextAlignment Xamarin.Forms.TextAlignment.Center
            LabelAttribute.Text "Welcome to Elmish.Xamarin.Forms!"
        ]
    ]


let root model dispatch =
    contentPage []
        (stack model dispatch)
