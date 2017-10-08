module ElmishSample.Types

type Page =
    | Hello
    | Counter
    | About

type Msg =
    | UpdateMasterPresented of bool
    | UpdateCurrentPage of Page

type Model = 
    {   masterPresented: bool
        currentPage: Page
    }
