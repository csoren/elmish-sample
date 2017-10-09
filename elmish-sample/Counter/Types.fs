module ElmishSample.Counter.Types

type Msg =
    | Increment
    | Decrement

type Model = 
    {   count: int
    }
