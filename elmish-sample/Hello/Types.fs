module ElmishSample.Hello.Types

type Msg =
    | UpdateName of string

type Model = 
    {   name: string
    }
