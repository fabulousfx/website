module FabulousWebsite.Client

open Elmish
open Elmish.React
open Feliz
open FabulousWebsite.Client
open FabulousWebsite.Client.Pages

type Model = NoModel

type Msg = NoMsg

type CmdMsg = NoCmdMsg

let mapToCmd cmdMsg =
    Cmd.none

let init () =
    NoModel, []

let update msg model =
    model, []

let view model dispatch =
    Html.div [
        Navbar.view ()
        Home.view ()
    ]

#if DEBUG
open Elmish.Debug
open Elmish.HMR
#endif

Program.mkProgramWithCmdMsg init update view mapToCmd
#if DEBUG
|> Program.withConsoleTrace
#endif
|> Program.withReactBatched "elmish-app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
