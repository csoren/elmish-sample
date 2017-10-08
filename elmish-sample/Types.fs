module ElmishSample.Types

type Page =
    | Hello
    | Counter
    | About

type Msg =
    | UpdateCurrentPage of Page

type Model = 
    {   currentPage: Page
    }
