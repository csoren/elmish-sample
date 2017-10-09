module ElmishSample.Types

type Page =
    | Hello
    | Counter
    | About

type Msg =
    | CounterMsg of Counter.Types.Msg
    | HelloMsg of Hello.Types.Msg
    | UpdateMasterPresented of bool
    | UpdateCurrentPage of Page

type Model = 
    {   masterPresented: bool
        currentPage: Page
        counter: Counter.Types.Model
        hello: Hello.Types.Model
    }
